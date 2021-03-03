using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        public void fight()
        {
            if (randomIntForEvent > avgStrength) {
                Crewmembers = ship.Crew;

                Crewmember randomCrewmember = Crewmembers[random.Next(0, Crewmembers.Count())];

                ship.Crew.Remove(randomCrewmember);

                ship.Money = ship.Money - random.Next(0, 101);

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                System.Windows.Forms.MessageBox.Show(randomCrewmember.Name + " got killed in the fight", "Continue", buttons, MessageBoxIcon.Warning);
            } else {
                Crewmembers = ship.Crew;
                ship.Crew.Add(Crewmembers[random.Next(0, Crewmembers.Count())]);

                ship.Money = ship.Money + random.Next(0, 101);
            }
        }

        public void intimidate()
        {
            if (randomIntForEvent > avgTrading) {
                ship.Money = ship.Money - random.Next(0, 101);
            }
            else {
                ship.Money = ship.Money + random.Next(0, 101);
            }
        }

        public void run()
        {
            if (randomIntForEvent > avgIntelligence) {
                ship.Money = ship.Money - random.Next(0, 101);

                Crewmembers = ship.Crew;

                Crewmember randomCrewmember = Crewmembers[random.Next(0, Crewmembers.Count())];

                ship.Crew.Remove(randomCrewmember);

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                System.Windows.Forms.MessageBox.Show(randomCrewmember.Name + " is killed by pirtes", "Continue", buttons, MessageBoxIcon.Warning);
            }
            else {
                Console.WriteLine("Won run");
            }
        }
    }
}