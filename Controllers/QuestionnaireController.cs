using System.Linq;
using System.Threading.Tasks;
using CapstoneProject.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CapstoneProject.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

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
      currentUser.LookingFor = user.LookingFor;
      currentUser.IsActive = user.IsActive;
      currentUser.TypeOfOtherAnimal = user.TypeOfOtherAnimal;
      currentUser.SmallChildren = user.SmallChildren;

      _context.Entry(currentUser).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return Ok(currentUser);
    }

  }
}