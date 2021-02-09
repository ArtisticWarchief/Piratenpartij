using System;
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
        Crewmate Crewmate1 = new Crewmate();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenName_Click(object sender, EventArgs e)
        {
            lblName.Text = new Crewmate().Name;
        }
    }
}
