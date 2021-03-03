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

        HarborScreen harborUI = new HarborScreen();

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

            events = currentTrip.Events;
            foreach (Event e in events) {
                Console.WriteLine(e.EventType);
            }

            currentEvent = events[eventCounter];

            TravelProgressBar.Maximum = events.Count;
            TravelProgressBar.Value = 0;
            TravelProgressBar.Step = 1;


            FirstButtonPress += FirstButton;
            SecondButtonPress += SecondButton;
            ThirdButtonPress += ThirdButton;

            FirstButtonPress += UpdateScreen;
            SecondButtonPress += UpdateScreen;
            ThirdButtonPress += UpdateScreen;

            harborUI.FormClosing += HarborUI_FormClosed;

            InitializePictures();

            UpdateScreen();

            NextEvent();
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
            //Console.WriteLine("Update screen");
            UpdateAllCargos(ship.Cargo);
            ChangeMoneyAmountText(ship.Money);
            ChangeCrewMemberAmountText(ship.Crew.Count);
            ChangeFoodText(ship.Food);
        }

        private void NextEvent()
        {
            
            if (eventCounter >= events.Count()) {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                System.Windows.Forms.MessageBox.Show("You have reached the end of the game. Congratulations! We hope you had fun :)", "THE END", buttons, MessageBoxIcon.Information);
                this.Close();
                ship.ShipReset();
                new StartScreen().Show();
            } else if (ship.Crew.Count <= 0 || ship.Food <= 0) {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                System.Windows.Forms.MessageBox.Show("All your crewmates are dead, you are just an empty ship. :)", "THE END", buttons, MessageBoxIcon.Error);
                this.Close();
                ship.ShipReset();
                new StartScreen().Show();
            }
            else {
                currentEvent = events[eventCounter];
                Console.WriteLine(currentEvent.EventType);
                if (currentEvent.EventType == EventType.MERCHANT_SHIP) {
                    ShowNewEvent(currentEvent.EventType, "Trade", "Overtake", "Ignore");
                    ship.UseFood();
                }
                 else if (currentEvent.EventType == EventType.ISLAND) {
                    ShowNewEvent(currentEvent.EventType, "Take a chance", "Take a chance", "Take a chance");
                    ship.UseFood();
                }
                 else if (currentEvent.EventType == EventType.HARBOR) {
                    ShowNewEvent(currentEvent.EventType, "You are in a Harbor", "You are in a Harbor", "You are in a Harbor");
                    HarborEvent harborEvent = (HarborEvent)currentEvent;
                    harborUI.ReloadHarbor(harborEvent.Harbor);
                    harborUI.SetNewHirableCrew();
                    harborUI.BringToFront();
                    harborUI.Show();
                    this.Hide();
                }
                else if (currentEvent.EventType == EventType.PIRATES_SHIP) {
                    ShowNewEvent(currentEvent.EventType, "Fight", "Intimidate", "Cry and run");
                    ship.UseFood();
                }
            }
            TravelProgressBar.PerformStep();
            Console.WriteLine("Advanced progress bar");
            eventCounter++;
            UpdateScreen();

        }

        private void FirstButton()
        {
            switch (currentEvent.EventType) {
                case EventType.PIRATES_SHIP:
                    CombatEvent combatEvent = (CombatEvent)currentEvent;
                    combatEvent.fight();
                    break;
                case EventType.MERCHANT_SHIP:
                    TradeEvent tradeEvent = (TradeEvent)currentEvent;
                    tradeEvent.Trade();
                    break;
                case EventType.ISLAND:
                    IslandEvent islandEvent = (IslandEvent)currentEvent;
                    islandEvent.CallIslandEvent();
                    break;
                case EventType.HARBOR:
                    //new HarborCrewmateUI().Show();
                    break;
                default:
                    break;
            }
            NextEvent();
        }

        private void SecondButton()
        {
            switch (currentEvent.EventType) {
                case EventType.PIRATES_SHIP:
                    CombatEvent combatEvent = (CombatEvent)currentEvent;
                    combatEvent.intimidate();
                    break;
                case EventType.MERCHANT_SHIP:
                    TradeEvent tradeEvent = (TradeEvent)currentEvent;
                    tradeEvent.Overtake();
                    break;
                case EventType.ISLAND:
                    IslandEvent islandEvent = (IslandEvent)currentEvent;
                    islandEvent.CallIslandEvent();
                    break;
                case EventType.HARBOR:
                    //new HarborCrewmateUI().Show();
                    break;
                default:
                    break;
            }
            NextEvent();
        }

        private void ThirdButton()
        {
            switch (currentEvent.EventType) {
                case EventType.PIRATES_SHIP:
                    CombatEvent combatEvent = (CombatEvent)currentEvent;
                    combatEvent.run();
                    break;
                case EventType.MERCHANT_SHIP:
                    TradeEvent tradeEvent = (TradeEvent)currentEvent;
                    tradeEvent.Ignore();
                    break;
                case EventType.ISLAND:
                    IslandEvent islandEvent = (IslandEvent)currentEvent;
                    islandEvent.CallIslandEvent();
                    break;
                case EventType.HARBOR:
                    //new HarborCrewmateUI().Show();
                    break;
                default:
                    break;
            }
            NextEvent();
        }

        private void HarborUI_FormClosed(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) {
                NextEvent();
                e.Cancel = true;
                harborUI.Hide();
                Show();
                UpdateScreen();
            }
        }

        public void ShowNewEvent(EventType eventType, string choiceOne, string choiceTwo, string choiceThree)
        {
            ChoiceOneButton.Text = choiceOne;
            ChoiceTwoButton.Text = choiceTwo;
            ChoiceThreeButton.Text = choiceThree;

            EventPictureBox.Image = bitmaps[(int)eventType];
        }

        public void UpdateAllCargos(Dictionary<Cargo, int> cargos)
        {
            foreach (KeyValuePair<Cargos.Cargo, int> item in cargos) {
                if (item.Key.GetType() == typeof(Peugeot208)) CargoPeugotAmountText.Text = item.Value.ToString();
                else if (item.Key.GetType() == typeof(MountainHoliday)) CargoMountainAmountText.Text = item.Value.ToString();
                else if (item.Key.GetType() == typeof(AMSPortfolio)) CargoPortofolioAmountText.Text = item.Value.ToString();
            }
        }

        private void ChangeCrewMemberAmountText(int amount) => CrewMemberAmountText.Text = amount.ToString();
        private void ChangeMoneyAmountText(int amount) => MoneyAmountText.Text = amount.ToString();
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
