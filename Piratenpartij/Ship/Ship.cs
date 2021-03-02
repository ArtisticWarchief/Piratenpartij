using System;
using System.Collections.Generic;
using System.Linq;
using Piratenpartij.Cargos;
using Piratenpartij.Abilities;
using Crewmembers;
using Piratenpartij.Obstacles.Enums;

namespace Piratenpartij.Ships
{
    public class Ship
    {
        public List<Crewmember> Crew { get; set; }
        public Dictionary<Cargo, int> Cargo { get; set; }
        public Trip Journey { get; set; }
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

        public string ShowCrew()
        {
            string CrewString = "";
            foreach (Crewmember C in Crew) {
                CrewString += C.ToString() + ", ";
            };
            return CrewString;
        }

        public Dictionary<AbilityNames, int> CrewAbilitiesDict()
        {
            foreach (Crewmember Crewmate in Crew) {
                AbilityNames ability1 = CrewAbilities.ElementAt(0).Key;
                CrewAbilities[ability1] += Crewmate.Ability.GetAbilities()[0];
                AbilityNames ability2 = CrewAbilities.ElementAt(1).Key;
                CrewAbilities[ability2] += Crewmate.Ability.GetAbilities()[1];
                AbilityNames ability3 = CrewAbilities.ElementAt(2).Key;
                CrewAbilities[ability3] += Crewmate.Ability.GetAbilities()[2];
            }
            
            return CrewAbilities;
        }
        public string CrewAbilitiesString()
        {
            int amount = CrewAbilities.Count();
            string total = "";
            for (int i = 0; i < amount; i++) {
                KeyValuePair<AbilityNames,int> item = CrewAbilities.ElementAt(i);
                total += item.Value.ToString() + " " + item.Key.ToString() + ", ";
            };
            return total;
        }

        public int TotalHungerUsage()
        {
            int total = 0;
            foreach(Crewmember C in Crew) {
                total += C.HungerUsage;
            }
            return total;
        }

        public int TotalHappinessUsage()
        {
            int total = 0;
            foreach (Crewmember C in Crew) {
                total += C.HappinessUsage;
            }
            return total;
        }

        private Ship(int crewAmount)
        {
            Crew = new List<Crewmember>();
            for (int i = 0; i < crewAmount; i++) {
                Crewmember Crewmate = new Crewmember(random);
                Crew.Add(Crewmate);
            };
            CrewAbilitiesDict();
            Console.WriteLine("You have the following crew: " + ShowCrew());
            Console.WriteLine("The combined stats of your crew are as follows: " + CrewAbilitiesString());
            int Hunger = TotalHungerUsage();
            Console.WriteLine("The combined hunger usage of your crew is " + Hunger.ToString());
            int Happiness = TotalHappinessUsage();
            Console.WriteLine("The combined happiness usage of your crew is " + Happiness.ToString());
            Cargo = new Dictionary<Cargo, int> { { new MountainHoliday(), 100 }, { new Peugeot208(), 2 }, { new AMSPortfolio(), 10 } };
            Food = 100;
            Fun = 100;
            Money = 0;
            Destination = "";
        }
    }

}


