using Piratenpartij.Harbors;
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
    public partial class HarborTestUI : Form
    {
        private Harbor harbor;
        public HarborTestUI()//Ship ship
        {

            InitializeComponent();
        //    harbor = new Harbor(ship);
        }

        private void BtnBuyCargo_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuyFood_Click(object sender, EventArgs e)
        {

        }

        private void BtnSellCargo_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuyCrewmembers_Click(object sender, EventArgs e)
        {
            new HarborCrewmateUI().Show();
        }

        private void BtnDestination_Click(object sender, EventArgs e)
        {

        }
    }
}
