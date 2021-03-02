
namespace Piratenpartij
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.ShipPictureBox = new System.Windows.Forms.PictureBox();
            this.EventPictureBox = new System.Windows.Forms.PictureBox();
            this.ChoiceOneButton = new System.Windows.Forms.Button();
            this.ChoiceTwoButton = new System.Windows.Forms.Button();
            this.ChoiceThreeButton = new System.Windows.Forms.Button();
            this.CrewMemberText = new System.Windows.Forms.Label();
            this.CargoType1Text = new System.Windows.Forms.Label();
            this.CargoType1AmountText = new System.Windows.Forms.Label();
            this.CargoType2Text = new System.Windows.Forms.Label();
            this.CargoType3Text = new System.Windows.Forms.Label();
            this.CrewMemberAmountText = new System.Windows.Forms.Label();
            this.CargoType2AmountText = new System.Windows.Forms.Label();
            this.CargoType3AmountText = new System.Windows.Forms.Label();
            this.MoneyText = new System.Windows.Forms.Label();
            this.MoneyAmountText = new System.Windows.Forms.Label();
            this.HappinessText = new System.Windows.Forms.Label();
            this.TravelProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ShipPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShipPictureBox
            // 
            this.ShipPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ShipPictureBox.Image")));
            this.ShipPictureBox.Location = new System.Drawing.Point(12, 12);
            this.ShipPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShipPictureBox.Name = "ShipPictureBox";
            this.ShipPictureBox.Size = new System.Drawing.Size(224, 135);
            this.ShipPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShipPictureBox.TabIndex = 0;
            this.ShipPictureBox.TabStop = false;
            // 
            // EventPictureBox
            // 
            this.EventPictureBox.Image = global::Piratenpartij.Properties.Resources.harbor_cartoon;
            this.EventPictureBox.Location = new System.Drawing.Point(243, 12);
            this.EventPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EventPictureBox.Name = "EventPictureBox";
            this.EventPictureBox.Size = new System.Drawing.Size(417, 276);
            this.EventPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EventPictureBox.TabIndex = 1;
            this.EventPictureBox.TabStop = false;
            // 
            // ChoiceOneButton
            // 
            this.ChoiceOneButton.Location = new System.Drawing.Point(243, 294);
            this.ChoiceOneButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChoiceOneButton.Name = "ChoiceOneButton";
            this.ChoiceOneButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChoiceOneButton.Size = new System.Drawing.Size(417, 39);
            this.ChoiceOneButton.TabIndex = 2;
            this.ChoiceOneButton.Text = "ChoiceOne";
            this.ChoiceOneButton.UseVisualStyleBackColor = true;
            this.ChoiceOneButton.Click += new System.EventHandler(this.ChoiceOneButton_Click);
            // 
            // ChoiceTwoButton
            // 
            this.ChoiceTwoButton.Location = new System.Drawing.Point(243, 338);
            this.ChoiceTwoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChoiceTwoButton.Name = "ChoiceTwoButton";
            this.ChoiceTwoButton.Size = new System.Drawing.Size(417, 39);
            this.ChoiceTwoButton.TabIndex = 6;
            this.ChoiceTwoButton.Text = "ChoiceTwo";
            this.ChoiceTwoButton.UseVisualStyleBackColor = true;
            this.ChoiceTwoButton.Click += new System.EventHandler(this.ChoiceTwoButton_Click);
            // 
            // ChoiceThreeButton
            // 
            this.ChoiceThreeButton.Location = new System.Drawing.Point(243, 384);
            this.ChoiceThreeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChoiceThreeButton.Name = "ChoiceThreeButton";
            this.ChoiceThreeButton.Size = new System.Drawing.Size(417, 39);
            this.ChoiceThreeButton.TabIndex = 7;
            this.ChoiceThreeButton.Text = "ChoiceThree";
            this.ChoiceThreeButton.UseVisualStyleBackColor = true;
            this.ChoiceThreeButton.Click += new System.EventHandler(this.ChoiceThreeButton_Click);
            // 
            // CrewMemberText
            // 
            this.CrewMemberText.AutoSize = true;
            this.CrewMemberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrewMemberText.Location = new System.Drawing.Point(8, 398);
            this.CrewMemberText.Name = "CrewMemberText";
            this.CrewMemberText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.CrewMemberText.Size = new System.Drawing.Size(128, 25);
            this.CrewMemberText.TabIndex = 8;
            this.CrewMemberText.Text = "Crewmembers :";
            // 
            // CargoType1Text
            // 
            this.CargoType1Text.AutoSize = true;
            this.CargoType1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoType1Text.Location = new System.Drawing.Point(8, 222);
            this.CargoType1Text.Name = "CargoType1Text";
            this.CargoType1Text.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.CargoType1Text.Size = new System.Drawing.Size(114, 26);
            this.CargoType1Text.TabIndex = 10;
            this.CargoType1Text.Text = "Cargo type 1 :";
            // 
            // CargoType1AmountText
            // 
            this.CargoType1AmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoType1AmountText.Location = new System.Drawing.Point(153, 222);
            this.CargoType1AmountText.Name = "CargoType1AmountText";
            this.CargoType1AmountText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.CargoType1AmountText.Size = new System.Drawing.Size(83, 25);
            this.CargoType1AmountText.TabIndex = 11;
            this.CargoType1AmountText.Text = "250";
            // 
            // CargoType2Text
            // 
            this.CargoType2Text.AutoSize = true;
            this.CargoType2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoType2Text.Location = new System.Drawing.Point(8, 249);
            this.CargoType2Text.Name = "CargoType2Text";
            this.CargoType2Text.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.CargoType2Text.Size = new System.Drawing.Size(114, 26);
            this.CargoType2Text.TabIndex = 12;
            this.CargoType2Text.Text = "Cargo type 2 :";
            // 
            // CargoType3Text
            // 
            this.CargoType3Text.AutoSize = true;
            this.CargoType3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoType3Text.Location = new System.Drawing.Point(8, 276);
            this.CargoType3Text.Name = "CargoType3Text";
            this.CargoType3Text.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.CargoType3Text.Size = new System.Drawing.Size(114, 26);
            this.CargoType3Text.TabIndex = 15;
            this.CargoType3Text.Text = "Cargo type 3 :";
            // 
            // CrewMemberAmountText
            // 
            this.CrewMemberAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrewMemberAmountText.Location = new System.Drawing.Point(153, 399);
            this.CrewMemberAmountText.Name = "CrewMemberAmountText";
            this.CrewMemberAmountText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.CrewMemberAmountText.Size = new System.Drawing.Size(83, 25);
            this.CrewMemberAmountText.TabIndex = 16;
            this.CrewMemberAmountText.Text = "10 / 10";
            // 
            // CargoType2AmountText
            // 
            this.CargoType2AmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoType2AmountText.Location = new System.Drawing.Point(153, 247);
            this.CargoType2AmountText.Name = "CargoType2AmountText";
            this.CargoType2AmountText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.CargoType2AmountText.Size = new System.Drawing.Size(83, 25);
            this.CargoType2AmountText.TabIndex = 17;
            this.CargoType2AmountText.Text = "250";
            // 
            // CargoType3AmountText
            // 
            this.CargoType3AmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoType3AmountText.Location = new System.Drawing.Point(153, 276);
            this.CargoType3AmountText.Name = "CargoType3AmountText";
            this.CargoType3AmountText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.CargoType3AmountText.Size = new System.Drawing.Size(83, 25);
            this.CargoType3AmountText.TabIndex = 18;
            this.CargoType3AmountText.Text = "250";
            // 
            // MoneyText
            // 
            this.MoneyText.AutoSize = true;
            this.MoneyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyText.Location = new System.Drawing.Point(8, 182);
            this.MoneyText.Name = "MoneyText";
            this.MoneyText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.MoneyText.Size = new System.Drawing.Size(68, 26);
            this.MoneyText.TabIndex = 19;
            this.MoneyText.Text = "Money :";
            // 
            // MoneyAmountText
            // 
            this.MoneyAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyAmountText.Location = new System.Drawing.Point(153, 183);
            this.MoneyAmountText.Name = "MoneyAmountText";
            this.MoneyAmountText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.MoneyAmountText.Size = new System.Drawing.Size(83, 25);
            this.MoneyAmountText.TabIndex = 20;
            this.MoneyAmountText.Text = "250";
            // 
            // HappinessText
            // 
            this.HappinessText.AutoSize = true;
            this.HappinessText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HappinessText.Location = new System.Drawing.Point(8, 372);
            this.HappinessText.Name = "HappinessText";
            this.HappinessText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.HappinessText.Size = new System.Drawing.Size(99, 26);
            this.HappinessText.TabIndex = 21;
            this.HappinessText.Text = "Happiness :";
            // 
            // TravelProgressBar
            // 
            this.TravelProgressBar.Location = new System.Drawing.Point(13, 147);
            this.TravelProgressBar.Name = "TravelProgressBar";
            this.TravelProgressBar.Size = new System.Drawing.Size(224, 23);
            this.TravelProgressBar.TabIndex = 22;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 433);
            this.Controls.Add(this.TravelProgressBar);
            this.Controls.Add(this.HappinessText);
            this.Controls.Add(this.MoneyAmountText);
            this.Controls.Add(this.MoneyText);
            this.Controls.Add(this.CargoType3AmountText);
            this.Controls.Add(this.CargoType2AmountText);
            this.Controls.Add(this.CrewMemberAmountText);
            this.Controls.Add(this.CargoType3Text);
            this.Controls.Add(this.CargoType2Text);
            this.Controls.Add(this.CargoType1AmountText);
            this.Controls.Add(this.CargoType1Text);
            this.Controls.Add(this.CrewMemberText);
            this.Controls.Add(this.ChoiceThreeButton);
            this.Controls.Add(this.ChoiceTwoButton);
            this.Controls.Add(this.ChoiceOneButton);
            this.Controls.Add(this.EventPictureBox);
            this.Controls.Add(this.ShipPictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.Text = "Game time!";
            ((System.ComponentModel.ISupportInitialize)(this.ShipPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ShipPictureBox;
        private System.Windows.Forms.PictureBox EventPictureBox;
        private System.Windows.Forms.Button ChoiceOneButton;
        private System.Windows.Forms.Button ChoiceTwoButton;
        private System.Windows.Forms.Button ChoiceThreeButton;
        private System.Windows.Forms.Label CrewMemberText;
        private System.Windows.Forms.Label CargoType1Text;
        private System.Windows.Forms.Label CargoType1AmountText;
        private System.Windows.Forms.Label CargoType2Text;
        private System.Windows.Forms.Label CargoType3Text;
        private System.Windows.Forms.Label CrewMemberAmountText;
        private System.Windows.Forms.Label CargoType2AmountText;
        private System.Windows.Forms.Label CargoType3AmountText;
        private System.Windows.Forms.Label MoneyText;
        private System.Windows.Forms.Label MoneyAmountText;
        private System.Windows.Forms.Label HappinessText;
        private System.Windows.Forms.ProgressBar TravelProgressBar;
    }
}