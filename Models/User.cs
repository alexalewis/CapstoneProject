using System.Collections.Generic;

namespace CapstoneProject.Models
{
  public class User
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string HashedPassword { get; set; }
    public int Age { get; set; }
    public int Zipcode { get; set; }
    public string HousingType { get; set; }
    public bool HaveYard { get; set; }
    public bool IsFenced { get; set; }
    public bool OtherAnimals { get; set; }
    public string TypeOfOtherAnimal { get; set; }
    public bool SmallChildren { get; set; }

    public List<Match> Match { get; set; } = new List<Match>();

  }
}