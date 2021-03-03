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
                ShipInstance = new Ship();
                return ShipInstance;
            }
        }
        public void ShipReset()
        {
            Crew = new List<Crewmember>();
            CrewAbilitiesUpdate();
            int Hunger = TotalHungerUsage();
            int Happiness = TotalHappinessUsage();
            Cargo = new Dictionary<Cargo, int> { { new MountainHoliday(), random.Next(0,500) }, { new Peugeot208(), random.Next(0, 500) }, { new AMSPortfolio(), random.Next(0, 500) } };
            Food = 100;
            Fun = 100;
            Money = 0;
            Destination = "";
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

        public void CrewAbilitiesUpdate()
        {
            CrewAbilities[(AbilityNames)0] = 0;
            CrewAbilities[(AbilityNames)1] = 0;
            CrewAbilities[(AbilityNames)2] = 0;

            foreach (Crewmember Crewmate in Crew) {
                CrewAbilities[(AbilityNames)0] += Crewmate.Ability.GetAbilities()[0];
                CrewAbilities[(AbilityNames)1] += Crewmate.Ability.GetAbilities()[1];
                CrewAbilities[(AbilityNames)2] += Crewmate.Ability.GetAbilities()[2];
            }
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

        private Ship()
        {
            Crew = new List<Crewmember>();
            CrewAbilitiesUpdate();
            Console.WriteLine("You have the following crew: " + ShowCrew());
            Console.WriteLine("The combined stats of your crew are as follows: " + CrewAbilitiesString());
            int Hunger = TotalHungerUsage();
            Console.WriteLine("The combined hunger usage of your crew is " + Hunger.ToString());
            int Happiness = TotalHappinessUsage();
            Console.WriteLine("The combined happiness usage of your crew is " + Happiness.ToString());
            Cargo = new Dictionary<Cargo, int> { { new MountainHoliday(), random.Next(0, 500) }, { new Peugeot208(), random.Next(0, 500) }, { new AMSPortfolio(), random.Next(0, 500) } };
            Food = 100;
            Fun = 100;
            Money = 0;
            Destination = "";
        }
    }

}


