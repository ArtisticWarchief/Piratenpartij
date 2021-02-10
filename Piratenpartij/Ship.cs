using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij
{
    public class Ship
    {
        public List<Crewmember> Crewmembers { get; set; }
        public Dictionary<string, int> Cargo { get; set; }
        public string Destination { get; set; }
        public int Food { get; set; }
        public int Fun { get; set; }
        public string Status { get; set; }
        public int Money { get; set; }
        public List<Obstacle> Obstacles { get; set; }

        readonly Random random = new Random();

        public Dictionary<string, int> AtttributesTotal()
        {
            int Intelligence = 0;
            int Strength = 0;
            int Hunger = 0;
            int Trading = 0;

            foreach (Crewmember Crew in Crewmembers) {
                Intelligence += Crew.Attribute.GetAttributes()[0];
                Strength += Crew.Attribute.GetAttributes()[1];
                Hunger += Crew.Attribute.GetAttributes()[2];
                Trading += Crew.Attribute.GetAttributes()[3];
            }

            Dictionary<string, int> CrewAtttributes = new Dictionary<string, int> {
                { "intelligence", Intelligence },
                { "strength", Strength },
                { "hunger", Hunger },
                { "trading", Trading }
            };
            //Console.WriteLine(CrewAtttributes);
            return CrewAtttributes;
        }

        public Ship(int crewAmount)
        {
            for (int i = 0; i < crewAmount; i++) {
                Crewmembers.Add(new Crewmember.Crewmember());
            }

            int obstacleAmount = random.Next(10, 1000);

            for (int i = 0; i < obstacleAmount; i++) {
                Obstacles.Add(new Obstacle.Obstacle());
            }

            Cargo = new Cargo();
            Destination = "";
            Food = 100;
            Fun = 100;
            Status = "Start";
            Money = 0;
            //Console.WriteLine(AtttributesTotal().Count);
        }
    }

}


