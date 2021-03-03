using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piratenpartij.Cargos;
using Piratenpartij.Ships;

namespace Piratenpartij.Obstacles
{

    //TradeEvent could happen against a Merchant ship along a trip
    public class TradeEvent : Event
    {
        private readonly Random random = new Random();
        public List<KeyValuePair<Cargo, int>> EventCargos { get; set; }
        Dictionary<Cargo, int> shipCargos = Ship.GetInstance().Cargo;

        public TradeEvent() : base(EventType.MERCHANT_SHIP)
        {

            EventCargos = new List<KeyValuePair<Cargo, int>>() {
                new KeyValuePair<Cargo, int>(new MountainHoliday(), random.Next(10, 100)),
                new KeyValuePair<Cargo, int>(new Peugeot208(), random.Next(10, 100)),
                new KeyValuePair<Cargo, int>(new AMSPortfolio(), random.Next(10, 100))
            };


        }
        public void Trade()
        {
            KeyValuePair<Cargo, int> randomCargo = EventCargos[random.Next(0, 3)];
            if (shipCargos.Where(sc => sc.Key.GetType() == randomCargo.Key.GetType()).Any()) {
                KeyValuePair<Cargo, int> temp = shipCargos.Where(sc => sc.Key.GetType() == randomCargo.Key.GetType()).First();
                    shipCargos[temp.Key] += randomCargo.Value;
                }
            Status = Enums.EventStatus.FINISHED;
        }

        public void Overtake()
        {
            foreach (KeyValuePair<Cargo, int> cargo in EventCargos) {
                if (shipCargos.Where(sc => sc.Key.GetType() == cargo.Key.GetType()).Any()) {
                    KeyValuePair<Cargo, int> temp = shipCargos.Where(sc => sc.Key.GetType() == cargo.Key.GetType()).First();
                    if (cargo.Key.GetType() == temp.Key.GetType()) {
                        shipCargos[temp.Key] += cargo.Value;
                    }
                }
            
            }
            Status = Enums.EventStatus.FINISHED;
        }

        public void Ignore()
        {
            Status = Enums.EventStatus.FINISHED;
        }

    }
}
