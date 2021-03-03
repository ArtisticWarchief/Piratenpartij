using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Crewmembers;
using Piratenpartij.Cargos;
using Piratenpartij.Harbors;

namespace Piratenpartij
{
    public partial class HarborScreen : Form
    {
        private Harbor harbor;
        private List<Crewmember> newCrewMembers = new List<Crewmember>();
        private Random random = new Random();
        public HarborScreen()
        {
            InitializeComponent();

            lvHirableCrewmates.View = View.Details;
            lvHirableCrewmates.FullRowSelect = true;
            lvHirableCrewmates.GridLines = true;

            lvShipCrew.FullRowSelect = true;
            lvShipCrew.GridLines = true;

            UpdateShipCrew();

            
        }

        public void ReloadHarbor(Harbor harbor)
        {
            this.harbor = harbor;
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            InitializeUpDowns();
            SetSelingTotal();
            SetBuyTotal();
            RefreshMoneyzzz();
            ShipAmount();
            HarborAmount();
        }

        private void RefreshMoneyzzz()
        {
            TotalMoney.Text = "Money: " + harbor.PlayerShip.Money.ToString() + " Gold";
        }

        private void SellingReset()
        {
            PeugotSellUpDown.Value = 0;
            MountainSellUpDown.Value = 0;
            PortofolioSellUpDown.Value = 0;

            TotalSellPriceAmount.Text = "0 Gold";

        }

        private void BuyingReset()
        {
            PeugotBuyUpDown.Value = 0;
            HolidayBuyUpDown.Value = 0;
            PortofolioBuyUpDown.Value = 0;

            TotalBuyPriceAmount.Text = "0 Gold";
        }

        private void ShipAmount()
        {
            ShipFoodAmount.Text = harbor.PlayerShip.Food.ToString();
            ShipMoutainAmount.Text = harbor.PlayerShip.Cargo[harbor.PlayerShip.Cargo.Keys.FirstOrDefault(c => c.GetType() == typeof(MountainHoliday))].ToString();
            ShipPeugotAmount.Text = harbor.PlayerShip.Cargo[harbor.PlayerShip.Cargo.Keys.FirstOrDefault(c => c.GetType() == typeof(Peugeot208))].ToString();
            ShipPortofolioAmount.Text = harbor.PlayerShip.Cargo[harbor.PlayerShip.Cargo.Keys.FirstOrDefault(c => c.GetType() == typeof(AMSPortfolio))].ToString();
        }

        private void HarborAmount()
        {
            HarborFoodAmount.Text = harbor.FoodAmount.ToString();
            HarborMountianAmount.Text = harbor.CargoInStock[harbor.PlayerShip.Cargo.Keys.FirstOrDefault(c => c.GetType() == typeof(MountainHoliday))].amount.ToString();
            HarborPeugotAmount.Text = harbor.CargoInStock[harbor.PlayerShip.Cargo.Keys.FirstOrDefault(c => c.GetType() == typeof(Peugeot208))].amount.ToString();
            HarborPortofolioAmount.Text = harbor.CargoInStock[harbor.PlayerShip.Cargo.Keys.FirstOrDefault(c => c.GetType() == typeof(AMSPortfolio))].amount.ToString();
        }

        private void InitializeUpDowns()
        {
            //BUYUPDOWNS
            foreach (KeyValuePair<Cargos.Cargo, HarborCargoItem> kvp in harbor.CargoInStock) {
                switch (kvp.Key.cargoType) {
                    case CargoTypes.Peugeot208:
                        PeugotBuyUpDown.Maximum = kvp.Value.amount;
                        BuyPricePeugot208.Text = kvp.Value.buyPrice.ToString() + " Gold";
                        PeugotSellPrice.Text = kvp.Value.sellPrice.ToString() + " Gold";
                        break;
                    case CargoTypes.Mountain:
                        HolidayBuyUpDown.Maximum = kvp.Value.amount;
                        BuyPriceMountain.Text = kvp.Value.buyPrice.ToString() + " Gold";
                        SellPriceHolidays.Text = kvp.Value.sellPrice.ToString() + " Gold";
                        break;
                    case CargoTypes.Portofolio:
                        PortofolioBuyUpDown.Maximum = kvp.Value.amount;
                        BuyPricePortofolio.Text = kvp.Value.buyPrice.ToString() + " Gold";
                        SellPricePortofolio.Text = kvp.Value.sellPrice.ToString() + " Gold";
                        break;
                    default:
                        break;
                }
            }

            FoodBuyUpDown.Maximum = harbor.FoodAmount;
            BuyPriceFood.Text = harbor.FoodPrice.ToString() + " Gold";

            

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
                        sellingTotal += (int)PeugotSellUpDown.Value * kvp.Value.sellPrice;
                        break;
                    case CargoTypes.Mountain:
                        sellingTotal += (int)MountainSellUpDown.Value * kvp.Value.sellPrice;
                        break;
                    case CargoTypes.Portofolio:
                        sellingTotal += (int)PortofolioSellUpDown.Value * kvp.Value.sellPrice;
                        break;
                    default:
                        break;
                }
            }
            TotalSellPriceAmount.Text = sellingTotal.ToString() + " Gold";
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

            TotalBuyPriceAmount.Text = buyingTotal.ToString() + " Gold";

            return buyingTotal;
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            harbor.SellCargo(harbor.PlayerShip.Cargo.Keys.FirstOrDefault(c => c.GetType() == typeof(AMSPortfolio)), (int)PortofolioSellUpDown.Value);
            harbor.SellCargo(harbor.PlayerShip.Cargo.Keys.FirstOrDefault(c => c.GetType() == typeof(MountainHoliday)), (int)MountainSellUpDown.Value);
            harbor.SellCargo(harbor.PlayerShip.Cargo.Keys.FirstOrDefault(c => c.GetType() == typeof(Peugeot208)), (int)PeugotSellUpDown.Value);

