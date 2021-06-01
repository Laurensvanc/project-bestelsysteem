
namespace Login
{
    partial class DesktopHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopHome));
            this.lbl_userDisplay = new System.Windows.Forms.Label();
            this.lbl_timeDisplay = new System.Windows.Forms.Label();
            this.pnl_Display = new System.Windows.Forms.Panel();
            this.pnl_WhiteStrip = new System.Windows.Forms.Panel();
            this.btn_closeForm = new System.Windows.Forms.Button();
            this.pnl_PinkStrip = new System.Windows.Forms.Panel();
            this.pnl_LogoutBorder = new System.Windows.Forms.Panel();
            this.pnl_Logout = new System.Windows.Forms.Panel();
            this.btn_Afsluiten = new System.Windows.Forms.Button();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.ms_navigation = new System.Windows.Forms.MenuStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsm_overzicht = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_bestellen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_afrekenen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_barKeuken = new System.Windows.Forms.ToolStripMenuItem();
            this.administratieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_account = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_voorraad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pnl_WhiteStrip.SuspendLayout();
            this.pnl_LogoutBorder.SuspendLayout();
            this.pnl_Logout.SuspendLayout();
            this.ms_navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_userDisplay
            // 
            this.lbl_userDisplay.AutoSize = true;
            this.lbl_userDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userDisplay.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lbl_userDisplay.Location = new System.Drawing.Point(32, 19);
            this.lbl_userDisplay.Name = "lbl_userDisplay";
            this.lbl_userDisplay.Size = new System.Drawing.Size(176, 33);
            this.lbl_userDisplay.TabIndex = 2;
            this.lbl_userDisplay.Text = "Logged in as:";
            // 
            // lbl_timeDisplay
            // 
            this.lbl_timeDisplay.AutoSize = true;
            this.lbl_timeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_timeDisplay.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lbl_timeDisplay.Location = new System.Drawing.Point(1091, 19);
            this.lbl_timeDisplay.Name = "lbl_timeDisplay";
            this.lbl_timeDisplay.Size = new System.Drawing.Size(0, 33);
            this.lbl_timeDisplay.TabIndex = 3;
            // 
            // pnl_Display
            // 
            this.pnl_Display.Location = new System.Drawing.Point(344, 138);
            this.pnl_Display.Name = "pnl_Display";
            this.pnl_Display.Size = new System.Drawing.Size(1576, 942);
            this.pnl_Display.TabIndex = 4;
            // 
            // pnl_WhiteStrip
            // 
            this.pnl_WhiteStrip.Controls.Add(this.lbl_username);
            this.pnl_WhiteStrip.Controls.Add(this.btn_closeForm);
            this.pnl_WhiteStrip.Controls.Add(this.lbl_userDisplay);
            this.pnl_WhiteStrip.Controls.Add(this.lbl_timeDisplay);
            this.pnl_WhiteStrip.Location = new System.Drawing.Point(343, 0);
            this.pnl_WhiteStrip.Name = "pnl_WhiteStrip";
            this.pnl_WhiteStrip.Size = new System.Drawing.Size(1577, 69);
            this.pnl_WhiteStrip.TabIndex = 5;
            // 
            // btn_closeForm
            // 
            this.btn_closeForm.BackColor = System.Drawing.Color.Transparent;
            this.btn_closeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_closeForm.FlatAppearance.BorderSize = 0;
            this.btn_closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeForm.ForeColor = System.Drawing.Color.Transparent;
            this.btn_closeForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_closeForm.Image")));
            this.btn_closeForm.Location = new System.Drawing.Point(1519, 5);
            this.btn_closeForm.Margin = new System.Windows.Forms.Padding(0);
            this.btn_closeForm.Name = "btn_closeForm";
            this.btn_closeForm.Size = new System.Drawing.Size(49, 57);
            this.btn_closeForm.TabIndex = 1;
            this.btn_closeForm.TabStop = false;
            this.btn_closeForm.UseVisualStyleBackColor = false;
            this.btn_closeForm.Click += new System.EventHandler(this.btn_closeForm_Click);
            // 
            // pnl_PinkStrip
            // 
            this.pnl_PinkStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.pnl_PinkStrip.Location = new System.Drawing.Point(302, 69);
            this.pnl_PinkStrip.Name = "pnl_PinkStrip";
            this.pnl_PinkStrip.Size = new System.Drawing.Size(1636, 69);
            this.pnl_PinkStrip.TabIndex = 6;
            // 
            // pnl_LogoutBorder
            // 
            this.pnl_LogoutBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.pnl_LogoutBorder.Controls.Add(this.pnl_Logout);
            this.pnl_LogoutBorder.Location = new System.Drawing.Point(1782, 69);
            this.pnl_LogoutBorder.Name = "pnl_LogoutBorder";
            this.pnl_LogoutBorder.Size = new System.Drawing.Size(138, 120);
            this.pnl_LogoutBorder.TabIndex = 4;
            this.pnl_LogoutBorder.Visible = false;
            // 
            // pnl_Logout
            // 
            this.pnl_Logout.BackColor = System.Drawing.Color.White;
            this.pnl_Logout.Controls.Add(this.btn_Afsluiten);
            this.pnl_Logout.Controls.Add(this.btn_Uitloggen);
            this.pnl_Logout.Location = new System.Drawing.Point(2, 2);
            this.pnl_Logout.Name = "pnl_Logout";
            this.pnl_Logout.Size = new System.Drawing.Size(134, 116);
            this.pnl_Logout.TabIndex = 5;
            // 
            // btn_Afsluiten
            // 
            this.btn_Afsluiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Afsluiten.FlatAppearance.BorderSize = 0;
            this.btn_Afsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Afsluiten.Font = new System.Drawing.Font("Roboto", 18F);
            this.btn_Afsluiten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_Afsluiten.Location = new System.Drawing.Point(0, 58);
            this.btn_Afsluiten.Name = "btn_Afsluiten";
            this.btn_Afsluiten.Size = new System.Drawing.Size(134, 58);
            this.btn_Afsluiten.TabIndex = 1;
            this.btn_Afsluiten.TabStop = false;
            this.btn_Afsluiten.Text = "Afsluiten";
            this.btn_Afsluiten.UseVisualStyleBackColor = true;
            this.btn_Afsluiten.Click += new System.EventHandler(this.btn_Afsluiten_Click);
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Uitloggen.FlatAppearance.BorderSize = 0;
            this.btn_Uitloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Uitloggen.Font = new System.Drawing.Font("Roboto", 18F);
            this.btn_Uitloggen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_Uitloggen.Location = new System.Drawing.Point(0, 0);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(134, 58);
            this.btn_Uitloggen.TabIndex = 1;
            this.btn_Uitloggen.TabStop = false;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            this.btn_Uitloggen.Click += new System.EventHandler(this.btn_Uitloggen_Click);
            // 
            // ms_navigation
            // 
            this.ms_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.ms_navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.ms_navigation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_navigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.tsm_overzicht,
            this.tsm_bestellen,
            this.tsm_afrekenen,
            this.tsm_barKeuken,
            this.administratieToolStripMenuItem});
            this.ms_navigation.Location = new System.Drawing.Point(0, 0);
            this.ms_navigation.Name = "ms_navigation";
            this.ms_navigation.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.ms_navigation.Size = new System.Drawing.Size(348, 884);
            this.ms_navigation.TabIndex = 8;
            this.ms_navigation.Text = "menuStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackgroundImage = global::Login.Properties.Resources.chapoo_white;
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(344, 199);
            this.toolStripButton2.Text = "Logo";
            // 
            // tsm_overzicht
            // 
            this.tsm_overzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(78)))), ((int)(((byte)(124)))));
            this.tsm_overzicht.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_overzicht.ForeColor = System.Drawing.Color.White;
            this.tsm_overzicht.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsm_overzicht.Name = "tsm_overzicht";
            this.tsm_overzicht.Size = new System.Drawing.Size(339, 69);
            this.tsm_overzicht.Text = "Overzicht";
            this.tsm_overzicht.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsm_overzicht.Click += new System.EventHandler(this.tsm_overzicht_Click);
            // 
            // tsm_bestellen
            // 
            this.tsm_bestellen.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_bestellen.ForeColor = System.Drawing.Color.White;
            this.tsm_bestellen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsm_bestellen.Name = "tsm_bestellen";
            this.tsm_bestellen.Size = new System.Drawing.Size(339, 69);
            this.tsm_bestellen.Text = "Bestellen";
            this.tsm_bestellen.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsm_bestellen.Click += new System.EventHandler(this.tsm_bestellen_Click);
            // 
            // tsm_afrekenen
            // 
            this.tsm_afrekenen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(78)))), ((int)(((byte)(124)))));
            this.tsm_afrekenen.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_afrekenen.ForeColor = System.Drawing.Color.White;
            this.tsm_afrekenen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsm_afrekenen.Name = "tsm_afrekenen";
            this.tsm_afrekenen.Size = new System.Drawing.Size(339, 69);
            this.tsm_afrekenen.Text = "Afrekenen";
            this.tsm_afrekenen.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsm_afrekenen.Click += new System.EventHandler(this.tsm_afrekenen_Click);
            // 
            // tsm_barKeuken
            // 
            this.tsm_barKeuken.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_barKeuken.ForeColor = System.Drawing.Color.White;
            this.tsm_barKeuken.Name = "tsm_barKeuken";
            this.tsm_barKeuken.Size = new System.Drawing.Size(339, 69);
            this.tsm_barKeuken.Text = "Bar/Keuken";
            this.tsm_barKeuken.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsm_barKeuken.Click += new System.EventHandler(this.tsm_barKeuken_Click);
            // 
            // administratieToolStripMenuItem
            // 
            this.administratieToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(78)))), ((int)(((byte)(124)))));
            this.administratieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_account,
            this.tsm_voorraad,
            this.menuToolStripMenuItem});
            this.administratieToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administratieToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.administratieToolStripMenuItem.Name = "administratieToolStripMenuItem";
            this.administratieToolStripMenuItem.Size = new System.Drawing.Size(339, 69);
            this.administratieToolStripMenuItem.Text = "Administratie";
            this.administratieToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // tsm_account
            // 
            this.tsm_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.tsm_account.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_account.ForeColor = System.Drawing.Color.White;
            this.tsm_account.Name = "tsm_account";
            this.tsm_account.Size = new System.Drawing.Size(307, 62);
            this.tsm_account.Text = "Account";
            this.tsm_account.Click += new System.EventHandler(this.tsm_account_Click);
            // 
            // tsm_voorraad
            // 
            this.tsm_voorraad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.tsm_voorraad.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_voorraad.ForeColor = System.Drawing.Color.White;
            this.tsm_voorraad.Name = "tsm_voorraad";
            this.tsm_voorraad.Size = new System.Drawing.Size(307, 62);
            this.tsm_voorraad.Text = "Voorraad";
            this.tsm_voorraad.Click += new System.EventHandler(this.tsm_voorraad_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 36F);
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(307, 62);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lbl_username.Location = new System.Drawing.Point(202, 19);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(61, 33);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "test";
            // 
            // DesktopHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1456, 884);
            this.Controls.Add(this.pnl_LogoutBorder);
            this.Controls.Add(this.pnl_WhiteStrip);
            this.Controls.Add(this.pnl_Display);
            this.Controls.Add(this.ms_navigation);
            this.Controls.Add(this.pnl_PinkStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_navigation;
            this.Name = "DesktopHome";
            this.Text = "Chapoo systeem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_WhiteStrip.ResumeLayout(false);
            this.pnl_WhiteStrip.PerformLayout();
            this.pnl_LogoutBorder.ResumeLayout(false);
            this.pnl_Logout.ResumeLayout(false);
            this.ms_navigation.ResumeLayout(false);
            this.ms_navigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_closeForm;
        private System.Windows.Forms.Label lbl_userDisplay;
        private System.Windows.Forms.Label lbl_timeDisplay;
        private System.Windows.Forms.Panel pnl_Display;
        private System.Windows.Forms.Panel pnl_WhiteStrip;
        private System.Windows.Forms.Panel pnl_PinkStrip;
        private System.Windows.Forms.Panel pnl_LogoutBorder;
        private System.Windows.Forms.Panel pnl_Logout;
        private System.Windows.Forms.Button btn_Afsluiten;
        private System.Windows.Forms.Button btn_Uitloggen;
        private System.Windows.Forms.MenuStrip ms_navigation;
        private System.Windows.Forms.ToolStripMenuItem tsm_overzicht;
        private System.Windows.Forms.ToolStripMenuItem tsm_bestellen;
        private System.Windows.Forms.ToolStripMenuItem tsm_afrekenen;
        private System.Windows.Forms.ToolStripMenuItem tsm_barKeuken;
        private System.Windows.Forms.ToolStripMenuItem administratieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_account;
        private System.Windows.Forms.ToolStripMenuItem tsm_voorraad;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label lbl_username;
    }
}