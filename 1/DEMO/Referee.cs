using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    public class Referee
    {
        public string? Name { get; set; }
      
        public override string ToString()
        {
            return $"Referee: {Name}";
        }

        public void Look(Location location) => Console.WriteLine($"{this} is Looking to {location}");
    }
}
