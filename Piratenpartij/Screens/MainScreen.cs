using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace Piratenpartij
{
    public partial class MainScreen : Form
    {

        private static Button choiceButtonOne, choiceButtonTwo, choiceButtonThree;
        private static PictureBox eventPictureBox;
        private static Bitmap[] bitmaps = new Bitmap[2];
        private static Label moneyAmountLabel, cargoType1AmountLabel, cargoType2AmountLabel, cargoType3AmountLabel, happinessAmountLabel, crewMemberAmountLabel;

        private void MoneyAmountText_Click(object sender, EventArgs e)
        {

        }

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

        public static void ShowNewEvent(int eventType, string choiceOne, string choiceTwo, string choiceThree)
        {
            choiceButtonOne.Text = choiceOne;
            choiceButtonTwo.Text = choiceTwo;
            choiceButtonThree.Text = choiceThree;
            
            eventPictureBox.Image = bitmaps[eventType];
        }
    }
}
