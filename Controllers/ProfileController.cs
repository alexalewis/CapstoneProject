using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapstoneProject.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CapstoneProject.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
  public class ProfileController : ControllerBase
  {

    readonly private DatabaseContext _context;

    public ProfileController(DatabaseContext context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<ActionResult> GetUserProfile()
    {
      var userId = int.Parse(User.Claims.FirstOrDefault(claim => claim.Type == "id").Value);

      var user = await _context.Users.FirstOrDefaultAsync(f => f.Id == userId);

      return Ok(user);
    }

    [HttpGet("matches")]

    public async Task<ActionResult> GetMatches()
    {
      var userId = int.Parse(User.Claims.FirstOrDefault(claim => claim.Type == "id").Value);

      var user = await _context.Users.FirstOrDefaultAsync(f => f.Id == userId);

      var matches = await _context.Animals.Where(animal => animal.CatOrDog == user.LookingFor && animal.HousingType == user.HousingType && animal.NeedYard == user.HaveYard && animal.GoodWithSmallChildren == user.SmallChildren && animal.GoodWith == user.TypeOfOtherAnimal).ToListAsync();

      return Ok(matches);
    }

    [HttpPost("favorites/{animalId}")]

    public async Task<ActionResult> SaveFavorites(int animalId)
    {

      var userId = int.Parse(User.Claims.FirstOrDefault(claim => claim.Type == "id").Value);
      var favorite = new Favorite
      {
        UserId = userId,
        AnimalId = animalId
      };

      _context.Favorites.Add(favorite);
      await _context.SaveChangesAsync();
      return Ok(favorite);

    }

    // [HttpGet("favorites")]
    // public async Task<ActionResult<Favorite>> GetFavoriteAnimals(int id)
    // {

    //   var results = _context.Favorites.Where(r => r.Id == favoritesId);
    //   return results;

    // }


  }

}
