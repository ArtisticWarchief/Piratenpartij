using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piratenpartij.Cargos;
using Crewmembers;
using Piratenpartij.Cargos;

namespace Piratenpartij.Ship
{
    public class Ship
    {
        public List<Crewmember> Crewmembers { get; set; }
        public Dictionary<Cargo, int> Cargo { get; set; }
        //public Trip Trip { get; set; }
        public int Food { get; set; }
        public int Fun { get; set; }
        public int Money { get; set; }
        public string Destination { get; set; }
        private static Ship ShipInstance;

        public static Ship GetInstance()
        {
            if (ShipInstance != null) {
                return ShipInstance;
            }
            else {
                ShipInstance = new Ship(8);
                return ShipInstance;
            }
        }

        readonly Random random = new Random();

        public Dictionary<string, int> AbilitiesTotal()
        {
            int Intelligence = 0;
            int Strength = 0;
            int Hunger = 0;
            int Trading = 0;

            foreach (Crewmember Crew in Crewmembers) {
                Intelligence += Crew.Ability.GetAbilities()[0];
                Strength += Crew.Ability.GetAbilities()[1];
                Hunger += Crew.Ability.GetAbilities()[2];
                Trading += Crew.Ability.GetAbilities()[3];
            }

            Dictionary<string, int> CrewAbilities = new Dictionary<string, int> {
                { "intelligence", Intelligence },
                { "strength", Strength },
                { "hunger", Hunger },
                { "trading", Trading }
            };
            return CrewAbilities;
        }

        private Ship(int crewAmount)
        {
            Crewmembers = new List<Crewmember>();
            for (int i = 0; i < crewAmount; i++) {
                Crewmembers.Add(new Crewmember());
            }
            Cargo = new Dictionary<Cargo, int> { { new MountainHoliday(), 100 }, {new Peugeot208(), 2 }, { new AMSPortfolio(), 10 } };
            //Trip = new Trip();
            Food = 100;
            Fun = 100;
            Money = 0;
            Destination = "";
        }
    }

}


