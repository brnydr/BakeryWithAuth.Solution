using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BakeryWithAuth.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "Please enter a flavor type.")]
    public string Type { get; set; }
    public List<FlavorTreat> JoinEntities { get; set; }
    public ApplicationUser User { get; set; }
  }
}