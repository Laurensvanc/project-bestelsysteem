
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.wwtxt = new System.Windows.Forms.TextBox();
            this.wwlbl = new System.Windows.Forms.Label();
            this.inlogbtn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inlognaam";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(86, 64);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(176, 20);
            this.usertxt.TabIndex = 1;
            // 
            // wwtxt
            // 
            this.wwtxt.Location = new System.Drawing.Point(86, 119);
            this.wwtxt.Name = "wwtxt";
            this.wwtxt.Size = new System.Drawing.Size(176, 20);
            this.wwtxt.TabIndex = 2;
            this.wwtxt.UseSystemPasswordChar = true;
            // 
            // wwlbl
            // 
            this.wwlbl.AutoSize = true;
            this.wwlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wwlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wwlbl.Location = new System.Drawing.Point(86, 100);
            this.wwlbl.Name = "wwlbl";
            this.wwlbl.Size = new System.Drawing.Size(89, 16);
            this.wwlbl.TabIndex = 3;
            this.wwlbl.Text = "wachtwoord";
            // 
            // inlogbtn
            // 
            this.inlogbtn.Location = new System.Drawing.Point(86, 157);
            this.inlogbtn.Name = "inlogbtn";
            this.inlogbtn.Size = new System.Drawing.Size(176, 23);
            this.inlogbtn.TabIndex = 4;
            this.inlogbtn.Text = "Inloggen";
            this.inlogbtn.UseVisualStyleBackColor = true;
            this.inlogbtn.Click += new System.EventHandler(this.inlogbtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(145)))));
            this.panel1.Location = new System.Drawing.Point(-15, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 32);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(145)))));
            this.panel2.Location = new System.Drawing.Point(-15, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 33);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(295, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(346, 241);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inlogbtn);
            this.Controls.Add(this.wwlbl);
            this.Controls.Add(this.wwtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox wwtxt;
        private System.Windows.Forms.Label wwlbl;
        private System.Windows.Forms.Button inlogbtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}