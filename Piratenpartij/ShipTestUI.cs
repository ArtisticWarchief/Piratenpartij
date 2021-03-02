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
    public partial class ShipTestUI : Form
    {
        private Ship ship;

        public ShipTestUI()
        {
            InitializeComponent();
            ship = Ship.GetInstance();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            string whichButton = ((Button)sender).Name;
            int cargoValue = 100;
            int newValue;
            switch (whichButton) {
                case "plusTop":
                    Console.WriteLine("plusTop");
                    newValue = int.Parse(totalCargoTop.Text) + 1;
                    if (newValue <= int.Parse(shipAmountCargoTopAmount.Text)) {
                        totalCargoTop.Text = newValue.ToString();
                    }
                    break;
                case "plusMiddle":
                    Console.WriteLine("plusMiddle");
                    newValue = int.Parse(totalCargoMiddle.Text) + 1;
                    if (newValue <= int.Parse(shipAmountCargoMiddleAmount.Text)) {
                        totalCargoMiddle.Text = newValue.ToString();
                    }
                    break;
                case "plusBottom":
                    Console.WriteLine("plusBottom");
                    newValue = int.Parse(totalCargoBottom.Text) + 1;
                    totalCargoBottom.Text = newValue.ToString();
                    if (newValue <= int.Parse(shipAmountCargoBottomAmount.Text)) {
                        totalCargoMiddle.Text = newValue.ToString();
                    }
                    break;
                case "plusDoubleTop":
                    Console.WriteLine("plusDoubleTop");
                    newValue = int.Parse(totalCargoTop.Text) + 10;
                    if (newValue <= int.Parse(shipAmountCargoTopAmount.Text)) {
                        totalCargoTop.Text = newValue.ToString();
                    }
                    break;
                case "plusDoubleMiddle":
                    Console.WriteLine("plusDoubleMiddle");
                    newValue = int.Parse(totalCargoMiddle.Text) + 10;
                    if (newValue <= int.Parse(shipAmountCargoMiddleAmount.Text)) {
                        totalCargoMiddle.Text = newValue.ToString();
                    }
                    break;
                case "plusDoubleBottom":
                    Console.WriteLine("plusDoubleBottom");
                    newValue = int.Parse(totalCargoBottom.Text) + 10;
                    if (newValue <= int.Parse(shipAmountCargoBottomAmount.Text)) {
                        totalCargoBottom.Text = newValue.ToString();
                    }
                    break;
                default:
                    Console.WriteLine("No idea which button called plus_Click");
                    break;
            }
            int newTotalValue = (int.Parse(totalCargoTop.Text) + int.Parse(totalCargoMiddle.Text) + int.Parse(totalCargoBottom.Text)) * cargoValue;
            totalValueSale.Text = newTotalValue.ToString();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            string whichButton = ((Button)sender).Name;
            int newValue1;
            int cargoValue1 = 100;
            switch (whichButton) {
                case "minusTop":
                    Console.WriteLine("minusTop");
                    newValue1 = int.Parse(totalCargoTop.Text) - 1;
                    if (newValue1 > -1) {
                        totalCargoTop.Text = newValue1.ToString();
                    }
                    break;
                case "minusMiddle":
                    newValue1 = int.Parse(totalCargoMiddle.Text) - 1;
                    if (newValue1 > -1) {
                        totalCargoMiddle.Text = newValue1.ToString();
                    }
                    Console.WriteLine("minusMiddle");
                    break;
                case "minusBottom":
                    newValue1 = int.Parse(totalCargoBottom.Text) - 1;
                    if (newValue1 > -1) {
                        totalCargoBottom.Text = newValue1.ToString();
                    }
                    Console.WriteLine("minusBottom");
                    break;
                case "minusDoubleTop":
                    newValue1 = int.Parse(totalCargoTop.Text) - 10;
                    if (newValue1 > -1) {
                        totalCargoTop.Text = newValue1.ToString();
                    }
                    else {
                        totalCargoTop.Text = "0";
                    }
                    Console.WriteLine("minusDoubleTop");
                    break;
                case "minusDoubleMiddle":
                    newValue1 = int.Parse(totalCargoMiddle.Text) - 10;
                    if (newValue1 > -1) {
                        totalCargoMiddle.Text = newValue1.ToString();
                    }
                    else {
                        totalCargoMiddle.Text = "0";
                    }
                    Console.WriteLine("minusDoubleMiddle");
                    break;
                case "minusDoubleBottom":
                    newValue1 = int.Parse(totalCargoBottom.Text) - 10;
                    if (newValue1 > -1) {
                        totalCargoBottom.Text = newValue1.ToString();
                    }
                    else {
                        totalCargoBottom.Text = "0";
                    }
                    Console.WriteLine("minusDoubleBottom");
                    break;
                default:
                    Console.WriteLine("No idea which button called minus_Click");
                    break;
            }
            int newTotalValue1 = (int.Parse(totalCargoTop.Text) + int.Parse(totalCargoMiddle.Text) + int.Parse(totalCargoBottom.Text)) * cargoValue1;
            totalValueSale.Text = newTotalValue1.ToString();

        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            cargoTypeTop.Text = ship.Cargo.ElementAt(0).Key.ToString().Replace("Piratenpartij.Cargos.","");
            cargoTypeMiddle.Text = ship.Cargo.ElementAt(1).Key.ToString().Replace("Piratenpartij.Cargos.", "");
            cargoTypeBottom.Text = ship.Cargo.ElementAt(2).Key.ToString().Replace("Piratenpartij.Cargos.", "");
            shipAmountCargoTopAmount.Text = ship.Cargo.ElementAt(0).Value.ToString();
            shipAmountCargoMiddleAmount.Text = ship.Cargo.ElementAt(1).Value.ToString();
            shipAmountCargoBottomAmount.Text = ship.Cargo.ElementAt(2).Value.ToString();
        }

        private void SellCargo_Click(object sender, EventArgs e)
        {
            string afterSale = "You have sold: " + totalCargoTop.Text + " " + cargoTypeTop.Text + ", " + totalCargoMiddle.Text + " " + cargoTypeMiddle.Text + ", " + totalCargoBottom.Text + " " + cargoTypeBottom.Text + ". For a total of " + totalValueSale.Text + ".";
            Console.WriteLine(afterSale);
            shipAmountCargoTopAmount.Text = (int.Parse(shipAmountCargoTopAmount.Text) - int.Parse(totalCargoTop.Text)).ToString();
            shipAmountCargoMiddleAmount.Text = (int.Parse(shipAmountCargoMiddleAmount.Text) - int.Parse(totalCargoMiddle.Text)).ToString();
            shipAmountCargoBottomAmount.Text = (int.Parse(shipAmountCargoBottomAmount.Text) - int.Parse(totalCargoBottom.Text)).ToString();

            totalCargoTop.Text = "0";
            totalCargoMiddle.Text = "0";
            totalCargoBottom.Text = "0";
            totalValueSale.Text = "0";
            afterSaleMessage.Text = afterSale;

        }
    }
}
