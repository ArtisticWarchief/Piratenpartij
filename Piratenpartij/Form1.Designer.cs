
namespace Piratenpartij
{
    partial class Form1
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
            this.btnGenName = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenName
            // 
            this.btnGenName.AccessibleName = "btnGenName";
            this.btnGenName.Location = new System.Drawing.Point(259, 198);
            this.btnGenName.Name = "btnGenName";
            this.btnGenName.Size = new System.Drawing.Size(75, 23);
            this.btnGenName.TabIndex = 0;
            this.btnGenName.Text = "button1";
            this.btnGenName.UseVisualStyleBackColor = true;
            this.btnGenName.Click += new System.EventHandler(this.btnGenName_Click);
            // 
            // lblName
            // 
            this.lblName.AccessibleName = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(234, 115);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnGenName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenName;
        private System.Windows.Forms.Label lblName;
    }
}

