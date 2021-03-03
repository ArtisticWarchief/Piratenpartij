using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Cargos
{
    public class Peugeot208 : Cargo
    {
        public Peugeot208() : base()
        {
            cargoType = CargoTypes.Peugeot208;

            maximumBuyPrice = 3000;
            minimumBuyPrice = 100;

            maximumSellPrice = 2000;
            minimumSellPrice = 50;
        }
    }
}
