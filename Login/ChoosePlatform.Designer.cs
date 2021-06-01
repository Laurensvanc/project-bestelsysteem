
namespace Login
{
    partial class ChoosePlatform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosePlatform));
            this.btn_desktop = new System.Windows.Forms.Button();
            this.btn_mobiel = new System.Windows.Forms.Button();
            this.btn_closeForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_desktop
            // 
            this.btn_desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_desktop.FlatAppearance.BorderSize = 0;
            this.btn_desktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desktop.Font = new System.Drawing.Font("Roboto", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desktop.ForeColor = System.Drawing.Color.White;
            this.btn_desktop.Location = new System.Drawing.Point(-1, 69);
            this.btn_desktop.Name = "btn_desktop";
            this.btn_desktop.Size = new System.Drawing.Size(415, 410);
            this.btn_desktop.TabIndex = 0;
            this.btn_desktop.Text = "Desktop";
            this.btn_desktop.UseVisualStyleBackColor = false;
            this.btn_desktop.Click += new System.EventHandler(this.btn_desktop_Click);
            // 
            // btn_mobiel
            // 
            this.btn_mobiel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_mobiel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mobiel.Font = new System.Drawing.Font("Roboto", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mobiel.ForeColor = System.Drawing.Color.White;
            this.btn_mobiel.Location = new System.Drawing.Point(-1, 478);
            this.btn_mobiel.Name = "btn_mobiel";
            this.btn_mobiel.Size = new System.Drawing.Size(415, 410);
            this.btn_mobiel.TabIndex = 1;
            this.btn_mobiel.Text = "Mobiel";
            this.btn_mobiel.UseVisualStyleBackColor = false;
            this.btn_mobiel.Click += new System.EventHandler(this.btn_mobiel_Click);
            // 
            // btn_closeForm
            // 
            this.btn_closeForm.BackColor = System.Drawing.Color.Transparent;
            this.btn_closeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_closeForm.FlatAppearance.BorderSize = 0;
            this.btn_closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeForm.ForeColor = System.Drawing.Color.Transparent;
            this.btn_closeForm.Image = global::Login.Properties.Resources.uitknop1;
            this.btn_closeForm.Location = new System.Drawing.Point(354, 7);
            this.btn_closeForm.Margin = new System.Windows.Forms.Padding(0);
            this.btn_closeForm.Name = "btn_closeForm";
            this.btn_closeForm.Size = new System.Drawing.Size(49, 57);
            this.btn_closeForm.TabIndex = 2;
            this.btn_closeForm.TabStop = false;
            this.btn_closeForm.UseVisualStyleBackColor = false;
            this.btn_closeForm.Click += new System.EventHandler(this.btn_closeForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.chapoo_pink;
            this.pictureBox1.Location = new System.Drawing.Point(145, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Platform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 887);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_closeForm);
            this.Controls.Add(this.btn_mobiel);
            this.Controls.Add(this.btn_desktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Platform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_desktop;
        private System.Windows.Forms.Button btn_mobiel;
        private System.Windows.Forms.Button btn_closeForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}