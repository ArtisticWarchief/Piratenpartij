using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    public class Attribute
    {
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public int Hunger { get; set; }
        public int Trading { get; set; }

        readonly Random random = new Random();

        public Attribute() {
            Intelligence = random.Next(0, 100);
            Strength = random.Next(0, 100);
            Hunger = random.Next(0, 100);
            Trading = random.Next(0, 100);
        }
    }
}
