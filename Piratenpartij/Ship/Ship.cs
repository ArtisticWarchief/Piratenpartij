using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piratenpartij.Cargos;
using Crewmembers;
using Piratenpartij.Abilities;

namespace Piratenpartij.Ships
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

        public Dictionary<AbilityNames, int> CrewAbilities = new Dictionary<AbilityNames, int> {
                {(AbilityNames)0, 0},
                {(AbilityNames)1, 0},
                {(AbilityNames)2, 0}
        };

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

        public string showCrew()
        {
            string Crew = "";
            foreach (Crewmember C in Crewmembers){
                Crew += C.ToString() + ", ";
            };
            return Crew;
        }

        public string crewAbilitiesTotal()
        {
            int amount = CrewAbilities.Count();
            string total = "";
            for (int i = 0; i < amount; i++) {
                KeyValuePair<AbilityNames,int> item = CrewAbilities.ElementAt(i);
                total += item.Value.ToString() + " " + item.Key.ToString() + ", ";
            };
            return total;
        }

        private Ship(int crewAmount)
        {          

            Crewmembers = new List<Crewmember>();
            for (int i = 0; i < crewAmount; i++) {
                Crewmember Crew = new Crewmember(random);
                Crewmembers.Add(Crew);
                AbilityNames ability1 = CrewAbilities.ElementAt(0).Key;
                CrewAbilities[ability1] += Crew.Ability.GetAbilities()[0];
                AbilityNames ability2 = CrewAbilities.ElementAt(1).Key;
                CrewAbilities[ability2] += Crew.Ability.GetAbilities()[1];
                AbilityNames ability3 = CrewAbilities.ElementAt(2).Key;
                CrewAbilities[ability3] += Crew.Ability.GetAbilities()[2];
            };
            Console.WriteLine("You have the following crew: " + showCrew());
            Console.WriteLine("The combined stats of your crew are as follows: " + crewAbilitiesTotal());
            Cargo = new Dictionary<Cargo, int> { { new MountainHoliday(), 100 }, {new Peugeot208(), 2 }, { new AMSPortfolio(), 10 } };
            //Trip = new Trip();
            Food = 100;
            Fun = 100;
            Money = 0;
            Destination = "";
        }
    }

}


