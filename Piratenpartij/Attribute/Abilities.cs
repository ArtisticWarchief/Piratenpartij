using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Abilities
{
    public class Abilities
    {
        public int maxAbilityIndex { get; private set; }
        public int PrimaryAbility { get; private set; }

        Dictionary<int, int> AbilityDict = new Dictionary<int, int>();

        public Abilities(Random r)
        {
            maxAbilityIndex = 2;
            PrimaryAbility = r.Next(maxAbilityIndex);
            AbilityDict.Add(PrimaryAbility, r.Next(75, 100));

            for (int i = 0; i <= maxAbilityIndex; i++)
            {
                if (i != PrimaryAbility)
                {
                    AbilityDict.Add(i, r.Next(15, 74));
                }
            }
        }

        public Dictionary<int, int> GetAbilities()
        {
            return AbilityDict;
        }

        public void PrintAbilities()
        {
            for (int i = 0; i <= maxAbilityIndex; i++)
            {
                Console.WriteLine("{0}: {1}", (AbilityNames)i, AbilityDict[i]);
            }
        }

        public override string ToString()
        {
            string tmp = "";
            for (int i = 0; i <= maxAbilityIndex; i++) {
                tmp += (AbilityNames)i + ": " + AbilityDict[i] + " ";
            }
            return tmp;
        }
    }
}
