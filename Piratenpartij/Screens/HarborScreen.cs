using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Piratenpartij.Harbors;

namespace Piratenpartij
{
    public partial class HarborScreen : Form
    {
        private Harbor harbor;
        public HarborScreen(Harbor harbor)
        {
            this.harbor = harbor;

            InitializeComponent();
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            InitializeUpDowns();
            SetSelingTotal();
            SetBuyTotal();
        }

        private void InitializeUpDowns()
        {
            //BUYUPDOWNS
            foreach (KeyValuePair<Cargos.Cargo, HarborCargoItem> kvp in harbor.CargoInStock) {
                switch (kvp.Key.cargoType) {
                    case CargoTypes.Peugeot208:
                        PeugotBuyUpDown.Maximum = kvp.Value.amount;
                        BuyPricePeugot208.Text = kvp.Value.buyPrice.ToString();
                        PeugotSellPrice.Text = kvp.Value.sellPrice.ToString();
                        break;
                    case CargoTypes.Mountain:
                        HolidayBuyUpDown.Maximum = kvp.Value.amount;
                        BuyPriceMountain.Text = kvp.Value.buyPrice.ToString();
                        SellPriceHolidays.Text = kvp.Value.sellPrice.ToString();
                        break;
                    case CargoTypes.Portofolio:
                        PortofolioBuyUpDown.Maximum = kvp.Value.amount;
                        BuyPricePortofolio.Text = kvp.Value.buyPrice.ToString();
                        PeugotSellPrice.Text = kvp.Value.sellPrice.ToString();
                        break;
                    default:
                        break;
                }
            }

            FoodBuyUpDown.Maximum = harbor.FoodAmount;

            //SELLUPDOWNS
            foreach (KeyValuePair<Cargos.Cargo, int> kvp in Ships.Ship.GetInstance().Cargo) {
                switch (kvp.Key.cargoType) {
                    case CargoTypes.Peugeot208:
                        PeugotSellUpDown.Maximum = kvp.Value;
                        break;
                    case CargoTypes.Mountain:
                        MountainSellUpDown.Maximum = kvp.Value;
                        break;
                    case CargoTypes.Portofolio:
                        PortofolioSellUpDown.Maximum = kvp.Value;
                        break;
                    default:
                        break;
                }
            }
        }

        private void SetSelingTotal()
        {
            int sellingTotal = 0;
            foreach (KeyValuePair<Cargos.Cargo, HarborCargoItem> kvp in harbor.CargoInStock) {
                switch (kvp.Key.cargoType) 
                {
                    case CargoTypes.Peugeot208:
                        sellingTotal += (int)PeugotSellUpDown.Value * kvp.Value.buyPrice;
                        break;
                    case CargoTypes.Mountain:
                        sellingTotal += (int)MountainSellUpDown.Value * kvp.Value.buyPrice;
                        break;
                    case CargoTypes.Portofolio:
                        sellingTotal += (int)PortofolioSellUpDown.Value * kvp.Value.buyPrice;
                        break;
                    default:
                        break;
                }
            }
            TotalSellPriceAmount.Text = sellingTotal.ToString();
        }

        private int SetBuyTotal()
        {
            int buyingTotal = 0;
            foreach (KeyValuePair<Cargos.Cargo, HarborCargoItem> kvp in harbor.CargoInStock) {
                switch (kvp.Key.cargoType) {
                    case CargoTypes.Peugeot208:
                        buyingTotal += (int)PeugotBuyUpDown.Value * kvp.Value.buyPrice;
                        break;
                    case CargoTypes.Mountain:
                        buyingTotal += (int)HolidayBuyUpDown.Value * kvp.Value.buyPrice;
                        break;
                    case CargoTypes.Portofolio:
                        buyingTotal += (int)PortofolioBuyUpDown.Value * kvp.Value.buyPrice;
                        break;
                    default:
                        break;
                }
            }
            buyingTotal += (int)FoodBuyUpDown.Value * harbor.FoodPrice;

            TotalBuyPriceAmount.Text = buyingTotal.ToString();

            return buyingTotal;
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            harbor.SellCargo(new Cargos.AMSPortfolio(), (int)PortofolioSellUpDown.Value);
            harbor.SellCargo(new Cargos.MountainHoliday(), (int)MountainSellUpDown.Value);
            harbor.SellCargo(new Cargos.Peugeot208(), (int)PeugotSellUpDown.Value);

            UpdateScreen();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if(harbor.PlayerShip.Money - SetBuyTotal() >= 0) {
                harbor.BuyCargo(new Cargos.AMSPortfolio(), (int)PortofolioBuyUpDown.Value);
                harbor.BuyCargo(new Cargos.MountainHoliday(), (int)HolidayBuyUpDown.Value);
                harbor.BuyCargo(new Cargos.Peugeot208(), (int)PeugotBuyUpDown.Value);
                harbor.BuyFood((int)FoodBuyUpDown.Value);
            }

            UpdateScreen();
        }
    }
}
