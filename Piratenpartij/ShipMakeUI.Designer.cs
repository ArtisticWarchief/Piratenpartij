
namespace Piratenpartij
{
    partial class ShipMakeUI
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
            this.shipContent = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // shipContent
            // 
            this.shipContent.HideSelection = false;
            this.shipContent.Location = new System.Drawing.Point(12, 12);
            this.shipContent.Name = "shipContent";
            this.shipContent.Size = new System.Drawing.Size(121, 97);
            this.shipContent.TabIndex = 0;
            this.shipContent.UseCompatibleStateImageBehavior = false;
            this.shipContent.SelectedIndexChanged += new System.EventHandler(this.shipContent_SelectedIndexChanged);
            // 
            // ShipMakeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shipContent);
            this.Name = "ShipMakeUI";
            this.Text = "ShipMakeUI";
            this.Load += new System.EventHandler(this.ShipMakeUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView shipContent;
    }
}