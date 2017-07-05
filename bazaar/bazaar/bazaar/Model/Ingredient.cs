using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bazaar.Model
{
    class Ingredient
    {
        public String Name { get; set; }
        public DateTime Bought { get; set; }
        public String PlaceBought { get; set; }
        public String AddressPlaceBought { get; set; }
        public bool Have { get; set; }
        public TimeSpan TimeTillFinished { get; set; }
    }
}
