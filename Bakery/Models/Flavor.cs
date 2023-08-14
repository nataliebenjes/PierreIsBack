using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Bakery.Models
{
    public class Flavor
    {
        public int FlavorId { get; set; }
        public string FlavorName { get; set; }
        public List<TreatFlavor> JoinEntities { get; }
        public ApplicationUser User { get; set; }
    }
}