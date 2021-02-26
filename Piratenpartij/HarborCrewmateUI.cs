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
                Console.WriteLine(newCrewMembers[i].ToString());

            }
        }

            private void listBoxHirableCrewmates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            Crewmember newMember = new Crewmember(random);
            string chosenMember = "";
            try {
                chosenMember = (string)listBoxHirableCrewmates.SelectedItem;
            } catch(InvalidCastException) {
                Console.WriteLine("Couldn't cast to string");
            }

            string[] subs = chosenMember.Split(' ');

            foreach (var crew in newCrewMembers) {
                if (crew.Name == subs[0]) {
                    Ship.Ship.GetInstance().Crewmembers.Add(crew);
                }
            }
        }

        private void btnCrewCheck_Click(object sender, EventArgs e)
        {
            foreach (var crew in Ship.Ship.GetInstance().Crewmembers) {
                Console.WriteLine(crew.ToString());
            }
        }
    }
}
