using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij
{
    public class Ship
    {
        public List<string> Crewmembers { get; set; }
        public List<string> Cargo { get; set; }
        public string Destination { get; set; }
        public int Food { get; set; }
        public int Fun { get; set; }
        public string Status { get; set; }
        public int Money { get; set; }

        public Ship(int crewAmount)
        {
            //Crewmembers = new List<string>();
            for (int i = 0; i < crewAmount; i++) {
                Crewmembers.Add(new Crewmember());
            }
            Cargo = new Cargo();
            Destination = "";
            Food = 100;
            Fun = 100;
            Status = "Start";
            Money = 0;
        }
    }   
}
