
namespace Login
{
    partial class MobileHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobileHome));
            this.pnl_Display = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_Display
            // 
            this.pnl_Display.Location = new System.Drawing.Point(0, 0);
            this.pnl_Display.Name = "pnl_Display";
            this.pnl_Display.Size = new System.Drawing.Size(412, 887);
            this.pnl_Display.TabIndex = 0;
            // 
            // MobileHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 887);
            this.Controls.Add(this.pnl_Display);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MobileHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapoo Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MobileHome_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Display;
    }
}