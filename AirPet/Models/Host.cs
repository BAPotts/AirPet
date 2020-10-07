namespace AirPet.Models
{
  public class Host
  {
    public int HostId { get; set; }
    public string Name { get; set; }
    public string Pets { get; set; }
    public string Bio { get; set; }
    public int LocationId { get; set; }
    public virtual Location Location { get; set; }
  }
}