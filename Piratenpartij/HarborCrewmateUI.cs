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
using Piratenpartij.Ships;

namespace Piratenpartij
{
    public partial class HarborCrewmateUI : Form
    {
        private List<Crewmember> newCrewMembers = new List<Crewmember>();
        private Random random = new Random();
        public HarborCrewmateUI()
        {
            InitializeComponent();
            lvHirableCrewmates.View = View.Details;
            lvHirableCrewmates.FullRowSelect = true;
            lvHirableCrewmates.GridLines = true;

            lvHirableCrewmates.Columns.Add("Name", -2, HorizontalAlignment.Center);
            foreach (var ability in Enum.GetValues(typeof(Abilities.AbilityNames))) {
                lvHirableCrewmates.Columns.Add(ability.ToString(), -2, HorizontalAlignment.Center);
            }
            lvHirableCrewmates.Columns.Add("Hunger", -2, HorizontalAlignment.Center);
            lvHirableCrewmates.Columns.Add("Price", -2, HorizontalAlignment.Center);

            
            lvShipCrew.FullRowSelect = true;
            lvShipCrew.GridLines = true;

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

            updateShipCrew();
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            if (lvHirableCrewmates.SelectedItems == null || lvHirableCrewmates.SelectedItems.Count > 1) {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                System.Windows.Forms.MessageBox.Show("Please chose one crewmember to hire.", "To many crewmembers", buttons, MessageBoxIcon.Warning);
                return;
            }
            ListView.SelectedIndexCollection chosenMemberIndex = lvHirableCrewmates.SelectedIndices;

            foreach (var index in chosenMemberIndex) {
                Ship.GetInstance().Crew.Add(newCrewMembers[(int)index]);
                lvHirableCrewmates.Items.RemoveAt((int)index);
                newCrewMembers.RemoveAt((int)index);
            }

            updateShipCrew();
        }

        private void updateShipCrew()
        {
            lvShipCrew.Clear();

            lvShipCrew.View = View.Details;
            int totalHunger = 0;

            lvShipCrew.Columns.Add("Name",-2, HorizontalAlignment.Center);
            foreach (var ability in Enum.GetValues(typeof(Abilities.AbilityNames))) {
                lvShipCrew.Columns.Add(ability.ToString(), -2, HorizontalAlignment.Center);
            }
            lvShipCrew.Columns.Add("Hunger", -2, HorizontalAlignment.Center);
            lvShipCrew.Columns.Add("Price", -2, HorizontalAlignment.Center);

            foreach (var crew in Ship.GetInstance().Crew) {
                ListViewItem placeHolder = new ListViewItem(crew.Name);
                for (int j = 0; j <= crew.Ability.maxAbilityIndex; j++) {
                    placeHolder.SubItems.Add(crew.Ability.GetAbilities()[j].ToString());
                }
                placeHolder.SubItems.Add(crew.HungerUsage.ToString());
                totalHunger += crew.HungerUsage;
                placeHolder.SubItems.Add(crew.Cost.ToString());

                lvShipCrew.Items.Add(placeHolder);
            }

            Ship.GetInstance().CrewAbilitiesDict();

            ListViewItem totalAbilities = new ListViewItem("Total");
            foreach (Abilities.AbilityNames abilityNames in Enum.GetValues(typeof(Abilities.AbilityNames))) {
                totalAbilities.SubItems.Add(Ship.GetInstance().CrewAbilities[abilityNames].ToString());
            }
            totalAbilities.SubItems.Add(totalHunger.ToString());
            lvShipCrew.Items.Add(totalAbilities);

            lvShipCrew.Columns[0].Width = -2;
        }
    }
}
