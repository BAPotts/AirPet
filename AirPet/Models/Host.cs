namespace AirPet.Models
{
  public class Host
  {
    public int HostId { get; set; }
    public string Description { get; set; }
    public int LocationId { get; set; }
    public virtual Location Location { get; set; }
  }
}