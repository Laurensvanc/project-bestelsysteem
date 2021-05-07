namespace Login
{
    partial class RestaurantOverzicht
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
            this.lstReservering = new System.Windows.Forms.ListView();
            this.lstTafelStatus = new System.Windows.Forms.ListView();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnFresh = new System.Windows.Forms.Button();
            this.pnlReservering = new System.Windows.Forms.Panel();
            this.btnDeleteRes = new System.Windows.Forms.Button();
            this.btnUpdateRes = new System.Windows.Forms.Button();
            this.lblAantalPersonen = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dateTijd = new System.Windows.Forms.DateTimePicker();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.NumericAantal = new System.Windows.Forms.NumericUpDown();
            this.pnlReservering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAantal)).BeginInit();
            this.SuspendLayout();
            // 
            // lstReservering
            // 
            this.lstReservering.HideSelection = false;
            this.lstReservering.Location = new System.Drawing.Point(12, 29);
            this.lstReservering.Name = "lstReservering";
            this.lstReservering.Size = new System.Drawing.Size(395, 245);
            this.lstReservering.TabIndex = 0;
            this.lstReservering.UseCompatibleStateImageBehavior = false;
            this.lstReservering.View = System.Windows.Forms.View.Details;
            // 
            // lstTafelStatus
            // 
            this.lstTafelStatus.HideSelection = false;
            this.lstTafelStatus.Location = new System.Drawing.Point(430, 29);
            this.lstTafelStatus.Name = "lstTafelStatus";
            this.lstTafelStatus.Size = new System.Drawing.Size(358, 245);
            this.lstTafelStatus.TabIndex = 1;
            this.lstTafelStatus.UseCompatibleStateImageBehavior = false;
            this.lstTafelStatus.View = System.Windows.Forms.View.Details;
            this.lstTafelStatus.SelectedIndexChanged += new System.EventHandler(this.lstTafelStatus_SelectedIndexChanged);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(26, 359);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(44, 34);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(92, 359);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(44, 34);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnFresh
            // 
            this.btnFresh.Location = new System.Drawing.Point(161, 359);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(76, 34);
            this.btnFresh.TabIndex = 4;
            this.btnFresh.Text = "refresh";
            this.btnFresh.UseVisualStyleBackColor = true;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // pnlReservering
            // 
            this.pnlReservering.Controls.Add(this.NumericAantal);
            this.pnlReservering.Controls.Add(this.btnDeleteRes);
            this.pnlReservering.Controls.Add(this.btnUpdateRes);
            this.pnlReservering.Controls.Add(this.lblAantalPersonen);
            this.pnlReservering.Controls.Add(this.lblName);
            this.pnlReservering.Controls.Add(this.dateTijd);
            this.pnlReservering.Controls.Add(this.txtNaam);
            this.pnlReservering.Location = new System.Drawing.Point(12, 13);
            this.pnlReservering.Name = "pnlReservering";
            this.pnlReservering.Size = new System.Drawing.Size(776, 425);
            this.pnlReservering.TabIndex = 5;
            // 
            // btnDeleteRes
            // 
            this.btnDeleteRes.Location = new System.Drawing.Point(149, 267);
            this.btnDeleteRes.Name = "btnDeleteRes";
            this.btnDeleteRes.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRes.TabIndex = 7;
            this.btnDeleteRes.Text = "Verwijderen";
            this.btnDeleteRes.UseVisualStyleBackColor = true;
            this.btnDeleteRes.Click += new System.EventHandler(this.btnDeleteRes_Click);
            // 
            // btnUpdateRes
            // 
            this.btnUpdateRes.Location = new System.Drawing.Point(37, 267);
            this.btnUpdateRes.Name = "btnUpdateRes";
            this.btnUpdateRes.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRes.TabIndex = 6;
            this.btnUpdateRes.Text = "Opslaan";
            this.btnUpdateRes.UseVisualStyleBackColor = true;
            this.btnUpdateRes.Click += new System.EventHandler(this.btnUpdateRes_Click);
            // 
            // lblAantalPersonen
            // 
            this.lblAantalPersonen.AutoSize = true;
            this.lblAantalPersonen.Location = new System.Drawing.Point(39, 142);
            this.lblAantalPersonen.Name = "lblAantalPersonen";
            this.lblAantalPersonen.Size = new System.Drawing.Size(85, 13);
            this.lblAantalPersonen.TabIndex = 5;
            this.lblAantalPersonen.Text = "Aantal Personen";
            this.lblAantalPersonen.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Naam";
            // 
            // dateTijd
            // 
            this.dateTijd.Location = new System.Drawing.Point(37, 213);
            this.dateTijd.Name = "dateTijd";
            this.dateTijd.Size = new System.Drawing.Size(206, 20);
            this.dateTijd.TabIndex = 3;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(37, 101);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(146, 20);
            this.txtNaam.TabIndex = 0;
            // 
            // NumericAantal
            // 
            this.NumericAantal.Location = new System.Drawing.Point(37, 169);
            this.NumericAantal.Name = "NumericAantal";
            this.NumericAantal.Size = new System.Drawing.Size(120, 20);
            this.NumericAantal.TabIndex = 8;
            // 
            // RestaurantOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlReservering);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lstTafelStatus);
            this.Controls.Add(this.lstReservering);
            this.Name = "RestaurantOverzicht";
            this.Text = "RestaurantOverzicht";
            this.Load += new System.EventHandler(this.RestaurantOverzicht_Load);
            this.pnlReservering.ResumeLayout(false);
            this.pnlReservering.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAantal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstReservering;
        private System.Windows.Forms.ListView lstTafelStatus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.Panel pnlReservering;
        private System.Windows.Forms.Label lblAantalPersonen;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dateTijd;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Button btnDeleteRes;
        private System.Windows.Forms.Button btnUpdateRes;
        private System.Windows.Forms.NumericUpDown NumericAantal;
    }
}