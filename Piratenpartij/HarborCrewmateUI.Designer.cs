
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
            this.btnHire.Location = new System.Drawing.Point(124, 524);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(124, 49);
            this.btnHire.TabIndex = 1;
            this.btnHire.Text = "Hire";
            this.btnHire.UseVisualStyleBackColor = true;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // lvHirableCrewmates
            // 
            this.lvHirableCrewmates.GridLines = true;
            this.lvHirableCrewmates.HideSelection = false;
            this.lvHirableCrewmates.Location = new System.Drawing.Point(12, 70);
            this.lvHirableCrewmates.Name = "lvHirableCrewmates";
            this.lvHirableCrewmates.Size = new System.Drawing.Size(348, 434);
            this.lvHirableCrewmates.TabIndex = 3;
            this.lvHirableCrewmates.UseCompatibleStateImageBehavior = false;
            // 
            // lvShipCrew
            // 
            this.lvShipCrew.HideSelection = false;
            this.lvShipCrew.Location = new System.Drawing.Point(366, 70);
            this.lvShipCrew.Name = "lvShipCrew";
            this.lvShipCrew.Size = new System.Drawing.Size(350, 434);
            this.lvShipCrew.TabIndex = 4;
            this.lvShipCrew.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Crew For Hire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Crew onboard";
            // 
            // HarborCrewmateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvShipCrew);
            this.Controls.Add(this.lvHirableCrewmates);
            this.Controls.Add(this.btnHire);
            this.MaximizeBox = false;
            this.Name = "HarborCrewmateUI";
            this.Text = "HarborCrewmateUI";
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