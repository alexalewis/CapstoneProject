using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CapstoneProject.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapstoneProject.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class QuestionnaireController : ControllerBase
  {

    readonly private DatabaseContext _context;

    public QuestionnaireController(DatabaseContext context)
    {
      _context = context;
    }

    [HttpPost("questions")]

    public async Task<ActionResult<User>> AnswersToQuestions(User user)
    {

      var updatedUser = new User
      {
        Age = user.Age,
        Zipcode = user.Zipcode,
        HousingType = user.HousingType,
        HaveYard = user.HaveYard,
        IsFenced = user.IsFenced,
        IsActive = user.IsActive,
        OtherAnimals = user.OtherAnimals,
        TypeOfOtherAnimal = user.TypeOfOtherAnimal,
        SmallChildren = user.SmallChildren,
      };
      _context.Users.Add(updatedUser);
      await _context.SaveChangesAsync();

      return Ok(updatedUser = user);

    }

  }
}