namespace CapstoneProject.Models
{
  public class Favorite
  {
    public int Id { get; set; }

    public int UserId { get; set; }
    public User user { get; set; }

    public int AnimalId { get; set; }
    public Animal animal { get; set; }
  }
}