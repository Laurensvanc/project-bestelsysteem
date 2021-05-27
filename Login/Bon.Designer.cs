namespace Login
{
    partial class Bon
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
            this.listBonView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMedewerker = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTafel = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBonView
            // 
            this.listBonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBonView.GridLines = true;
            this.listBonView.HideSelection = false;
            this.listBonView.Location = new System.Drawing.Point(12, 94);
            this.listBonView.Name = "listBonView";
            this.listBonView.Size = new System.Drawing.Size(592, 549);
            this.listBonView.TabIndex = 24;
            this.listBonView.UseCompatibleStateImageBehavior = false;
            this.listBonView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "Chapoo bon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "Geholpen door: ";
            // 
            // lblMedewerker
            // 
            this.lblMedewerker.AutoSize = true;
            this.lblMedewerker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMedewerker.Location = new System.Drawing.Point(180, 56);
            this.lblMedewerker.Name = "lblMedewerker";
            this.lblMedewerker.Size = new System.Drawing.Size(30, 26);
            this.lblMedewerker.TabIndex = 27;
            this.lblMedewerker.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(455, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tafel: ";
            // 
            // lblTafel
            // 
            this.lblTafel.AutoSize = true;
            this.lblTafel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTafel.Location = new System.Drawing.Point(556, 56);
            this.lblTafel.Name = "lblTafel";
            this.lblTafel.Size = new System.Drawing.Size(30, 26);
            this.lblTafel.TabIndex = 29;
            this.lblTafel.Text = "...";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDatum.Location = new System.Drawing.Point(455, 18);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(73, 26);
            this.lblDatum.TabIndex = 30;
            this.lblDatum.Text = "datum";
            // 
            // Bon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 655);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblTafel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMedewerker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBonView);
            this.Name = "Bon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listBonView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMedewerker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTafel;
        private System.Windows.Forms.Label lblDatum;
    }
}