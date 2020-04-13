using System;
using System.Collections.Generic;

namespace CapstoneProject.Models
{
  public class Animal
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string CatOrDog { get; set; }
    public string Breed { get; set; }
    public string RescueCenter { get; set; }
    public int Zipcode { get; set; }
    public string HousingType { get; set; }
    public bool NeedYard { get; set; }
    public bool GoodWithOtherAnimals { get; set; }
    public bool GoodWithSmallChildren { get; set; }
    public bool IsActive { get; set; }
    public bool IsNeutered { get; set; }
    public bool IsVaccinated { get; set; }
    public DateTime DateAdded { get; set; } = DateTime.Now;

    public List<Match> Match { get; set; } = new List<Match>();

  }
}