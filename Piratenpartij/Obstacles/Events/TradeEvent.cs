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

        public Dictionary<Cargo, int> EventCargos { get; set; }
        Dictionary<Cargo, int> shipCargos = Ship.GetInstance().Cargo;

        public TradeEvent() : base(EventType.MERCHANT_SHIP)
        {

            EventCargos = new Dictionary<Cargo, int> {
                { new MountainHoliday(), random.Next(10, 100) },
                { new Peugeot208(), random.Next(10, 100) },
                {new AMSPortfolio(), random.Next(10, 100) },
            };


        }
        public void Trade(Cargo cargo, int amount)
        {
            if (EventCargos.Where(ec => ec.Key.GetType() == cargo.GetType() && ec.Value >= amount).Any()) {
                KeyValuePair<Cargo, int> matchedPair = EventCargos.Where(c => c.Key.GetType() == cargo.GetType()).First();
                EventCargos[matchedPair.Key] -= amount;
                if (shipCargos.Where(sc => sc.Key.GetType() == cargo.GetType()).Any()) {
                    KeyValuePair<Cargo, int> temp = shipCargos.Where(c => c.Key.GetType() == cargo.GetType()).First();
                    shipCargos[temp.Key] += amount;
                }
            }

            Status = Enums.EventStatus.FINISHED;
        }

        public void Overtake()
        {
            foreach (KeyValuePair<Cargo, int> cargo in EventCargos) {

                if (shipCargos.Where(c => c.Key.GetType() == cargo.Key.GetType()).Any()) {
                    KeyValuePair<Cargo, int> temp = shipCargos.Where(c => c.Key.GetType() == cargo.Key.GetType()).First();
                    shipCargos[temp.Key] += cargo.Value;
                }
            }
            Status = Enums.EventStatus.FINISHED;
        }

        public void Ignore()
        {
            Status = Enums.EventStatus.FINISHED;
        }

    }
    public enum EventAction
    {
        TRADE, OVERTAKE, IGNORE
    }
}
