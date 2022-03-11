using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public string Specialty { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}