            UpdateScreen();
            SellingReset();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if(harbor.PlayerShip.Money - SetBuyTotal() >= 0) {
                harbor.BuyCargo(harbor.PlayerShip.Cargo.Keys.FirstOrDefault(c => c.GetType() == typeof(AMSPortfolio)), (int)PortofolioBuyUpDown.Value);
                harbor.BuyCargo(harbor.PlayerShip.Cargo.Keys.FirstOrDefault(c => c.GetType() == typeof(MountainHoliday)), (int)HolidayBuyUpDown.Value);
                harbor.BuyCargo(harbor.PlayerShip.Cargo.Keys.FirstOrDefault(c => c.GetType() == typeof(Peugeot208)), (int)PeugotBuyUpDown.Value);
                harbor.BuyFood((int)FoodBuyUpDown.Value);
            }

            UpdateScreen();
            BuyingReset();
        }

        public void SetNewHirableCrew()
        {
            lvHirableCrewmates.Clear();
            newCrewMembers.Clear();

            lvHirableCrewmates.Columns.Add("Name", -2, HorizontalAlignment.Center);
            foreach (var ability in Enum.GetValues(typeof(Abilities.AbilityNames))) {
                lvHirableCrewmates.Columns.Add(ability.ToString(), -2, HorizontalAlignment.Center);
            }
            lvHirableCrewmates.Columns.Add("Hunger", -2, HorizontalAlignment.Center);
            lvHirableCrewmates.Columns.Add("Price", -2, HorizontalAlignment.Center);

            for (int i = 0; i < 3; i++) {
                Crewmember crew = new Crewmember(random);

                newCrewMembers.Add(crew);

                ListViewItem placeHolder = new ListViewItem(newCrewMembers[i].Name);
                for (int j = 0; j <= newCrewMembers[i].Ability.maxAbilityIndex; j++) {
                    placeHolder.SubItems.Add(newCrewMembers[i].Ability.GetAbilities()[j].ToString());
                }
                placeHolder.SubItems.Add(newCrewMembers[i].HungerUsage.ToString());
                placeHolder.SubItems.Add(newCrewMembers[i].Cost.ToString());

                lvHirableCrewmates.Items.Add(placeHolder);
            }

            lvHirableCrewmates.Columns[0].Width = -2;
        }

        private void UpdateShipCrew()
        {
            lvShipCrew.Clear();

            lvShipCrew.View = View.Details;
            int totalHunger = 0;

            lvShipCrew.Columns.Add("Name", -2, HorizontalAlignment.Center);
            foreach (var ability in Enum.GetValues(typeof(Abilities.AbilityNames))) {
                lvShipCrew.Columns.Add(ability.ToString(), -2, HorizontalAlignment.Center);
            }
            lvShipCrew.Columns.Add("Hunger", -2, HorizontalAlignment.Center);
            lvShipCrew.Columns.Add("Price", -2, HorizontalAlignment.Center);

            foreach (var crew in Ships.Ship.GetInstance().Crew) {
                ListViewItem placeHolder = new ListViewItem(crew.Name);
                for (int j = 0; j <= crew.Ability.maxAbilityIndex; j++) {
                    placeHolder.SubItems.Add(crew.Ability.GetAbilities()[j].ToString());
                }
                placeHolder.SubItems.Add(crew.HungerUsage.ToString());
                totalHunger += crew.HungerUsage;
                placeHolder.SubItems.Add(crew.Cost.ToString());

                lvShipCrew.Items.Add(placeHolder);
            }

            Ships.Ship.GetInstance().CrewAbilitiesUpdate();

            ListViewItem totalAbilities = new ListViewItem("Total");
            foreach (Abilities.AbilityNames abilityNames in Enum.GetValues(typeof(Abilities.AbilityNames))) {
                totalAbilities.SubItems.Add(Ships.Ship.GetInstance().CrewAbilities[abilityNames].ToString());
            }
            totalAbilities.SubItems.Add(totalHunger.ToString());
            lvShipCrew.Items.Add(totalAbilities);

            lvShipCrew.Columns[0].Width = -2;
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            if (lvHirableCrewmates.SelectedItems == null || lvHirableCrewmates.SelectedItems.Count > 1) {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                System.Windows.Forms.MessageBox.Show("Please choose one crewmember to hire.", "Too many crewmembers", buttons, MessageBoxIcon.Warning);
                return;
            }
            ListView.SelectedIndexCollection chosenMemberIndex = lvHirableCrewmates.SelectedIndices;

            foreach (var index in chosenMemberIndex) {
                if (harbor.PlayerShip.Money - newCrewMembers[(int)index].Cost >= 0) {
                    harbor.PlayerShip.Crew.Add(newCrewMembers[(int)index]);
                    lvHirableCrewmates.Items.RemoveAt((int)index);
                    
                    harbor.PlayerShip.Money -= newCrewMembers[(int)index].Cost;
                    newCrewMembers.RemoveAt((int)index);
                    UpdateShipCrew();
                } else {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    System.Windows.Forms.MessageBox.Show("You don't have enough money to buy this.", "Not Enough Money", buttons, MessageBoxIcon.Error);

                }

            }

            UpdateScreen();
        }

        private void SetSellingTotalChange_ValueChanged(object sender, EventArgs e)
        {
            SetSelingTotal();
        }
        
        private void SetBuyingTotalChange_ValueChanged(object sender, EventArgs e)
        {
            SetBuyTotal();
        }

    }
}
