using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using Piratenpartij.Obstacles;

namespace Piratenpartij
{
    public partial class MainScreen : Form
    {

        private static Button choiceButtonOne, choiceButtonTwo, choiceButtonThree;
        private static PictureBox eventPictureBox;
        private static Bitmap[] bitmaps = new Bitmap[4];

        private static Label moneyAmountLabel;
        private static Label cargoPeugotAmountLabel, cargoMountainAmountLabel, cargoPortofolioAmountLabel;
        private static Label happinessAmountLabel, crewMemberAmountLabel;

        public delegate void ButtonPressEventHandler();
        public event ButtonPressEventHandler FirstButtonPress, SecondButtonPress, ThirdButtonPress;

        public MainScreen()
        {
            InitializeComponent();

            InitializeButtons();
            InitializePictures();
            InitializeTexts();

            LoadScreenFirstTime();
        }

        #region initalization

        private void InitializeButtons()
        {
            choiceButtonOne = ChoiceOneButton;
            choiceButtonTwo = ChoiceTwoButton;
            choiceButtonThree = ChoiceThreeButton;
        }

        private void InitializePictures()
        {
            eventPictureBox = EventPictureBox;

            bitmaps[1] = Properties.Resources.Bootje_Cartoon;
            bitmaps[3] = Properties.Resources.harbor_cartoon;
        }

        private void InitializeTexts()
        {
            moneyAmountLabel = MoneyAmountText;
            cargoPeugotAmountLabel = CargoPeugotAmountText;
            cargoMountainAmountLabel = CargoMountainAmountText;
            cargoPortofolioAmountLabel = CargoPortofolioAmountText;
            happinessAmountLabel = HappinessAmountText;
            crewMemberAmountLabel = CrewMemberAmountText;
        }
        #endregion

        private void LoadScreenFirstTime()
        {
            ShowNewEvent(EventType.HARBOR, "1", "2", "3");
            UpdateAllCargos(Ships.Ship.GetInstance().Cargo);
            ChangeMoneyAmountText(Ships.Ship.GetInstance().Money);
            ChangeCrewMemberAmountText(Ships.Ship.GetInstance().Crewmembers.Count);
            ChangeHappinessText(Ships.Ship.GetInstance().Fun);
        }

        public static void ShowNewEvent(EventType eventType, string choiceOne, string choiceTwo, string choiceThree)
        {
            choiceButtonOne.Text = choiceOne;
            choiceButtonTwo.Text = choiceTwo;
            choiceButtonThree.Text = choiceThree;

            eventPictureBox.Image = bitmaps[(int)eventType];
        }

        public static void ChangeCargoAmountText(Cargos.Cargo cargo, int amount)
        {
            if (cargo.GetType() == typeof(Cargos.Peugeot208)) cargoPeugotAmountLabel.Text = amount.ToString();
            else if (cargo.GetType() == typeof(Cargos.MountainHoliday)) cargoMountainAmountLabel.Text = amount.ToString();
            else if (cargo.GetType() == typeof(Cargos.AMSPortfolio)) cargoPortofolioAmountLabel.Text = amount.ToString();
        }

        public static void UpdateAllCargos(Dictionary<Cargos.Cargo, int> cargos)
        {
            foreach (KeyValuePair<Cargos.Cargo, int> item in cargos) 
            {
                ChangeCargoAmountText(item.Key, item.Value);
            }
        }

        public static void ChangeCrewMemberAmountText(int amount)
        {
            crewMemberAmountLabel.Text = amount.ToString();
        }

        public static void ChangeMoneyAmountText(int amount)
        {
            moneyAmountLabel.Text = amount.ToString();
        }

        public static void ChangeHappinessText(int amount)
        {
            happinessAmountLabel.Text = amount.ToString();
        }

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
