using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    public class Player
    {
        public string? Name { get; set; }
        public string? Team { get; set; }

        public override string ToString()
        {
            return $"{Name} , {Team}";
        }

        public void Run(Location location) => Console.WriteLine($"{this} is Running towards {location}");

    }
}
