using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Piratenpartij.Ships;

namespace Piratenpartij
{
    public partial class ShipMakeUI : Form
    {
        private Ship ship;
        public ShipMakeUI()
        {
            InitializeComponent();
            ship = Ship.GetInstance();
        }

        private void shipContent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
