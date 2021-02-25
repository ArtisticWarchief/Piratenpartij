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
    public partial class UserControl1 : Form
    {
        private Ship ship;

        public UserControl1()
        {
            InitializeComponent();
            ship = Ship.GetInstance();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            String whichButton = ((Button)sender).Name;
            switch (whichButton) {
                case "plusTop":
                    Console.WriteLine("plusTop");
                    int newValue = int.Parse(totalCargoTop.Text) + 1;
                    totalCargoTop.Text = newValue.ToString();
                    break;
                case "plusMiddle":
                    Console.WriteLine("plusMiddle");
                    int newValue = int.Parse(totalCargoMiddle.Text) + 1;
                    totalCargoTop.Text = newValue.ToString();
                    break;
                case "plusBottom":
                    Console.WriteLine("plusBottom");
                    int newValue = int.Parse(totalCargoBottom.Text) + 1;
                    totalCargoTop.Text = newValue.ToString();
                    break;
                case "plusDoubleTop":
                    Console.WriteLine("plusDoubleTop");
                    int newValue = int.Parse(totalCargoMiddle.Text) + 10;
                    totalCargoTop.Text = newValue.ToString();
                    break;
                case "plusDoubleMiddle":
                    Console.WriteLine("plusDoubleMiddle");
                    int newValue = int.Parse(totalCargoBottom.Text) + 10;
                    totalCargoTop.Text = newValue.ToString();
                    break;
                case "plusDoubleBottom":
                    Console.WriteLine("plusDoubleBottom");
                    int newValue = int.Parse(totalCargoTop.Text) = 10;
                    totalCargoTop.Text = newValue.ToString();
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            String whichButton = ((Button)sender).Name;
            switch (whichButton) {
                case "minusTop":
                    Console.WriteLine("minusTop");
                    int newValue = int.Parse(totalCargoTop.Text) - 1;
                    totalCargoTop.Text = newValue.ToString();
                    break;
                case "minusMiddle":
                    int newValue = int.Parse(totalCargoMiddle.Text) - 1;
                    totalCargoTop.Text = newValue.ToString();
                    Console.WriteLine("minusMiddle");
                    break;
                case "minusBottom":
                    int newValue = int.Parse(totalCargoBottom.Text) - 1;
                    totalCargoTop.Text = newValue.ToString();
                    Console.WriteLine("minusBottom");
                    break;
                case "minusDoubleTop":
                    int newValue = int.Parse(totalCargoTop.Text) - 10;
                    totalCargoTop.Text = newValue.ToString();
                    Console.WriteLine("minusDoubleTop");
                    break;
                case "minusDoubleMiddle":
                    int newValue = int.Parse(totalCargoMiddle.Text) - 10;
                    totalCargoTop.Text = newValue.ToString();
                    Console.WriteLine("minusDoubleMiddle");
                    break;
                case "minusDoubleBottom":
                    int newValue = int.Parse(totalCargoBottom.Text) - 10;
                    totalCargoTop.Text = newValue.ToString();
                    Console.WriteLine("minusDoubleBottom");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }
        }


        private void minusTop_Click(object sender, EventArgs e)
        {

        }
        private void minusMiddle_Click(object sender, EventArgs e)
        {

        }

        private void minusBottom_Click(object sender, EventArgs e)
        {

        }

        private void minusDoubleTop_Click(object sender, EventArgs e)
        {

        }

        private void minusDoubleMiddle_Click(object sender, EventArgs e)
        {

        }

        private void minusDoubleBottom_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void cargoTypeTop_TextChanged(object sender, EventArgs e)
        {

        }

        private void sellCargo_Click(object sender, EventArgs e)
        {

        }

    }
}
