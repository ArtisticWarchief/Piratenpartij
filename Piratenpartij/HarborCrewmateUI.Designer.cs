
namespace Piratenpartij
{
    partial class HarborCrewmateUI
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
            this.btnHire = new System.Windows.Forms.Button();
            this.lvHirableCrewmates = new System.Windows.Forms.ListView();
            this.lvShipCrew = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHire
            // 
            this.btnHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHire.Location = new System.Drawing.Point(165, 645);
            this.btnHire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(165, 60);
            this.btnHire.TabIndex = 1;
            this.btnHire.Text = "Hire";
            this.btnHire.UseVisualStyleBackColor = true;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // lvHirableCrewmates
            // 
            this.lvHirableCrewmates.GridLines = true;
            this.lvHirableCrewmates.HideSelection = false;
            this.lvHirableCrewmates.Location = new System.Drawing.Point(16, 86);
            this.lvHirableCrewmates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvHirableCrewmates.Name = "lvHirableCrewmates";
            this.lvHirableCrewmates.Size = new System.Drawing.Size(463, 533);
            this.lvHirableCrewmates.TabIndex = 3;
            this.lvHirableCrewmates.UseCompatibleStateImageBehavior = false;
            // 
            // lvShipCrew
            // 
            this.lvShipCrew.HideSelection = false;
            this.lvShipCrew.Location = new System.Drawing.Point(488, 86);
            this.lvShipCrew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvShipCrew.Name = "lvShipCrew";
            this.lvShipCrew.Size = new System.Drawing.Size(465, 533);
            this.lvShipCrew.TabIndex = 4;
            this.lvShipCrew.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Crew For Hire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Crew onboard";
            // 
            // HarborCrewmateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvShipCrew);
            this.Controls.Add(this.lvHirableCrewmates);
            this.Controls.Add(this.btnHire);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HarborCrewmateUI";
            this.Text = "HarborCrewmateUI";
            this.Load += new System.EventHandler(this.HarborCrewmateUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.ListView lvHirableCrewmates;
        private System.Windows.Forms.ListView lvShipCrew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}