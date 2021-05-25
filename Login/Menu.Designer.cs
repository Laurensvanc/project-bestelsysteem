
namespace Login
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ts_navigation = new System.Windows.Forms.ToolStrip();
            this.btn_navLogo = new System.Windows.Forms.ToolStripButton();
            this.btn_navHome = new System.Windows.Forms.ToolStripButton();
            this.btn_navReserveringen = new System.Windows.Forms.ToolStripButton();
            this.btn_navBarKeuken = new System.Windows.Forms.ToolStripButton();
            this.btn_navBestellingen = new System.Windows.Forms.ToolStripButton();
            this.btn_navVoorraad = new System.Windows.Forms.ToolStripButton();
            this.btn_closeForm = new System.Windows.Forms.Button();
            this.lbl_userDisplay = new System.Windows.Forms.Label();
            this.lbl_timeDisplay = new System.Windows.Forms.Label();
            this.pnl_Display = new System.Windows.Forms.Panel();
            this.pnl_WhiteStrip = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ts_navigation.SuspendLayout();
            this.pnl_WhiteStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_navigation
            // 
            this.ts_navigation.AutoSize = false;
            this.ts_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.ts_navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_navigation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_navigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_navLogo,
            this.btn_navHome,
            this.btn_navReserveringen,
            this.btn_navBarKeuken,
            this.btn_navBestellingen,
            this.btn_navVoorraad});
            this.ts_navigation.Location = new System.Drawing.Point(0, 0);
            this.ts_navigation.Name = "ts_navigation";
            this.ts_navigation.Size = new System.Drawing.Size(344, 1041);
            this.ts_navigation.TabIndex = 0;
            this.ts_navigation.Text = "toolStrip1";
            // 
            // btn_navLogo
            // 
            this.btn_navLogo.AutoSize = false;
            this.btn_navLogo.BackgroundImage = global::Login.Properties.Resources.chapoo_white;
            this.btn_navLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_navLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_navLogo.Enabled = false;
            this.btn_navLogo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_navLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_navLogo.Name = "btn_navLogo";
            this.btn_navLogo.Size = new System.Drawing.Size(344, 199);
            this.btn_navLogo.Text = "Logo";
            // 
            // btn_navHome
            // 
            this.btn_navHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(61)))), ((int)(((byte)(102)))));
            this.btn_navHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_navHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.btn_navHome.ForeColor = System.Drawing.Color.White;
            this.btn_navHome.Image = ((System.Drawing.Image)(resources.GetObject("btn_navHome.Image")));
            this.btn_navHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_navHome.Name = "btn_navHome";
            this.btn_navHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_navHome.Size = new System.Drawing.Size(342, 59);
            this.btn_navHome.Text = "Home";
            this.btn_navHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_navHome.ToolTipText = "Home";
            this.btn_navHome.Click += new System.EventHandler(this.btn_navHome_Click);
            // 
            // btn_navReserveringen
            // 
            this.btn_navReserveringen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_navReserveringen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.btn_navReserveringen.ForeColor = System.Drawing.Color.White;
            this.btn_navReserveringen.Image = ((System.Drawing.Image)(resources.GetObject("btn_navReserveringen.Image")));
            this.btn_navReserveringen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_navReserveringen.Name = "btn_navReserveringen";
            this.btn_navReserveringen.Size = new System.Drawing.Size(342, 59);
            this.btn_navReserveringen.Text = "Reserveringen";
            this.btn_navReserveringen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_navReserveringen.Click += new System.EventHandler(this.btn_navReserveringen_Click);
            // 
            // btn_navBarKeuken
            // 
            this.btn_navBarKeuken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(61)))), ((int)(((byte)(102)))));
            this.btn_navBarKeuken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_navBarKeuken.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.btn_navBarKeuken.ForeColor = System.Drawing.Color.White;
            this.btn_navBarKeuken.Image = ((System.Drawing.Image)(resources.GetObject("btn_navBarKeuken.Image")));
            this.btn_navBarKeuken.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_navBarKeuken.Name = "btn_navBarKeuken";
            this.btn_navBarKeuken.Size = new System.Drawing.Size(342, 59);
            this.btn_navBarKeuken.Text = "Bar/Keuken";
            this.btn_navBarKeuken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_navBarKeuken.Click += new System.EventHandler(this.btn_navBarKeuken_Click);
            // 
            // btn_navBestellingen
            // 
            this.btn_navBestellingen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_navBestellingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.btn_navBestellingen.ForeColor = System.Drawing.Color.White;
            this.btn_navBestellingen.Image = ((System.Drawing.Image)(resources.GetObject("btn_navBestellingen.Image")));
            this.btn_navBestellingen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_navBestellingen.Name = "btn_navBestellingen";
            this.btn_navBestellingen.Size = new System.Drawing.Size(342, 59);
            this.btn_navBestellingen.Text = "Bestellingen";
            this.btn_navBestellingen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_navBestellingen.Click += new System.EventHandler(this.btn_navBestellingen_Click);
            // 
            // btn_navVoorraad
            // 
            this.btn_navVoorraad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(61)))), ((int)(((byte)(102)))));
            this.btn_navVoorraad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_navVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.btn_navVoorraad.ForeColor = System.Drawing.Color.White;
            this.btn_navVoorraad.Image = ((System.Drawing.Image)(resources.GetObject("btn_navVoorraad.Image")));
            this.btn_navVoorraad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_navVoorraad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_navVoorraad.Name = "btn_navVoorraad";
            this.btn_navVoorraad.Size = new System.Drawing.Size(342, 59);
            this.btn_navVoorraad.Text = "Voorraad";
            this.btn_navVoorraad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_closeForm
            // 
            this.btn_closeForm.BackColor = System.Drawing.Color.Transparent;
            this.btn_closeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeForm.ForeColor = System.Drawing.Color.Transparent;
            this.btn_closeForm.Image = global::Login.Properties.Resources.Shut_down;
            this.btn_closeForm.Location = new System.Drawing.Point(1511, 7);
            this.btn_closeForm.Name = "btn_closeForm";
            this.btn_closeForm.Size = new System.Drawing.Size(43, 49);
            this.btn_closeForm.TabIndex = 1;
            this.btn_closeForm.TabStop = false;
            this.btn_closeForm.UseVisualStyleBackColor = false;
            this.btn_closeForm.Click += new System.EventHandler(this.btn_closeForm_Click);
            // 
            // lbl_userDisplay
            // 
            this.lbl_userDisplay.AutoSize = true;
            this.lbl_userDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lbl_userDisplay.Location = new System.Drawing.Point(44, 17);
            this.lbl_userDisplay.Name = "lbl_userDisplay";
            this.lbl_userDisplay.Size = new System.Drawing.Size(176, 31);
            this.lbl_userDisplay.TabIndex = 2;
            this.lbl_userDisplay.Text = "Logged in as:";
            // 
            // lbl_timeDisplay
            // 
            this.lbl_timeDisplay.AutoSize = true;
            this.lbl_timeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_timeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lbl_timeDisplay.Location = new System.Drawing.Point(1106, 17);
            this.lbl_timeDisplay.Name = "lbl_timeDisplay";
            this.lbl_timeDisplay.Size = new System.Drawing.Size(0, 31);
            this.lbl_timeDisplay.TabIndex = 3;
            // 
            // pnl_Display
            // 
            this.pnl_Display.Location = new System.Drawing.Point(397, 160);
            this.pnl_Display.Name = "pnl_Display";
            this.pnl_Display.Size = new System.Drawing.Size(1433, 855);
            this.pnl_Display.TabIndex = 4;
            // 
            // pnl_WhiteStrip
            // 
            this.pnl_WhiteStrip.Controls.Add(this.btn_closeForm);
            this.pnl_WhiteStrip.Controls.Add(this.lbl_userDisplay);
            this.pnl_WhiteStrip.Controls.Add(this.lbl_timeDisplay);
            this.pnl_WhiteStrip.Location = new System.Drawing.Point(347, 0);
            this.pnl_WhiteStrip.Name = "pnl_WhiteStrip";
            this.pnl_WhiteStrip.Size = new System.Drawing.Size(1557, 69);
            this.pnl_WhiteStrip.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.panel1.Location = new System.Drawing.Point(338, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 69);
            this.panel1.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_WhiteStrip);
            this.Controls.Add(this.pnl_Display);
            this.Controls.Add(this.ts_navigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Chapoo systeem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ts_navigation.ResumeLayout(false);
            this.ts_navigation.PerformLayout();
            this.pnl_WhiteStrip.ResumeLayout(false);
            this.pnl_WhiteStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_navigation;
        private System.Windows.Forms.ToolStripButton btn_navLogo;
        private System.Windows.Forms.ToolStripButton btn_navHome;
        private System.Windows.Forms.ToolStripButton btn_navReserveringen;
        private System.Windows.Forms.ToolStripButton btn_navBarKeuken;
        private System.Windows.Forms.ToolStripButton btn_navBestellingen;
        private System.Windows.Forms.ToolStripButton btn_navVoorraad;
        private System.Windows.Forms.Button btn_closeForm;
        private System.Windows.Forms.Label lbl_userDisplay;
        private System.Windows.Forms.Label lbl_timeDisplay;
        private System.Windows.Forms.Panel pnl_Display;
        private System.Windows.Forms.Panel pnl_WhiteStrip;
        private System.Windows.Forms.Panel panel1;
    }
}