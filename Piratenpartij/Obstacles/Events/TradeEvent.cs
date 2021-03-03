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
            foreach (KeyValuePair<Cargo, int> shipCargo in shipCargos) {
                if (shipCargo.Key.GetType() == randomCargo.Key.GetType()) {
                    shipCargos[shipCargo.Key] += randomCargo.Value;
                }
            }
            Status = Enums.EventStatus.FINISHED;
        }

        public void Overtake()
        {
            foreach (KeyValuePair<Cargo, int> cargo in EventCargos) {
                foreach (KeyValuePair<Cargo, int> shipCargo in shipCargos) {
                    if (shipCargo.Key.GetType() == cargo.Key.GetType()) {
                        shipCargos[shipCargo.Key] += cargo.Value;
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
