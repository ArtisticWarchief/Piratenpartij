﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij
{
    class Crewmate
    {
        private string[] groupNames = {"Patrice", "Douwe", "Ilona", "Isabel", "Shani", "Sam", "Jordi", "Eyse", "Ivanildo", "Jan", "Omar", "Stan"};
        public string Name { get; set; }
        public int Cost { get; set; }
        //List<Attribute> Attributes = new List<Attribute>();
        public Attribute Attribute { get; set; }

        readonly Random random = new Random();

        public Crewmate()
        {
            Name = groupNames[random.Next(0, 11)];
            Cost = random.Next(1000);
            Attribute = new Attribute();
        }


    }
}
