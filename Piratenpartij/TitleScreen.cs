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
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.ShowDialog();
            Close();
        }
    }
}
