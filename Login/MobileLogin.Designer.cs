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
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
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
            // MobileLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 887);
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
    }
}