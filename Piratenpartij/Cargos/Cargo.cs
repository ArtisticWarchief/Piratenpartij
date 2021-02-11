using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Cargos
{
    public class Cargo
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int LimitOnShip { get; set; }

        public Cargo(string name, int price, int limitOnShip)
        {
            Name = name;
            Price = price;
            LimitOnShip = limitOnShip;
        }
    }
}
