using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BakeryWithAuth.Models
{
  public class Treat
  {
  

    public int TreatId { get; set; }
    [Required(ErrorMessage = "Please enter a treat name.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Please enter a treat description.")]
    public string Description { get; set; }
    [Required(ErrorMessage = "Please enter a treat price.")]
    public List<FlavorTreat> JoinEntities { get; set; }
  }
}