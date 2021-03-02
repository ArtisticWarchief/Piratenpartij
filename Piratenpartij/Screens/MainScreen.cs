﻿using System;
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
        private static Bitmap[] bitmaps = new Bitmap[2];

        private static Label moneyAmountLabel;
        private static Label cargoType1AmountLabel, cargoType2AmountLabel, cargoType3AmountLabel;
        private static Label happinessAmountLabel, crewMemberAmountLabel;

        public delegate void ButtonPressEventHandler();
        public event ButtonPressEventHandler FirstButtonPress, SecondButtonPress, ThirdButtonPress;

        public MainScreen()
        {
            InitializeComponent();

            //Initalize Buttons
            choiceButtonOne = ChoiceOneButton;
            choiceButtonTwo = ChoiceTwoButton;
            choiceButtonThree = ChoiceThreeButton;

            eventPictureBox = EventPictureBox;

            bitmaps[0] = Properties.Resources.harbor_cartoon;
            bitmaps[1] = Properties.Resources.Bootje_Cartoon;

            moneyAmountLabel = MoneyAmountText;
            cargoType1AmountLabel = CargoType1AmountText;
            cargoType2AmountLabel = CargoType2AmountText;
            cargoType3AmountLabel = CargoType3AmountText;
            //happinessAmountLabel = 
            crewMemberAmountLabel = CrewMemberAmountText;

            LoadScreenFirstTime();
        }

        private void LoadScreenFirstTime()
        {
            ShowNewEvent(EventType.HARBOR, "1", "2", "3");
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

        public static void ShowNewEvent(EventType eventType, string choiceOne, string choiceTwo, string choiceThree)
        {
            choiceButtonOne.Text = choiceOne;
            choiceButtonTwo.Text = choiceTwo;
            choiceButtonThree.Text = choiceThree;

            eventPictureBox.Image = bitmaps[(int)eventType];
        }

        public static void ChangeCargoAmountText(int cargoType, int amount)
        {
            if (cargoType == 1) cargoType1AmountLabel.Text = amount.ToString();
            else if (cargoType == 2) cargoType1AmountLabel.Text = amount.ToString();
            else if (cargoType == 3) cargoType1AmountLabel.Text = amount.ToString();
        }

        public static void ChangeCrewMemberAmountText(int amount)
        {
            //TODO: GET MAXIMUM FROM SHIP
            int maxCrew = 10;

            crewMemberAmountLabel.Text = amount.ToString() + " / " + maxCrew.ToString();
        }

        public static void ChangeMoneyAmountText(int amount)
        {
            moneyAmountLabel.Text = amount.ToString();
        }

        public static void ChangeHappinessText(int amount)
        {
            happinessAmountLabel.Text = amount.ToString();
        }
    }
}
