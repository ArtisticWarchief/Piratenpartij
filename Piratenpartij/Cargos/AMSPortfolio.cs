using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Cargos
{
    public class AMSPortfolio : Cargo
    {
        public AMSPortfolio() : base()
        {
            cargoType = CargoTypes.Portofolio;

            maximumBuyPrice = 300;
            minimumBuyPrice = 10;

            maximumSellPrice = 200;
            minimumSellPrice = 5;
        }
    }
}
