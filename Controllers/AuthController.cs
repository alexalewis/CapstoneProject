using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CapstoneProject.Models;
using CapstoneProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CapstoneProject.Controllers
{
  [Route("auth")]
  [ApiController]
  public class AuthController : ControllerBase
  {


    private DatabaseContext _context;

    public AuthController(DatabaseContext context)
    {
      _context = context;
    }

    private object CreateJwt(User user)
    {
      var expirationTime = DateTime.UtcNow.AddHours(10);

      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new[]
        {
            new Claim("id", user.Id.ToString()),
            new Claim("email", user.Email),
            new Claim("firstName", user.FirstName),
            new Claim("lastName", user.LastName)
        }),
        Expires = expirationTime,
        SigningCredentials = new SigningCredentials(
              new SymmetricSecurityKey(Encoding.ASCII.GetBytes("THE SAME REALLY LONG STRING")),
              SecurityAlgorithms.HmacSha256Signature
            )
      };
      var tokenHandler = new JwtSecurityTokenHandler();
      var token = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));

      return (token);
    }

    [HttpPost("signup")]
    public async Task<ActionResult> SignUpUser(NewUser newUser)
    {
      if (newUser.Password.Length < 7)
      {
        return BadRequest("Password must be at least 7 characters");
      }

      var doesUserExist = await _context.Users.AnyAsync(user => user.Email.ToLower() == newUser.Email.ToLower());
      if (doesUserExist)
      {
        return BadRequest("User already exists with that email");
      }

      var user = new User
      {
        Email = newUser.Email,
        FirstName = newUser.FirstName,
        LastName = newUser.LastName,
      };

      var hashed = new PasswordHasher<User>().HashPassword(user, newUser.Password);
      user.HashedPassword = hashed;
      _context.Users.Add(user);
      await _context.SaveChangesAsync();

      user.HashedPassword = null;
      return Ok(new { Token = CreateJwt(user), user = user });
    }

    [HttpPost("login")]

    public async Task<ActionResult> Login(UserLogin userLogin)
    {

      var user = await _context.Users.FirstOrDefaultAsync(user => user.Email.ToLower() == userLogin.Email.ToLower());
      if (user == null)
      {
        return BadRequest("User does not exist");
      }

      var results = new PasswordHasher<User>().VerifyHashedPassword(user, user.HashedPassword, userLogin.Password);

      if (results == PasswordVerificationResult.Success)
      {
        user.HashedPassword = null;
        return Ok(new { Token = CreateJwt(user), user = user });
      }
      else
      {
        return BadRequest("Incorrect password");
      }

    }
  }
}
