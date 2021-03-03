using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piratenpartij.Ships;
using Piratenpartij.Cargos;
using Crewmembers;
using System.Windows.Forms;

namespace Piratenpartij.Obstacles
{
    //IslandEvent could happen whenever an island appears along a trip
    public class IslandEvent : Event
    {
        readonly Random random;
        public Ships.Ship ship = Ships.Ship.GetInstance();

        public string islandName { get; set; }
        public List<Crewmember> Crewmembers { get; set; }
        public string option { get; set; }

        private string[] islandNames = { "Hawaii", "Madagaskar", "Malediven", "Australië", "Palawan", "Santorini", "Maderira", "Gili" };
        private string[] goodOptions = { "Peugeot208", "AMSPortfolio", "MountainHoliday" };
        private string[] badOptions = { "disease", "lion attack", "earthquake" };
        


        public IslandEvent(Random random) : base(EventType.ISLAND)
        {
            this.random = random;
        }

        public bool CallIslandEvent()
        {
            Boolean goodOption = random.Next(0, 2) > 0;
            islandName = islandNames[random.Next(0, 7)];

            Dictionary<Cargo, int> cargoDict = ship.Cargo;

            if (goodOption) {
                option = goodOptions[random.Next(0, 2)];
                int goodOptionValue = random.Next(0, 5);
                Cargo cargo;

                if (option == "Peugeot208") {
                    cargo = cargoDict.Keys.FirstOrDefault(e => e.GetType() == typeof(Peugeot208));
                }
                else if (option == "AMSPortfolio") {
                    cargo = cargoDict.Keys.FirstOrDefault(e => e.GetType() == typeof(AMSPortfolio));
                }
                else {
                    cargo = cargoDict.Keys.FirstOrDefault(e => e.GetType() == typeof(MountainHoliday));
                }

                ship.Cargo[cargo] += goodOptionValue;

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                System.Windows.Forms.MessageBox.Show("You got some " + option, "Continue", buttons, MessageBoxIcon.Warning);

                return true;
            }
            else {
                option = badOptions[random.Next(0, 2)];

                Crewmembers = ship.Crew;

                Crewmember randomCrewmember = Crewmembers[random.Next(0, Crewmembers.Count())];

                ship.Crew.Remove(randomCrewmember);

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                System.Windows.Forms.MessageBox.Show("A crew member is killed by a(n) " + option, "Continue", buttons, MessageBoxIcon.Warning);

                return false;
            }
        }
    }
}