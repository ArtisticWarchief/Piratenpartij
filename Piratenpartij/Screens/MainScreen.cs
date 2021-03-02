using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Piratenpartij.Obstacles;

namespace Piratenpartij
{
    public partial class MainScreen : Form
    {
        private static Bitmap[] bitmaps = new Bitmap[4];

        private Ships.Ship ship;

        public delegate void ButtonPress();
        public event ButtonPress FirstButtonPress, SecondButtonPress, ThirdButtonPress;

        public MainScreen()
        {
            InitializeComponent();

            ship = Ships.Ship.GetInstance();

            FirstButtonPress += UpdateScreen;
            SecondButtonPress += UpdateScreen;
            ThirdButtonPress += UpdateScreen;

            InitializePictures();

            LoadScreenFirstTime();
        }

        #region initalization

        private void InitializePictures()
        {
            bitmaps[0] = Properties.Resources.piraten_plaatje;
            bitmaps[1] = Properties.Resources.Bootje_Cartoon;
            bitmaps[2] = Properties.Resources.eiland_plaatje;
            bitmaps[3] = Properties.Resources.harbor_cartoon;
        }

        #endregion

        private void UpdateScreen()
        {
            UpdateAllCargos(ship.Cargo);
            ChangeMoneyAmountText(ship.Money);
            ChangeCrewMemberAmountText(ship.Crewmembers.Count);
            ChangeHappinessText(ship.Fun);
            ChangeFoodText(ship.Food);
        }

        private void LoadScreenFirstTime()
        {
            ShowNewEvent(EventType.HARBOR, "Je eerste keuze", "WOW nog een!", "Wat veel keuzes!");
            UpdateScreen();
        }

        public void ShowNewEvent(EventType eventType, string choiceOne, string choiceTwo, string choiceThree)
        {
            ChoiceOneButton.Text = choiceOne;
            ChoiceTwoButton.Text = choiceTwo;
            ChoiceThreeButton.Text = choiceThree;

            EventPictureBox.Image = bitmaps[(int)eventType];
        }

        public void UpdateAllCargos(Dictionary<Cargos.Cargo, int> cargos)
        {
            foreach (KeyValuePair<Cargos.Cargo, int> item in cargos) 
            {
                if (item.Key.GetType() == typeof(Cargos.Peugeot208)) CargoPeugotAmountText.Text = item.Value.ToString();
                else if (item.Key.GetType() == typeof(Cargos.MountainHoliday)) CargoMountainAmountText.Text = item.Value.ToString();
                else if (item.Key.GetType() == typeof(Cargos.AMSPortfolio)) CargoPortofolioAmountText.Text = item.Value.ToString();
            }
        }

        private void ChangeCrewMemberAmountText(int amount) => CrewMemberAmountText.Text = amount.ToString();
        private void ChangeMoneyAmountText(int amount) => MoneyAmountText.Text = amount.ToString();
        private void ChangeHappinessText(int amount) => HappinessAmountText.Text = amount.ToString();
        private void ChangeFoodText(int amount) => FoodAmountText.Text = amount.ToString();

        #region ButtonPresses
        private void ChoiceOneButton_Click(object sender, EventArgs e)
        {
            FirstButtonPress?.Invoke();
        }
        private void ChoiceTwoButton_Click(object sender, EventArgs e)
        {
            SecondButtonPress?.Invoke();
        }
        private void ChoiceThreeButton_Click(object sender, EventArgs e)
        {
            ThirdButtonPress?.Invoke();
        }
        #endregion
    }
}
