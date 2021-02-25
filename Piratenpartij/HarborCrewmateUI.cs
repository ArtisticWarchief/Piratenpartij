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

namespace Piratenpartij
{
    public partial class HarborCrewmateUI : Form
    {
        private List<Crewmember> newCrewMembers = new List<Crewmember>();
        private Random random = new Random();
        public HarborCrewmateUI()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++) {
                Crewmember crew = new Crewmember(random);
                newCrewMembers.Add(crew);
                listBoxHirableCrewmates.Items.Add(newCrewMembers[i].ToString());
            }
        }

            private void listBoxHirableCrewmates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            if (listBoxHirableCrewmates.SelectedItem == null) {
                return;
            }
            int chosenMemberIndex = listBoxHirableCrewmates.SelectedIndex;
            Ship.Ship.GetInstance().Crewmembers.Add(newCrewMembers[chosenMemberIndex]);
            listBoxHirableCrewmates.Items.RemoveAt(chosenMemberIndex);
            newCrewMembers.RemoveAt(chosenMemberIndex);
        }

        private void btnCrewCheck_Click(object sender, EventArgs e)
        {
            foreach (var crew in Ship.Ship.GetInstance().Crewmembers) {
                Console.WriteLine(crew.ToString());
            }
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
