
namespace Login
{
    partial class Platform
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
            this.btn_desktop = new System.Windows.Forms.Button();
            this.btn_mobiel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_desktop
            // 
            this.btn_desktop.BackColor = System.Drawing.Color.White;
            this.btn_desktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desktop.Font = new System.Drawing.Font("Roboto", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desktop.Location = new System.Drawing.Point(286, 101);
            this.btn_desktop.Name = "btn_desktop";
            this.btn_desktop.Size = new System.Drawing.Size(222, 89);
            this.btn_desktop.TabIndex = 0;
            this.btn_desktop.Text = "Desktop";
            this.btn_desktop.UseVisualStyleBackColor = false;
            this.btn_desktop.Click += new System.EventHandler(this.btn_desktop_Click);
            // 
            // btn_mobiel
            // 
            this.btn_mobiel.BackColor = System.Drawing.Color.White;
            this.btn_mobiel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mobiel.Font = new System.Drawing.Font("Roboto", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mobiel.Location = new System.Drawing.Point(286, 256);
            this.btn_mobiel.Name = "btn_mobiel";
            this.btn_mobiel.Size = new System.Drawing.Size(222, 89);
            this.btn_mobiel.TabIndex = 1;
            this.btn_mobiel.Text = "Mobiel";
            this.btn_mobiel.UseVisualStyleBackColor = false;
            this.btn_mobiel.Click += new System.EventHandler(this.btn_mobiel_Click);
            // 
            // Platform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_mobiel);
            this.Controls.Add(this.btn_desktop);
            this.Name = "Platform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_desktop;
        private System.Windows.Forms.Button btn_mobiel;
    }
}