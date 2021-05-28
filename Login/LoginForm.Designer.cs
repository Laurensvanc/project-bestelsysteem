
namespace Login
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.wwtxt = new System.Windows.Forms.TextBox();
            this.wwlbl = new System.Windows.Forms.Label();
            this.inlogbtn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
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
            this.wwlbl.Size = new System.Drawing.Size(89, 16);
            this.wwlbl.TabIndex = 3;
            this.wwlbl.Text = "wachtwoord";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(153, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wachtwoord vergeten";
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
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}