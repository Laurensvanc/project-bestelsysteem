namespace Login
{
    partial class MobileLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobileLogin));
            this.lbl_gebruikersNaam = new System.Windows.Forms.Label();
            this.txb_gebruikersNaam = new System.Windows.Forms.TextBox();
            this.txb_wachtwoord = new System.Windows.Forms.TextBox();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.lbl_wachtwoordReset = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.wwresetpnl = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.resetbtn = new System.Windows.Forms.Label();
            this.herhalingwwtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newwwtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.secrettxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user2txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.wwresetpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_gebruikersNaam
            // 
            this.lbl_gebruikersNaam.AutoSize = true;
            this.lbl_gebruikersNaam.Font = new System.Drawing.Font("Roboto", 24F);
            this.lbl_gebruikersNaam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.lbl_gebruikersNaam.Location = new System.Drawing.Point(25, 372);
            this.lbl_gebruikersNaam.Name = "lbl_gebruikersNaam";
            this.lbl_gebruikersNaam.Size = new System.Drawing.Size(252, 38);
            this.lbl_gebruikersNaam.TabIndex = 1;
            this.lbl_gebruikersNaam.Text = "Gebruikersnaam";
            // 
            // txb_gebruikersNaam
            // 
            this.txb_gebruikersNaam.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_gebruikersNaam.Location = new System.Drawing.Point(32, 414);
            this.txb_gebruikersNaam.Name = "txb_gebruikersNaam";
            this.txb_gebruikersNaam.Size = new System.Drawing.Size(323, 36);
            this.txb_gebruikersNaam.TabIndex = 2;
            // 
            // txb_wachtwoord
            // 
            this.txb_wachtwoord.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_wachtwoord.Location = new System.Drawing.Point(32, 527);
            this.txb_wachtwoord.Name = "txb_wachtwoord";
            this.txb_wachtwoord.Size = new System.Drawing.Size(323, 36);
            this.txb_wachtwoord.TabIndex = 4;
            this.txb_wachtwoord.UseSystemPasswordChar = true;
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Font = new System.Drawing.Font("Roboto", 24F);
            this.lbl_wachtwoord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.lbl_wachtwoord.Location = new System.Drawing.Point(25, 485);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(195, 38);
            this.lbl_wachtwoord.TabIndex = 3;
            this.lbl_wachtwoord.Text = "Wachtwoord";
            // 
            // lbl_wachtwoordReset
            // 
            this.lbl_wachtwoordReset.AutoSize = true;
            this.lbl_wachtwoordReset.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wachtwoordReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(61)))), ((int)(((byte)(102)))));
            this.lbl_wachtwoordReset.Location = new System.Drawing.Point(34, 829);
            this.lbl_wachtwoordReset.Name = "lbl_wachtwoordReset";
            this.lbl_wachtwoordReset.Size = new System.Drawing.Size(342, 38);
            this.lbl_wachtwoordReset.TabIndex = 6;
            this.lbl_wachtwoordReset.Text = "Wachtwoord vergeten?";
            this.lbl_wachtwoordReset.Click += new System.EventHandler(this.lbl_wachtwoordReset_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.White;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.ForeColor = System.Drawing.Color.Transparent;
            this.btn_return.Image = global::Login.Properties.Resources.arrow_left_pink;
            this.btn_return.Location = new System.Drawing.Point(32, 23);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(60, 60);
            this.btn_return.TabIndex = 7;
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.ForeColor = System.Drawing.Color.Transparent;
            this.btn_continue.Image = global::Login.Properties.Resources.arrow_right;
            this.btn_continue.Location = new System.Drawing.Point(169, 687);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(60, 60);
            this.btn_continue.TabIndex = 5;
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_Logo.Image = global::Login.Properties.Resources.chapoo_pink;
            this.pb_Logo.Location = new System.Drawing.Point(32, 127);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(344, 199);
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // wwresetpnl
            // 
            this.wwresetpnl.Controls.Add(this.label6);
            this.wwresetpnl.Controls.Add(this.resetbtn);
            this.wwresetpnl.Controls.Add(this.herhalingwwtxt);
            this.wwresetpnl.Controls.Add(this.label4);
            this.wwresetpnl.Controls.Add(this.newwwtxt);
            this.wwresetpnl.Controls.Add(this.label3);
            this.wwresetpnl.Controls.Add(this.secrettxtbox);
            this.wwresetpnl.Controls.Add(this.label2);
            this.wwresetpnl.Controls.Add(this.user2txt);
            this.wwresetpnl.Controls.Add(this.label1);
            this.wwresetpnl.Location = new System.Drawing.Point(0, 317);
            this.wwresetpnl.Name = "wwresetpnl";
            this.wwresetpnl.Size = new System.Drawing.Size(412, 570);
            this.wwresetpnl.TabIndex = 8;
            this.wwresetpnl.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 24F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.label6.Location = new System.Drawing.Point(65, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Opnieuw inloggen";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.AutoSize = true;
            this.resetbtn.Font = new System.Drawing.Font("Roboto", 24F);
            this.resetbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.resetbtn.Location = new System.Drawing.Point(45, 418);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(320, 38);
            this.resetbtn.TabIndex = 11;
            this.resetbtn.Text = "Wachtwoord resetten";
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // herhalingwwtxt
            // 
            this.herhalingwwtxt.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.herhalingwwtxt.Location = new System.Drawing.Point(32, 301);
            this.herhalingwwtxt.Name = "herhalingwwtxt";
            this.herhalingwwtxt.Size = new System.Drawing.Size(323, 36);
            this.herhalingwwtxt.TabIndex = 10;
            this.herhalingwwtxt.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 24F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.label4.Location = new System.Drawing.Point(25, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "herhaal wachtwoord";
            // 
            // newwwtxt
            // 
            this.newwwtxt.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newwwtxt.Location = new System.Drawing.Point(32, 220);
            this.newwwtxt.Name = "newwwtxt";
            this.newwwtxt.Size = new System.Drawing.Size(323, 36);
            this.newwwtxt.TabIndex = 8;
            this.newwwtxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 24F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.label3.Location = new System.Drawing.Point(25, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "nieuwe wachtwoord";
            // 
            // secrettxtbox
            // 
            this.secrettxtbox.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secrettxtbox.Location = new System.Drawing.Point(32, 139);
            this.secrettxtbox.Name = "secrettxtbox";
            this.secrettxtbox.Size = new System.Drawing.Size(323, 36);
            this.secrettxtbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 24F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wat is uw lievelingsdier?";
            // 
            // user2txt
            // 
            this.user2txt.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user2txt.Location = new System.Drawing.Point(32, 53);
            this.user2txt.Name = "user2txt";
            this.user2txt.Size = new System.Drawing.Size(323, 36);
            this.user2txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gebruikersnaam";
            // 
            // MobileLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 887);
            this.Controls.Add(this.wwresetpnl);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lbl_wachtwoordReset);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.txb_wachtwoord);
            this.Controls.Add(this.lbl_wachtwoord);
            this.Controls.Add(this.txb_gebruikersNaam);
            this.Controls.Add(this.lbl_gebruikersNaam);
            this.Controls.Add(this.pb_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MobileLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapoo Login";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.wwresetpnl.ResumeLayout(false);
            this.wwresetpnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lbl_gebruikersNaam;
        private System.Windows.Forms.TextBox txb_gebruikersNaam;
        private System.Windows.Forms.TextBox txb_wachtwoord;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Label lbl_wachtwoordReset;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Panel wwresetpnl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label resetbtn;
        private System.Windows.Forms.TextBox herhalingwwtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newwwtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox secrettxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user2txt;
        private System.Windows.Forms.Label label1;
    }
}