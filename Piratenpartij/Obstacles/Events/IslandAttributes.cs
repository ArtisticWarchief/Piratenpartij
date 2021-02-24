using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Obstacles
{
    public class IslandAttributes
    {

        private string[] options = { "good", "bad" };
        private string[] goodOptions = { "gold", "cargo"};
        private string[] badOptions = { "disease", "lion attack", "earthquake" };

        public string option { get; set; }


        readonly Random random = new Random();

        public string GenerateAttributes()
        {
            return option = options[random.Next(0, 1)];
        }
    }
}
