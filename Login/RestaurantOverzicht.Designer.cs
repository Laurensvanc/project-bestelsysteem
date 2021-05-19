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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTafel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtGeboorteDatum = new System.Windows.Forms.TextBox();
            this.btnSelectKlant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTellie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lstReserveringDag = new System.Windows.Forms.ListView();
            this.NumericAantal = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteRes = new System.Windows.Forms.Button();
            this.btnUpdateRes = new System.Windows.Forms.Button();
            this.lblAantalPersonen = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dateTijd = new System.Windows.Forms.DateTimePicker();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.pnlKlantSysteem = new System.Windows.Forms.Panel();
            this.lblZoeken = new System.Windows.Forms.Label();
            this.lblKlantGeselct = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaamKlant = new System.Windows.Forms.TextBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnKlantOpslaan = new System.Windows.Forms.Button();
            this.lstKlantSysteem = new System.Windows.Forms.ListView();
            this.pnlReservering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAantal)).BeginInit();
            this.pnlKlantSysteem.SuspendLayout();
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
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.btnFresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.pnlReservering.Controls.Add(this.label7);
            this.pnlReservering.Controls.Add(this.label6);
            this.pnlReservering.Controls.Add(this.cmbTafel);
            this.pnlReservering.Controls.Add(this.label5);
            this.pnlReservering.Controls.Add(this.txtAchternaam);
            this.pnlReservering.Controls.Add(this.txtGeboorteDatum);
            this.pnlReservering.Controls.Add(this.btnSelectKlant);
            this.pnlReservering.Controls.Add(this.label2);
            this.pnlReservering.Controls.Add(this.txtTellie);
            this.pnlReservering.Controls.Add(this.label1);
            this.pnlReservering.Controls.Add(this.lblDatum);
            this.pnlReservering.Controls.Add(this.lstReserveringDag);
            this.pnlReservering.Controls.Add(this.NumericAantal);
            this.pnlReservering.Controls.Add(this.btnDeleteRes);
            this.pnlReservering.Controls.Add(this.btnUpdateRes);
            this.pnlReservering.Controls.Add(this.lblAantalPersonen);
            this.pnlReservering.Controls.Add(this.lblName);
            this.pnlReservering.Controls.Add(this.dateTijd);
            this.pnlReservering.Controls.Add(this.txtNaam);
            this.pnlReservering.Location = new System.Drawing.Point(12, 9);
            this.pnlReservering.Name = "pnlReservering";
            this.pnlReservering.Size = new System.Drawing.Size(776, 425);
            this.pnlReservering.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Capaciteit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tafel";
            // 
            // cmbTafel
            // 
            this.cmbTafel.FormattingEnabled = true;
            this.cmbTafel.Location = new System.Drawing.Point(163, 168);
            this.cmbTafel.Name = "cmbTafel";
            this.cmbTafel.Size = new System.Drawing.Size(121, 21);
            this.cmbTafel.TabIndex = 19;
            this.cmbTafel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Achternaam";
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(149, 32);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(107, 20);
            this.txtAchternaam.TabIndex = 17;
            // 
            // txtGeboorteDatum
            // 
            this.txtGeboorteDatum.Location = new System.Drawing.Point(37, 71);
            this.txtGeboorteDatum.Name = "txtGeboorteDatum";
            this.txtGeboorteDatum.Size = new System.Drawing.Size(120, 20);
            this.txtGeboorteDatum.TabIndex = 16;
            // 
            // btnSelectKlant
            // 
            this.btnSelectKlant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectKlant.Location = new System.Drawing.Point(663, 16);
            this.btnSelectKlant.Name = "btnSelectKlant";
            this.btnSelectKlant.Size = new System.Drawing.Size(99, 23);
            this.btnSelectKlant.TabIndex = 15;
            this.btnSelectKlant.Text = "Klant Systeem";
            this.btnSelectKlant.UseVisualStyleBackColor = true;
            this.btnSelectKlant.Click += new System.EventHandler(this.btnSelectKlant_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "TelefoonNummer";
            // 
            // txtTellie
            // 
            this.txtTellie.Location = new System.Drawing.Point(37, 110);
            this.txtTellie.Name = "txtTellie";
            this.txtTellie.Size = new System.Drawing.Size(120, 20);
            this.txtTellie.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "GeboorteDatum";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(308, 31);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(201, 13);
            this.lblDatum.TabIndex = 10;
            this.lblDatum.Text = "Ingeplande Reserveringen voor vandaag";
            // 
            // lstReserveringDag
            // 
            this.lstReserveringDag.HideSelection = false;
            this.lstReserveringDag.Location = new System.Drawing.Point(308, 50);
            this.lstReserveringDag.Name = "lstReserveringDag";
            this.lstReserveringDag.Size = new System.Drawing.Size(454, 293);
            this.lstReserveringDag.TabIndex = 9;
            this.lstReserveringDag.UseCompatibleStateImageBehavior = false;
            this.lstReserveringDag.View = System.Windows.Forms.View.Details;
            this.lstReserveringDag.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // NumericAantal
            // 
            this.NumericAantal.Location = new System.Drawing.Point(37, 169);
            this.NumericAantal.Name = "NumericAantal";
            this.NumericAantal.Size = new System.Drawing.Size(120, 20);
            this.NumericAantal.TabIndex = 8;
            // 
            // btnDeleteRes
            // 
            this.btnDeleteRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.btnUpdateRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.lblAantalPersonen.Location = new System.Drawing.Point(34, 153);
            this.lblAantalPersonen.Name = "lblAantalPersonen";
            this.lblAantalPersonen.Size = new System.Drawing.Size(85, 13);
            this.lblAantalPersonen.TabIndex = 5;
            this.lblAantalPersonen.Text = "Aantal Personen";
            this.lblAantalPersonen.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Voornaam";
            // 
            // dateTijd
            // 
            this.dateTijd.Location = new System.Drawing.Point(37, 213);
            this.dateTijd.Name = "dateTijd";
            this.dateTijd.Size = new System.Drawing.Size(206, 20);
            this.dateTijd.TabIndex = 3;
            this.dateTijd.ValueChanged += new System.EventHandler(this.dateTijd_ValueChanged);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(37, 32);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(106, 20);
            this.txtNaam.TabIndex = 0;
            // 
            // pnlKlantSysteem
            // 
            this.pnlKlantSysteem.Controls.Add(this.lblZoeken);
            this.pnlKlantSysteem.Controls.Add(this.lblKlantGeselct);
            this.pnlKlantSysteem.Controls.Add(this.label4);
            this.pnlKlantSysteem.Controls.Add(this.label3);
            this.pnlKlantSysteem.Controls.Add(this.txtNaamKlant);
            this.pnlKlantSysteem.Controls.Add(this.btnTerug);
            this.pnlKlantSysteem.Controls.Add(this.btnKlantOpslaan);
            this.pnlKlantSysteem.Controls.Add(this.lstKlantSysteem);
            this.pnlKlantSysteem.Location = new System.Drawing.Point(13, 9);
            this.pnlKlantSysteem.Name = "pnlKlantSysteem";
            this.pnlKlantSysteem.Size = new System.Drawing.Size(772, 421);
            this.pnlKlantSysteem.TabIndex = 16;
            // 
            // lblZoeken
            // 
            this.lblZoeken.AutoSize = true;
            this.lblZoeken.Location = new System.Drawing.Point(12, 130);
            this.lblZoeken.Name = "lblZoeken";
            this.lblZoeken.Size = new System.Drawing.Size(104, 13);
            this.lblZoeken.TabIndex = 11;
            this.lblZoeken.Text = "Zoeken op Iedereen";
            // 
            // lblKlantGeselct
            // 
            this.lblKlantGeselct.AutoSize = true;
            this.lblKlantGeselct.Location = new System.Drawing.Point(156, 392);
            this.lblKlantGeselct.Name = "lblKlantGeselct";
            this.lblKlantGeselct.Size = new System.Drawing.Size(123, 13);
            this.lblKlantGeselct.TabIndex = 10;
            this.lblKlantGeselct.Text = "Geen klant geselecteerd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zoek Persoon";
            // 
            // txtNaamKlant
            // 
            this.txtNaamKlant.Location = new System.Drawing.Point(10, 93);
            this.txtNaamKlant.Name = "txtNaamKlant";
            this.txtNaamKlant.Size = new System.Drawing.Size(100, 20);
            this.txtNaamKlant.TabIndex = 3;
            this.txtNaamKlant.TextChanged += new System.EventHandler(this.txtNaamKlant_TextChanged);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(563, 382);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 2;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnKlantOpslaan
            // 
            this.btnKlantOpslaan.Location = new System.Drawing.Point(666, 382);
            this.btnKlantOpslaan.Name = "btnKlantOpslaan";
            this.btnKlantOpslaan.Size = new System.Drawing.Size(75, 23);
            this.btnKlantOpslaan.TabIndex = 1;
            this.btnKlantOpslaan.Text = "Kiezen";
            this.btnKlantOpslaan.UseVisualStyleBackColor = true;
            this.btnKlantOpslaan.Click += new System.EventHandler(this.btnKlantOpslaan_Click);
            // 
            // lstKlantSysteem
            // 
            this.lstKlantSysteem.HideSelection = false;
            this.lstKlantSysteem.Location = new System.Drawing.Point(159, 28);
            this.lstKlantSysteem.Name = "lstKlantSysteem";
            this.lstKlantSysteem.Size = new System.Drawing.Size(582, 348);
            this.lstKlantSysteem.TabIndex = 0;
            this.lstKlantSysteem.UseCompatibleStateImageBehavior = false;
            this.lstKlantSysteem.View = System.Windows.Forms.View.Details;
            this.lstKlantSysteem.SelectedIndexChanged += new System.EventHandler(this.lstKlantSysteem_SelectedIndexChanged);
            // 
            // RestaurantOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(809, 454);
            this.Controls.Add(this.pnlKlantSysteem);
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
            this.pnlKlantSysteem.ResumeLayout(false);
            this.pnlKlantSysteem.PerformLayout();
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
        private System.Windows.Forms.ListView lstReserveringDag;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTellie;
        private System.Windows.Forms.Panel pnlKlantSysteem;
        private System.Windows.Forms.Label lblKlantGeselct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaamKlant;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnKlantOpslaan;
        private System.Windows.Forms.ListView lstKlantSysteem;
        private System.Windows.Forms.Button btnSelectKlant;
        private System.Windows.Forms.Label lblZoeken;
        private System.Windows.Forms.TextBox txtGeboorteDatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTafel;
    }
}