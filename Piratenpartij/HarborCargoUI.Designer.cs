
namespace Piratenpartij
{
    partial class HarborCargoUI
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
            if (disposing && (components != null)) {
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
            this.BtnBuyCargo = new System.Windows.Forms.Button();
            this.BtnSellCargo = new System.Windows.Forms.Button();
            this.BtnBuyFood = new System.Windows.Forms.Button();
            this.BtnBuyCrew = new System.Windows.Forms.Button();
            this.LblHarborInfo = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnBuySelectedCrew = new System.Windows.Forms.Button();
            this.BtnBuySelectedCargo = new System.Windows.Forms.Button();
            this.BtnSetSail = new System.Windows.Forms.Button();
            this.BtnSelectedDestination = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBuyCargo
            // 
            this.BtnBuyCargo.Location = new System.Drawing.Point(461, 160);
            this.BtnBuyCargo.Name = "BtnBuyCargo";
            this.BtnBuyCargo.Size = new System.Drawing.Size(110, 23);
            this.BtnBuyCargo.TabIndex = 0;
            this.BtnBuyCargo.Text = "Buy Cargo";
            this.BtnBuyCargo.UseVisualStyleBackColor = true;
            this.BtnBuyCargo.Click += new System.EventHandler(this.BtnBuyCargo_Click);
            // 
            // BtnSellCargo
            // 
            this.BtnSellCargo.Location = new System.Drawing.Point(461, 203);
            this.BtnSellCargo.Name = "BtnSellCargo";
            this.BtnSellCargo.Size = new System.Drawing.Size(110, 23);
            this.BtnSellCargo.TabIndex = 1;
            this.BtnSellCargo.Text = "Sell Cargo";
            this.BtnSellCargo.UseVisualStyleBackColor = true;
            this.BtnSellCargo.Click += new System.EventHandler(this.BtnSellCargo_Click);
            // 
            // BtnBuyFood
            // 
            this.BtnBuyFood.Location = new System.Drawing.Point(461, 245);
            this.BtnBuyFood.Name = "BtnBuyFood";
            this.BtnBuyFood.Size = new System.Drawing.Size(110, 23);
            this.BtnBuyFood.TabIndex = 2;
            this.BtnBuyFood.Text = "Buy Food";
            this.BtnBuyFood.UseVisualStyleBackColor = true;
            this.BtnBuyFood.Click += new System.EventHandler(this.BtnBuyFood_Click);
            // 
            // BtnBuyCrew
            // 
            this.BtnBuyCrew.Location = new System.Drawing.Point(461, 285);
            this.BtnBuyCrew.Name = "BtnBuyCrew";
            this.BtnBuyCrew.Size = new System.Drawing.Size(110, 23);
            this.BtnBuyCrew.TabIndex = 3;
            this.BtnBuyCrew.Text = "Buy Crew";
            this.BtnBuyCrew.UseVisualStyleBackColor = true;
            this.BtnBuyCrew.Click += new System.EventHandler(this.BtnBuyCrew_Click);
            // 
            // LblHarborInfo
            // 
            this.LblHarborInfo.AutoSize = true;
            this.LblHarborInfo.Location = new System.Drawing.Point(544, 46);
            this.LblHarborInfo.Name = "LblHarborInfo";
            this.LblHarborInfo.Size = new System.Drawing.Size(75, 17);
            this.LblHarborInfo.TabIndex = 4;
            this.LblHarborInfo.Text = "HarborInfo";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(88, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 372);
            this.listBox1.TabIndex = 5;
            // 
            // BtnBuySelectedCrew
            // 
            this.BtnBuySelectedCrew.Location = new System.Drawing.Point(164, 390);
            this.BtnBuySelectedCrew.Name = "BtnBuySelectedCrew";
            this.BtnBuySelectedCrew.Size = new System.Drawing.Size(111, 23);
            this.BtnBuySelectedCrew.TabIndex = 6;
            this.BtnBuySelectedCrew.Text = "Buy Crew";
            this.BtnBuySelectedCrew.UseVisualStyleBackColor = true;
            this.BtnBuySelectedCrew.Click += new System.EventHandler(this.BtnBuySelectedCrew_Click);
            // 
            // BtnBuySelectedCargo
            // 
            this.BtnBuySelectedCargo.Location = new System.Drawing.Point(47, 390);
            this.BtnBuySelectedCargo.Name = "BtnBuySelectedCargo";
            this.BtnBuySelectedCargo.Size = new System.Drawing.Size(111, 23);
            this.BtnBuySelectedCargo.TabIndex = 7;
            this.BtnBuySelectedCargo.Text = "Buy Cargo";
            this.BtnBuySelectedCargo.UseVisualStyleBackColor = true;
            this.BtnBuySelectedCargo.Click += new System.EventHandler(this.BtnBuySelectedCargo_Click);
            // 
            // BtnSetSail
            // 
            this.BtnSetSail.Location = new System.Drawing.Point(461, 325);
            this.BtnSetSail.Name = "BtnSetSail";
            this.BtnSetSail.Size = new System.Drawing.Size(110, 23);
            this.BtnSetSail.TabIndex = 8;
            this.BtnSetSail.Text = "Set Sail!";
            this.BtnSetSail.UseVisualStyleBackColor = true;
            // 
            // BtnSelectedDestination
            // 
            this.BtnSelectedDestination.Location = new System.Drawing.Point(281, 390);
            this.BtnSelectedDestination.Name = "BtnSelectedDestination";
            this.BtnSelectedDestination.Size = new System.Drawing.Size(111, 23);
            this.BtnSelectedDestination.TabIndex = 9;
            this.BtnSelectedDestination.Text = "Set Sail!";
            this.BtnSelectedDestination.UseVisualStyleBackColor = true;
            this.BtnSelectedDestination.Click += new System.EventHandler(this.BtnSelectedDestination_Click);
            // 
            // HarborScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSelectedDestination);
            this.Controls.Add(this.BtnSetSail);
            this.Controls.Add(this.BtnBuySelectedCargo);
            this.Controls.Add(this.BtnBuySelectedCrew);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LblHarborInfo);
            this.Controls.Add(this.BtnBuyCrew);
            this.Controls.Add(this.BtnBuyFood);
            this.Controls.Add(this.BtnSellCargo);
            this.Controls.Add(this.BtnBuyCargo);
            this.Name = "HarborScreen";
            this.Text = "HarborScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuyCargo;
        private System.Windows.Forms.Button BtnSellCargo;
        private System.Windows.Forms.Button BtnBuyFood;
        private System.Windows.Forms.Button BtnBuyCrew;
        private System.Windows.Forms.Label LblHarborInfo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnBuySelectedCrew;
        private System.Windows.Forms.Button BtnBuySelectedCargo;
        private System.Windows.Forms.Button BtnSetSail;
        private System.Windows.Forms.Button BtnSelectedDestination;
    }
}