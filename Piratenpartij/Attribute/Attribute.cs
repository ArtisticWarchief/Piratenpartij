using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Attribute
{
    public class Attribute
    {
        readonly Random random = new Random();

        int maxAttributeIndex = 3;
        public int PrimaryAttribute { get; private set; }

        Dictionary<int, int> Attributes = new Dictionary<int, int>();

        public Attribute()
        {
            PrimaryAttribute = random.Next(maxAttributeIndex);
            Attributes.Add(PrimaryAttribute, random.Next(75, 100));

            for (int i = 0; i <= maxAttributeIndex; i++)
            {
                if (i != PrimaryAttribute)
                {
                    Attributes.Add(i, random.Next(15, 74));
                }
            }
        }

        public Dictionary<int, int> GetAttributes()
        {
            return Attributes;
        }

        public void PrintAttributes()
        {
            for (int i = 0; i <= maxAttributeIndex; i++)
            {
                Console.WriteLine("{0}: {1}", (AttributeNames)i, Attributes[i]);
            }
        }
    }
}
