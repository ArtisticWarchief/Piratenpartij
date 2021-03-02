using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piratenpartij.Cargos;

namespace Piratenpartij.Obstacles
{

    //TradeEvent could happen against a Merchant ship along a trip
    public class TradeEvent : Event
    {
        public TradeEvent() : base(EventType.MERCHANT_SHIP){}
        private List<Cargo> Cargos { get; set; }

        static readonly Random random = new Random();

        public void Trade()
        {

            Status = Enums.EventStatus.FINISHED;
        }

        public void Overtake()
        {
            Ship.Ship.GetInstance();
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
