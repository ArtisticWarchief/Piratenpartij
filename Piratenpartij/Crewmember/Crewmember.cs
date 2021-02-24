using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piratenpartij.Abilities;

namespace Crewmembers
{
    public class Crewmember
    {
        private string[] groupNames = {"Patrice", "Douwe", "Ilona", "Isabel", "Shani", "Sam", "Jordi", "Eyse", "Ivanildo", "Jan", "Omar", "Stan"};
        public string Name { get; set; }
        public int HungerUsage { get; set; }
        public int HappienessUsage { get; set; }
        public int Cost { get; set; }
        public Abilities Ability { get; set; }

        readonly Random random = new Random();

        public Crewmember()
        {
            Name = groupNames[random.Next(0, 11)];
            HungerUsage = random.Next(5, 20);
            HappienessUsage = random.Next(5, 20);
            Cost = random.Next(10,1000);
            Ability = new Abilities();
        }

        public override string ToString()
        {
            return Name + " " + Ability.ToString() + "G " + Cost.ToString();
        }

    }
}
