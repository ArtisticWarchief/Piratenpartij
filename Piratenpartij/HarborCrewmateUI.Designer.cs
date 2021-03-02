
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
            this.listBoxHirableCrewmates = new System.Windows.Forms.ListBox();
            this.btnHire = new System.Windows.Forms.Button();
            this.btnCrewCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxHirableCrewmates
            // 
            this.listBoxHirableCrewmates.AccessibleName = "listBoxHirableCrewmates";
            this.listBoxHirableCrewmates.BackColor = System.Drawing.Color.White;
            this.listBoxHirableCrewmates.FormattingEnabled = true;
            this.listBoxHirableCrewmates.Location = new System.Drawing.Point(260, 28);
            this.listBoxHirableCrewmates.Name = "listBoxHirableCrewmates";
            this.listBoxHirableCrewmates.Size = new System.Drawing.Size(491, 173);
            this.listBoxHirableCrewmates.TabIndex = 0;
            this.listBoxHirableCrewmates.SelectedIndexChanged += new System.EventHandler(this.listBoxHirableCrewmates_SelectedIndexChanged);
            // 
            // btnHire
            // 
            this.btnHire.Location = new System.Drawing.Point(467, 223);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(75, 23);
            this.btnHire.TabIndex = 1;
            this.btnHire.Text = "Hire";
            this.btnHire.UseVisualStyleBackColor = true;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // btnCrewCheck
            // 
            this.btnCrewCheck.Location = new System.Drawing.Point(541, 318);
            this.btnCrewCheck.Name = "btnCrewCheck";
            this.btnCrewCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCrewCheck.TabIndex = 2;
            this.btnCrewCheck.Text = "button1";
            this.btnCrewCheck.UseVisualStyleBackColor = true;
            this.btnCrewCheck.Click += new System.EventHandler(this.btnCrewCheck_Click);
            // 
            // HarborCrewmateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrewCheck);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.listBoxHirableCrewmates);
            this.Name = "HarborCrewmateUI";
            this.Text = "HarborCrewmateUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHirableCrewmates;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.Button btnCrewCheck;
    }
}