﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piratenpartij
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenName_Click(object sender, EventArgs e)
        {
            Crewmember.Crewmember crew1 = new Crewmember.Crewmember();
            crew1.Ability.PrintAbilities();
            Console.WriteLine("Cost: {0}", crew1.Cost);
            Console.WriteLine("Name: {0}", crew1.Name);
        }
    }
}
