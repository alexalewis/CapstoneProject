using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CapstoneProject.Models
{
  public class User
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Age { get; set; }
    public string Zipcode { get; set; }
    public string HousingType { get; set; }
    public bool HaveYard { get; set; }
    public string LookingFor { get; set; }
    public bool IsActive { get; set; }
    public string TypeOfOtherAnimal { get; set; }
    public bool SmallChildren { get; set; }

    [JsonIgnore]
    public string HashedPassword { get; set; }

    public List<Favorite> Favorites { get; set; } = new List<Favorite>();

  }
}