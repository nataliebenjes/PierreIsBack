using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Bakery.Models
{
    public class Treat
    {
        public int TreatId { get; set; }
        public string TreatName { get; set; }
        public List<TreatFlavor> JoinEntities { get; }
        public ApplicationUser User { get; set; }
    }
}