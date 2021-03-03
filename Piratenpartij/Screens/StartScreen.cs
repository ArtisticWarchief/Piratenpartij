﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Piratenpartij.Ships;
using Crewmembers;

namespace Piratenpartij.Screens
{
    public partial class StartScreen : Form
    {
        private Ship ship;
        private Random random = new Random();
        private List<Crewmember> newCrewMembers = new List<Crewmember>();
        public StartScreen()
        {
            InitializeComponent();
            ship = Ship.GetInstance();
            lvHirableCrewmates.View = View.Details;
            lvHirableCrewmates.FullRowSelect = true;
            lvHirableCrewmates.GridLines = true;

            lvHirableCrewmates.Columns.Add("Name", -2, HorizontalAlignment.Center);
            foreach (var ability in Enum.GetValues(typeof(Abilities.AbilityNames))) {
                lvHirableCrewmates.Columns.Add(ability.ToString(), -2, HorizontalAlignment.Center);
            }


            lvShipCrew.FullRowSelect = true;
            lvShipCrew.GridLines = true;

            for (int i = 0; i < 8; i++) {
                Crewmember crew = new Crewmember(random);

                newCrewMembers.Add(crew);

                ListViewItem placeHolder = new ListViewItem(newCrewMembers[i].Name);
                for (int j = 0; j <= newCrewMembers[i].Ability.maxAbilityIndex; j++) {
                    placeHolder.SubItems.Add(newCrewMembers[i].Ability.GetAbilities()[j].ToString());
                }

                lvHirableCrewmates.Items.Add(placeHolder);
            }
            UpdateShipCrew();
        }
        private void UpdateShipCrew()
        {
            lvShipCrew.Clear();

            lvShipCrew.View = View.Details;

            lvShipCrew.Columns.Add("Name", -2, HorizontalAlignment.Center);
            foreach (var ability in Enum.GetValues(typeof(Abilities.AbilityNames))) {
                lvShipCrew.Columns.Add(ability.ToString(), -2, HorizontalAlignment.Center);
            }

            foreach (var crew in Ship.GetInstance().Crew) {
                ListViewItem placeHolder = new ListViewItem(crew.Name);
                for (int j = 0; j <= crew.Ability.maxAbilityIndex; j++) {
                    placeHolder.SubItems.Add(crew.Ability.GetAbilities()[j].ToString());
                }

                lvShipCrew.Items.Add(placeHolder);
            }
            Ship.GetInstance().CrewAbilitiesUpdate();
            ListViewItem totalAbilities = new ListViewItem("Total");
            foreach (Abilities.AbilityNames abilityNames in Enum.GetValues(typeof(Abilities.AbilityNames))) {
                totalAbilities.SubItems.Add(Ship.GetInstance().CrewAbilities[abilityNames].ToString());
            }
            lvShipCrew.Items.Add(totalAbilities);

            lvShipCrew.Columns[0].Width = -2;
        }

        private void btnHire_Click(object sender, EventArgs e)
        {

            if (Ship.GetInstance().Crew.Count == 5) {
                return;
            }

            if (lvHirableCrewmates.SelectedItems == null || lvHirableCrewmates.SelectedItems.Count > 1) {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                System.Windows.Forms.MessageBox.Show("Please choose one crewmember to hire.", "Too many crewmembers", buttons, MessageBoxIcon.Warning);
                return;
            }
            ListView.SelectedIndexCollection chosenMemberIndex = lvHirableCrewmates.SelectedIndices;

            foreach (var index in chosenMemberIndex) {
                Ship.GetInstance().Crew.Add(newCrewMembers[(int)index]);
                lvHirableCrewmates.Items.RemoveAt((int)index);
                newCrewMembers.RemoveAt((int)index);
            }
            UpdateShipCrew();
            UpdateScreen();


        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            UpdateScreen();

        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (Ship.GetInstance().Crew.Count > 0) {
                this.Hide();
                new MainScreen().Show();
            } else {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                System.Windows.Forms.MessageBox.Show("Please choose at least one crewmember to hire. Before starting the game.", "Not enough crewmembers", buttons, MessageBoxIcon.Warning);
                return;
            }
            
        }

        private void UpdateScreen()
        {
            UpdateAllCargos(ship.Cargo);
            ChangeMoneyAmountText(ship.Money);
            ChangeCrewMemberAmountText(ship.Crew.Count);
            ChangeHappinessText(ship.Fun);
        }

        public void UpdateAllCargos(Dictionary<Cargos.Cargo, int> cargos)
        {
            foreach (KeyValuePair<Cargos.Cargo, int> item in cargos) {
                if (item.Key.GetType() == typeof(Cargos.Peugeot208)) CargoPeugotAmountText.Text = item.Value.ToString();
                else if (item.Key.GetType() == typeof(Cargos.MountainHoliday)) CargoMountainAmountText.Text = item.Value.ToString();
                else if (item.Key.GetType() == typeof(Cargos.AMSPortfolio)) CargoPortofolioAmountText.Text = item.Value.ToString();
            }
        }

        private void ChangeCrewMemberAmountText(int amount) => CrewMemberAmountText.Text = amount.ToString();
        private void ChangeMoneyAmountText(int amount) => MoneyAmountText.Text = amount.ToString();
        private void ChangeHappinessText(int amount) => HappinessAmountText.Text = amount.ToString();
    }
}
