using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Abilities
{
    public class Abilities
    {
        readonly Random random = new Random();

        int maxAbilityIndex = 3;
        public int PrimaryAbility { get; private set; }

        Dictionary<int, int> AbilityDict = new Dictionary<int, int>();

        public Abilities()
        {
            PrimaryAbility = random.Next(maxAbilityIndex);
            AbilityDict.Add(PrimaryAbility, random.Next(75, 100));

            for (int i = 0; i <= maxAbilityIndex; i++)
            {
                if (i != PrimaryAbility)
                {
                    AbilityDict.Add(i, random.Next(15, 74));
                }
            }
        }

        public Dictionary<int, int> GetAttributes()
        {
            return AbilityDict;
        }

        public void PrintAttributes()
        {
            for (int i = 0; i <= maxAbilityIndex; i++)
            {
                Console.WriteLine("{0}: {1}", (AbilityNames)i, AbilityDict[i]);
            }
        }
    }
}
