using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Piratenpartij.Cargos;
using Piratenpartij.Obstacles;
using Piratenpartij.Obstacles.Enums;
using System.Linq;
using Piratenpartij.Screens;

namespace Piratenpartij
{
    public partial class MainScreen : Form
    {
        private static Bitmap[] bitmaps = new Bitmap[4];

        private Ships.Ship ship;

        public delegate void ButtonPress();
        public event ButtonPress FirstButtonPress, SecondButtonPress, ThirdButtonPress;
        Event currentEvent;
        int eventCounter = 0;
        Trip currentTrip = new Trip();
        List<Event> events;

        public MainScreen()
        {
            InitializeComponent();

            ship = Ships.Ship.GetInstance();


            FirstButtonPress += FirstButton;
            SecondButtonPress += SecondButton;
            ThirdButtonPress += ThirdButton;
            FirstButtonPress += UpdateScreen;
            SecondButtonPress += UpdateScreen;
            ThirdButtonPress += UpdateScreen;
            
            InitializePictures();

            LoadScreenFirstTime();

            
            events = currentTrip.Events;
            foreach (Event e in events) {
                Console.WriteLine(e.EventType);
            }
            
            currentEvent = events[eventCounter];
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
            Console.WriteLine("Update screen");
            UpdateAllCargos(ship.Cargo);
            ChangeMoneyAmountText(ship.Money);
            ChangeCrewMemberAmountText(ship.Crew.Count);
            ChangeHappinessText(ship.Fun);
            ChangeFoodText(ship.Food);
        }

        private void nextEvent()
        {
            eventCounter++;
            if (eventCounter >= events.Count()) {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                System.Windows.Forms.MessageBox.Show("You have reached the end of the game. Congratulations! We hope you had fun :)", "THE END", buttons, MessageBoxIcon.Warning);
                this.Close();
                ship.ShipReset();
                new StartScreen().Show();
            }
            else {
                currentEvent = events[eventCounter];
                Console.WriteLine(currentEvent.EventType);
                if (currentEvent.EventType == EventType.MERCHANT_SHIP) {
                    ShowNewEvent(currentEvent.EventType, "Trade", "Overtake", "Ignore");
                    return;
                }
                if (currentEvent.EventType == EventType.ISLAND) {
                    ShowNewEvent(currentEvent.EventType, "Take a chance", "Take a chance", "Take a chance");
                    return;
                }
                if (currentEvent.EventType == EventType.HARBOR) {
                    return;
                }
            }
            
        }

        private void FirstButton()
        {
            if (currentEvent.EventType == EventType.MERCHANT_SHIP) {
                TradeEvent trade = (TradeEvent)currentEvent;
                trade.Trade(new MountainHoliday(),20);
            }
            if (currentEvent.EventType == EventType.ISLAND) {
                IslandEvent trade = (IslandEvent)currentEvent;
                trade.CallIslandEvent();
            }
            if (currentEvent.EventType == EventType.HARBOR) {
                new HarborCrewmateUI().Show();
            }
            if (currentEvent.EventType == EventType.PIRATES_SHIP) {
            }
            nextEvent();
        }

        private void SecondButton()
        {
            if (currentEvent.EventType == EventType.MERCHANT_SHIP) {
                TradeEvent trade = (TradeEvent)currentEvent;
                trade.Overtake();
            }
            if (currentEvent.EventType == EventType.ISLAND) {
                IslandEvent trade = (IslandEvent)currentEvent;
                trade.CallIslandEvent();
            }
            if (currentEvent.EventType == EventType.HARBOR) {
                new HarborCrewmateUI().Show();
            }
            if (currentEvent.EventType == EventType.PIRATES_SHIP) {
            }
            nextEvent();
        }

        private void ThirdButton()
        {
            if (currentEvent.EventType == EventType.MERCHANT_SHIP) {
                TradeEvent trade = (TradeEvent)currentEvent;
                trade.Ignore();
            }
            if (currentEvent.EventType == EventType.ISLAND) {
                IslandEvent trade = (IslandEvent)currentEvent;
                trade.CallIslandEvent();
            }
            if (currentEvent.EventType == EventType.HARBOR) {
                new HarborCrewmateUI().Show();
            }
            if (currentEvent.EventType == EventType.PIRATES_SHIP) {
            }
            nextEvent();
        }
        private void LoadScreenFirstTime()
        {
            //ShowNewEvent(EventType.HARBOR, "Je eerste keuze", "WOW nog een!", "Wat veel keuzes!");
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

        private void MainScreen_Load(object sender, EventArgs e)
        {

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
