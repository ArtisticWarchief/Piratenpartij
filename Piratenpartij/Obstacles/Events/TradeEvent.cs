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
        static readonly Random random = new Random();

        private Dictionary<Cargo, int> EventCargos { get; set; }
        public TradeEvent() : base(EventType.MERCHANT_SHIP)
        {

            EventCargos = new Dictionary<Cargo, int> {
                { new MountainHoliday(), random.Next(10, 100) },
                { new Peugeot208(), random.Next(10, 100) },
                {new AMSPortfolio(), random.Next(10, 100) },
            };


        }
        public void Trade()
        {

            Status = Enums.EventStatus.FINISHED;
        }

        public void Overtake()
        {
            Dictionary<Cargo, int> shipCargos = Ship.GetInstance().Cargo;
            foreach(KeyValuePair<Cargo, int> cargo in EventCargos) {
                if (shipCargos.ContainsKey(cargo.Key)) {
                    shipCargos[cargo.Key] += EventCargos[cargo.Key];
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
