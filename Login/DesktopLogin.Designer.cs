
namespace Login
{
    partial class DesktopLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.wwtxt = new System.Windows.Forms.TextBox();
            this.wwlbl = new System.Windows.Forms.Label();
            this.inlogbtn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlpassword = new System.Windows.Forms.Panel();
            this.resetbtn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.user2txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.herhalingwwtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newwwtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.secrettxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.pnlpassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(98, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inlognaam";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(101, 265);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(176, 20);
            this.usertxt.TabIndex = 1;
            // 
            // wwtxt
            // 
            this.wwtxt.Location = new System.Drawing.Point(101, 319);
            this.wwtxt.Name = "wwtxt";
            this.wwtxt.Size = new System.Drawing.Size(176, 20);
            this.wwtxt.TabIndex = 2;
            this.wwtxt.UseSystemPasswordChar = true;
            this.wwtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wwtxt_KeyDown);
            // 
            // wwlbl
            // 
            this.wwlbl.AutoSize = true;
            this.wwlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wwlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.wwlbl.Location = new System.Drawing.Point(98, 300);
            this.wwlbl.Name = "wwlbl";
            this.wwlbl.Size = new System.Drawing.Size(93, 16);
            this.wwlbl.TabIndex = 3;
            this.wwlbl.Text = "Wachtwoord";
            // 
            // inlogbtn
            // 
            this.inlogbtn.BackColor = System.Drawing.Color.Transparent;
            this.inlogbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inlogbtn.Location = new System.Drawing.Point(150, 345);
            this.inlogbtn.Name = "inlogbtn";
            this.inlogbtn.Size = new System.Drawing.Size(92, 44);
            this.inlogbtn.TabIndex = 4;
            this.inlogbtn.Text = "Inloggen";
            this.inlogbtn.UseVisualStyleBackColor = false;
            this.inlogbtn.Click += new System.EventHandler(this.Inlogbtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.panel2.Controls.Add(this.btn_return);
            this.panel2.Controls.Add(this.pnlpassword);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.usertxt);
            this.panel2.Controls.Add(this.wwlbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.inlogbtn);
            this.panel2.Controls.Add(this.wwtxt);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-15, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 544);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlpassword
            // 
            this.pnlpassword.Controls.Add(this.resetbtn);
            this.pnlpassword.Controls.Add(this.label7);
            this.pnlpassword.Controls.Add(this.user2txt);
            this.pnlpassword.Controls.Add(this.label6);
            this.pnlpassword.Controls.Add(this.herhalingwwtxt);
            this.pnlpassword.Controls.Add(this.label5);
            this.pnlpassword.Controls.Add(this.newwwtxt);
            this.pnlpassword.Controls.Add(this.label4);
            this.pnlpassword.Controls.Add(this.secrettxtbox);
            this.pnlpassword.Controls.Add(this.label3);
            this.pnlpassword.Location = new System.Drawing.Point(15, 194);
            this.pnlpassword.Name = "pnlpassword";
            this.pnlpassword.Size = new System.Drawing.Size(371, 272);
            this.pnlpassword.TabIndex = 6;
            this.pnlpassword.Visible = false;
            // 
            // resetbtn
            // 
            this.resetbtn.AutoSize = true;
            this.resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.resetbtn.Location = new System.Drawing.Point(104, 198);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(134, 16);
            this.resetbtn.TabIndex = 13;
            this.resetbtn.Text = "Reset wachtwoord";
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(83, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Inlognaam";
            // 
            // user2txt
            // 
            this.user2txt.Location = new System.Drawing.Point(86, 34);
            this.user2txt.Name = "user2txt";
            this.user2txt.Size = new System.Drawing.Size(179, 20);
            this.user2txt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(86, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Herhaal wachtwoord";
            // 
            // herhalingwwtxt
            // 
            this.herhalingwwtxt.Location = new System.Drawing.Point(86, 163);
            this.herhalingwwtxt.Name = "herhalingwwtxt";
            this.herhalingwwtxt.Size = new System.Drawing.Size(185, 20);
            this.herhalingwwtxt.TabIndex = 10;
            this.herhalingwwtxt.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(86, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nieuwe wachtwoord";
            // 
            // newwwtxt
            // 
            this.newwwtxt.Location = new System.Drawing.Point(86, 117);
            this.newwwtxt.Name = "newwwtxt";
            this.newwwtxt.Size = new System.Drawing.Size(185, 20);
            this.newwwtxt.TabIndex = 8;
            this.newwwtxt.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(104, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Opnieuw inloggen";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // secrettxtbox
            // 
            this.secrettxtbox.Location = new System.Drawing.Point(86, 75);
            this.secrettxtbox.Name = "secrettxtbox";
            this.secrettxtbox.Size = new System.Drawing.Size(185, 20);
            this.secrettxtbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(83, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Wat is je favoriete huisdier?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(119, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wachtwoord vergeten";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.White;
            this.btn_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return.FlatAppearance.BorderSize = 0;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.ForeColor = System.Drawing.Color.Transparent;
            this.btn_return.Image = global::Login.Properties.Resources.return_btn;
            this.btn_return.Location = new System.Drawing.Point(27, 14);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(48, 43);
            this.btn_return.TabIndex = 14;
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.chapoo_white;
            this.pictureBox1.Location = new System.Drawing.Point(69, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(372, 464);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlpassword.ResumeLayout(false);
            this.pnlpassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox wwtxt;
        private System.Windows.Forms.Label wwlbl;
        private System.Windows.Forms.Button inlogbtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlpassword;
        private System.Windows.Forms.Label resetbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox user2txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox herhalingwwtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newwwtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox secrettxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_return;
    }
}