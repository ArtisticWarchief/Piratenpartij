using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crewmembers;

namespace Piratenpartij.Obstacles
{
    //CombatEvent could happen against a Pirates ship along a trip
    public class CombatEvent : Event
    {

        readonly Random random;
        public Ships.Ship ship = Ships.Ship.GetInstance();

        public List<Crewmember> Crewmembers { get; set; }

        private int avgIntelligence;
        private int avgStrength;
        private int avgTrading;
        private int amountOfCrewMembers;
        int randomIntForEvent;

        public CombatEvent(Random random) : base(EventType.PIRATES_SHIP)
        {
            this.random = random;
            Crewmembers = ship.Crew;
            amountOfCrewMembers = Crewmembers.Count();

            avgIntelligence = ship.CrewAbilities.ElementAt(0).Value / amountOfCrewMembers;
            avgStrength = ship.CrewAbilities.ElementAt(1).Value / amountOfCrewMembers;
            avgTrading = ship.CrewAbilities.ElementAt(2).Value / amountOfCrewMembers;

            randomIntForEvent = random.Next(0, 100);
            chooseCombatEventType();
        }
        
        public void chooseCombatEventType()
        {
            int chosenNumber = random.Next(0, 3);

            if (chosenNumber == 0) {
                fight();
            }
            else if (chosenNumber == 1) {
                intimidate();
            }
            else {
                run();
            }
        }

        public void fight()
        {
            if (randomIntForEvent > avgStrength) {
                Crewmembers = ship.Crew;
                ship.Crew.Remove(Crewmembers[random.Next(0, Crewmembers.Count())]);

                ship.Money = ship.Money - 100;

                Console.WriteLine("Lost battle");
            } else {
                Console.WriteLine("Won battle");
                Crewmembers = ship.Crew;
                ship.Crew.Add(Crewmembers[random.Next(0, Crewmembers.Count())]);

                ship.Money = ship.Money + 100;
            }
        }

        public void intimidate()
        {
            if (randomIntForEvent > avgTrading) {

                ship.Money = ship.Money - 100;

                Console.WriteLine("Lost intimidate");
            }
            else {

                ship.Money = ship.Money + 100;

                Console.WriteLine("Won initmidate");
            }
        }

        public void run()
        {
            if (randomIntForEvent > avgIntelligence) {
                ship.Money = ship.Money - 100;

                Console.WriteLine("Lost run");
            } else {
                Console.WriteLine("Won run");
            }
        }
    }
}