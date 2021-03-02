using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crewmembers;
using Piratenpartij.Harbors;
using Piratenpartij.Cargos;


namespace Piratenpartij
{
    public partial class HarborCargoUI : Form
    {
        private Harbor harbor;
      
        public HarborCargoUI(Harbor harbor)
        {
            InitializeComponent();
            this.harbor = harbor;
            LblHarborInfo.Text = ("Welcome to " + harbor.Name);
        }

        private void BtnBuyCargo_Click(object sender, EventArgs e)
        {
            ClearListBox();
            listBox1.DataSource = harbor.CargoInStock.Keys;
            BtnBuyFood.Visible = false;
            BtnSelectedDestination.Visible = false;
            BtnBuySelectedCrew.Visible = false;
            BtnBuySelectedCargo.Visible = true;
        }

        private void BtnBuyFood_Click(object sender, EventArgs e)
        {
            ClearListBox();
            BtnBuySelectedCrew.Visible = false;
            BtnBuySelectedCargo.Visible = false;
            BtnBuyFood.Visible = true;
            BtnSelectedDestination.Visible = false;
        }

        private void ClearListBox()
        {
            listBox1.Items.Clear();
            listBox1.DataSource = null;
        }

        private void BtnSellCargo_Click(object sender, EventArgs e)
        {
            ClearListBox();
            BtnBuySelectedCrew.Visible = false;
            BtnBuySelectedCargo.Visible = true;
            BtnBuyFood.Visible = false;
            BtnSelectedDestination.Visible = false;
            listBox1.DataSource = harbor.PlayerShip.Cargo.Keys;
        }

        private void BtnBuyCrew_Click(object sender, EventArgs e)
        {
            ClearListBox();
            BtnBuySelectedCrew.Visible = true;
            BtnBuySelectedCargo.Visible = false;
            BtnSelectedDestination.Visible = false;
            BtnBuyFood.Visible = false;

            listBox1.DataSource = harbor.Crewmembers;
        }

        private void BtnBuySelectedCargo_Click(object sender, EventArgs e)
        {
            harbor.BuyCargo((Cargo)listBox1.SelectedItem,1);
        }

        private void BtnSelectedDestination_Click(object sender, EventArgs e)
        {
            BtnBuySelectedCrew.Visible = false; ;
            BtnBuySelectedCargo.Visible = false;
            BtnBuyFood.Visible = false;
            BtnSelectedDestination.Visible = true;

        }

        private void BtnBuySelectedCrew_Click(object sender, EventArgs e)
        {
            harbor.BuyCrewmember((Crewmember)listBox1.SelectedItem);
          
        }
    }
}
