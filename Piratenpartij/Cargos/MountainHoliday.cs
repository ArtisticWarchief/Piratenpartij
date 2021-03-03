using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Cargos
{
    public class MountainHoliday : Cargo
    {
        public MountainHoliday() : base()
        {
            cargoType = CargoTypes.Mountain;

            maximumBuyPrice = 1500;
            minimumBuyPrice = 50;

            maximumSellPrice = 1000;
            minimumSellPrice = 25;
        }
    }
}
