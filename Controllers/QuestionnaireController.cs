using System.Linq;
using System.Threading.Tasks;
using CapstoneProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

    [HttpPost]

    public async Task<ActionResult<User>> AnswersToQuestions(User user)
    {
      var userId = int.Parse(User.Claims.FirstOrDefault(claim => claim.Type == "id").Value);
      var currentUser = await _context.Users.FirstOrDefaultAsync(f => f.Id == userId);

      currentUser.Age = user.Age;
      currentUser.Zipcode = user.Zipcode;
      currentUser.HousingType = user.HousingType;
      currentUser.HaveYard = user.HaveYard;
      currentUser.IsFenced = user.IsFenced;
      currentUser.IsActive = user.IsActive;
      currentUser.OtherAnimals = user.OtherAnimals;
      currentUser.TypeOfOtherAnimal = user.TypeOfOtherAnimal;
      currentUser.SmallChildren = user.SmallChildren;


      _context.Users.Add(currentUser);
      await _context.SaveChangesAsync();
      return Ok(currentUser);
    }



  }
}