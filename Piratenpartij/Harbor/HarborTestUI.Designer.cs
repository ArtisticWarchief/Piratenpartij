namespace Piratenpartij.Harbor
{
    partial class HarborTestUI
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
            this.BtnBuyCargo = new System.Windows.Forms.Button();
            this.BtnSellCargo = new System.Windows.Forms.Button();
            this.BtnBuyCrewmembers = new System.Windows.Forms.Button();
            this.BtnDestination = new System.Windows.Forms.Button();
            this.BtnBuyFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBuyCargo
            // 
            this.BtnBuyCargo.Location = new System.Drawing.Point(507, 152);
            this.BtnBuyCargo.Name = "BtnBuyCargo";
            this.BtnBuyCargo.Size = new System.Drawing.Size(158, 23);
            this.BtnBuyCargo.TabIndex = 0;
            this.BtnBuyCargo.Text = "Buy Cargo";
            this.BtnBuyCargo.UseVisualStyleBackColor = true;
            this.BtnBuyCargo.Click += new System.EventHandler(this.BtnBuyCargo_Click);
            // 
            // BtnSellCargo
            // 
            this.BtnSellCargo.Location = new System.Drawing.Point(507, 199);
            this.BtnSellCargo.Name = "BtnSellCargo";
            this.BtnSellCargo.Size = new System.Drawing.Size(158, 23);
            this.BtnSellCargo.TabIndex = 1;
            this.BtnSellCargo.Text = "Sell Cargo";
            this.BtnSellCargo.UseVisualStyleBackColor = true;
            this.BtnSellCargo.Click += new System.EventHandler(this.BtnSellCargo_Click);
            // 
            // BtnBuyCrewmembers
            // 
            this.BtnBuyCrewmembers.Location = new System.Drawing.Point(507, 245);
            this.BtnBuyCrewmembers.Name = "BtnBuyCrewmembers";
            this.BtnBuyCrewmembers.Size = new System.Drawing.Size(158, 23);
            this.BtnBuyCrewmembers.TabIndex = 2;
            this.BtnBuyCrewmembers.Text = "Buy Crewmembers";
            this.BtnBuyCrewmembers.UseVisualStyleBackColor = true;
            this.BtnBuyCrewmembers.Click += new System.EventHandler(this.BtnBuyCrewmembers_Click);
            // 
            // BtnDestination
            // 
            this.BtnDestination.Location = new System.Drawing.Point(507, 291);
            this.BtnDestination.Name = "BtnDestination";
            this.BtnDestination.Size = new System.Drawing.Size(158, 23);
            this.BtnDestination.TabIndex = 3;
            this.BtnDestination.Text = "Change Destination";
            this.BtnDestination.UseVisualStyleBackColor = true;
            this.BtnDestination.Click += new System.EventHandler(this.BtnDestination_Click);
            // 
            // BtnBuyFood
            // 
            this.BtnBuyFood.Location = new System.Drawing.Point(507, 110);
            this.BtnBuyFood.Name = "BtnBuyFood";
            this.BtnBuyFood.Size = new System.Drawing.Size(158, 23);
            this.BtnBuyFood.TabIndex = 4;
            this.BtnBuyFood.Text = "Buy Food";
            this.BtnBuyFood.UseVisualStyleBackColor = true;
            this.BtnBuyFood.Click += new System.EventHandler(this.BtnBuyFood_Click);
            // 
            // HarborTestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBuyFood);
            this.Controls.Add(this.BtnDestination);
            this.Controls.Add(this.BtnBuyCrewmembers);
            this.Controls.Add(this.BtnSellCargo);
            this.Controls.Add(this.BtnBuyCargo);
            this.Name = "HarborTestUI";
            this.Text = "HarborTestUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBuyCargo;
        private System.Windows.Forms.Button BtnSellCargo;
        private System.Windows.Forms.Button BtnBuyCrewmembers;
        private System.Windows.Forms.Button BtnDestination;
        private System.Windows.Forms.Button BtnBuyFood;
    }
}