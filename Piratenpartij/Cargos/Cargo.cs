﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Cargos
{
    public abstract class Cargo
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int LimitOnShip { get; set; }

        public Cargo()
        {
           
        }
    }
}
