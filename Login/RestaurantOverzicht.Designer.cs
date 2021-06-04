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
            this.pnlKlantSysteem = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstKlantSysteem = new System.Windows.Forms.ListView();
            this.lblKlantSysteem = new System.Windows.Forms.Label();
            this.lblZoeken = new System.Windows.Forms.Label();
            this.lblKlantGeselct = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaamKlant = new System.Windows.Forms.TextBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnKlantOpslaan = new System.Windows.Forms.Button();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lstReservering = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lstTafelStatus = new System.Windows.Forms.ListView();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnFresh = new System.Windows.Forms.Button();
            this.pnl_overzicht = new System.Windows.Forms.Panel();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.dateTijd = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAantalPersonen = new System.Windows.Forms.Label();
            this.btnUpdateRes = new System.Windows.Forms.Button();
            this.btnDeleteRes = new System.Windows.Forms.Button();
            this.NumericAantal = new System.Windows.Forms.NumericUpDown();
            this.lstReserveringDag = new System.Windows.Forms.ListView();
            this.lblDatum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTellie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTafel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.geboorteDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlReservering = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSelectKlant = new System.Windows.Forms.Button();
            this.pnlKlantSysteem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_overzicht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAantal)).BeginInit();
            this.pnlReservering.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKlantSysteem
            // 
            this.pnlKlantSysteem.Controls.Add(this.panel1);
            this.pnlKlantSysteem.Controls.Add(this.lblZoeken);
            this.pnlKlantSysteem.Controls.Add(this.lblKlantGeselct);
            this.pnlKlantSysteem.Controls.Add(this.label4);
            this.pnlKlantSysteem.Controls.Add(this.label3);
            this.pnlKlantSysteem.Controls.Add(this.txtNaamKlant);
            this.pnlKlantSysteem.Controls.Add(this.btnTerug);
            this.pnlKlantSysteem.Controls.Add(this.btnKlantOpslaan);
            this.pnlKlantSysteem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKlantSysteem.Location = new System.Drawing.Point(0, 0);
            this.pnlKlantSysteem.Name = "pnlKlantSysteem";
            this.pnlKlantSysteem.Size = new System.Drawing.Size(1576, 942);
            this.pnlKlantSysteem.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.lstKlantSysteem);
            this.panel1.Controls.Add(this.lblKlantSysteem);
            this.panel1.Location = new System.Drawing.Point(279, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 640);
            this.panel1.TabIndex = 31;
            // 
            // lstKlantSysteem
            // 
            this.lstKlantSysteem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstKlantSysteem.HideSelection = false;
            this.lstKlantSysteem.Location = new System.Drawing.Point(3, 65);
            this.lstKlantSysteem.Name = "lstKlantSysteem";
            this.lstKlantSysteem.Size = new System.Drawing.Size(995, 572);
            this.lstKlantSysteem.TabIndex = 0;
            this.lstKlantSysteem.UseCompatibleStateImageBehavior = false;
            this.lstKlantSysteem.View = System.Windows.Forms.View.Details;
            this.lstKlantSysteem.SelectedIndexChanged += new System.EventHandler(this.lstKlantSysteem_SelectedIndexChanged);
            // 
            // lblKlantSysteem
            // 
            this.lblKlantSysteem.AutoSize = true;
            this.lblKlantSysteem.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlantSysteem.ForeColor = System.Drawing.Color.White;
            this.lblKlantSysteem.Location = new System.Drawing.Point(4, 11);
            this.lblKlantSysteem.Name = "lblKlantSysteem";
            this.lblKlantSysteem.Size = new System.Drawing.Size(276, 46);
            this.lblKlantSysteem.TabIndex = 12;
            this.lblKlantSysteem.Text = "Klant Systeem";
            // 
            // lblZoeken
            // 
            this.lblZoeken.AutoSize = true;
            this.lblZoeken.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoeken.Location = new System.Drawing.Point(25, 380);
            this.lblZoeken.Name = "lblZoeken";
            this.lblZoeken.Size = new System.Drawing.Size(197, 25);
            this.lblZoeken.TabIndex = 11;
            this.lblZoeken.Text = "Zoeken op Iedereen";
            // 
            // lblKlantGeselct
            // 
            this.lblKlantGeselct.AutoSize = true;
            this.lblKlantGeselct.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlantGeselct.Location = new System.Drawing.Point(278, 670);
            this.lblKlantGeselct.Name = "lblKlantGeselct";
            this.lblKlantGeselct.Size = new System.Drawing.Size(213, 23);
            this.lblKlantGeselct.TabIndex = 10;
            this.lblKlantGeselct.Text = "Geen klant geselecteerd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zoek Persoon";
            // 
            // txtNaamKlant
            // 
            this.txtNaamKlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaamKlant.Location = new System.Drawing.Point(30, 343);
            this.txtNaamKlant.Name = "txtNaamKlant";
            this.txtNaamKlant.Size = new System.Drawing.Size(181, 31);
            this.txtNaamKlant.TabIndex = 3;
            this.txtNaamKlant.TextChanged += new System.EventHandler(this.txtNaamKlant_TextChanged);
            // 
            // btnTerug
            // 
            this.btnTerug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btnTerug.Font = new System.Drawing.Font("Roboto", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.ForeColor = System.Drawing.Color.White;
            this.btnTerug.Location = new System.Drawing.Point(270, 705);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(221, 91);
            this.btnTerug.TabIndex = 2;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = false;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnKlantOpslaan
            // 
            this.btnKlantOpslaan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btnKlantOpslaan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btnKlantOpslaan.FlatAppearance.BorderSize = 0;
            this.btnKlantOpslaan.Font = new System.Drawing.Font("Roboto", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlantOpslaan.ForeColor = System.Drawing.Color.White;
            this.btnKlantOpslaan.Location = new System.Drawing.Point(1039, 703);
            this.btnKlantOpslaan.Name = "btnKlantOpslaan";
            this.btnKlantOpslaan.Size = new System.Drawing.Size(235, 93);
            this.btnKlantOpslaan.TabIndex = 1;
            this.btnKlantOpslaan.Text = "Selecteren";
            this.btnKlantOpslaan.UseVisualStyleBackColor = false;
            this.btnKlantOpslaan.Click += new System.EventHandler(this.btnKlantOpslaan_Click);
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.panel_Header.Controls.Add(this.lstReservering);
            this.panel_Header.Controls.Add(this.label11);
            this.panel_Header.Location = new System.Drawing.Point(15, 12);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1098, 737);
            this.panel_Header.TabIndex = 30;
            // 
            // lstReservering
            // 
            this.lstReservering.Font = new System.Drawing.Font("Roboto", 17F);
            this.lstReservering.HideSelection = false;
            this.lstReservering.Location = new System.Drawing.Point(3, 55);
            this.lstReservering.Name = "lstReservering";
            this.lstReservering.Size = new System.Drawing.Size(1092, 679);
            this.lstReservering.TabIndex = 0;
            this.lstReservering.UseCompatibleStateImageBehavior = false;
            this.lstReservering.View = System.Windows.Forms.View.Details;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 38);
            this.label11.TabIndex = 27;
            this.label11.Text = "Reserveringen";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lstTafelStatus);
            this.panel2.Location = new System.Drawing.Point(1119, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 737);
            this.panel2.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 24F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 38);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tafel Status";
            // 
            // lstTafelStatus
            // 
            this.lstTafelStatus.Font = new System.Drawing.Font("Roboto", 17F);
            this.lstTafelStatus.HideSelection = false;
            this.lstTafelStatus.Location = new System.Drawing.Point(3, 55);
            this.lstTafelStatus.Name = "lstTafelStatus";
            this.lstTafelStatus.Size = new System.Drawing.Size(438, 679);
            this.lstTafelStatus.TabIndex = 1;
            this.lstTafelStatus.UseCompatibleStateImageBehavior = false;
            this.lstTafelStatus.View = System.Windows.Forms.View.Details;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Roboto", 32F);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(502, 781);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(239, 114);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "Verwijder";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Roboto", 32F);
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(40, 781);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(429, 114);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "Maak Reservering";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnFresh
            // 
            this.btnFresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btnFresh.FlatAppearance.BorderSize = 0;
            this.btnFresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFresh.Font = new System.Drawing.Font("Roboto", 32F);
            this.btnFresh.ForeColor = System.Drawing.Color.White;
            this.btnFresh.Location = new System.Drawing.Point(1119, 781);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(239, 114);
            this.btnFresh.TabIndex = 4;
            this.btnFresh.Text = "Update";
            this.btnFresh.UseVisualStyleBackColor = false;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // pnl_overzicht
            // 
            this.pnl_overzicht.Controls.Add(this.btnFresh);
            this.pnl_overzicht.Controls.Add(this.btnPlus);
            this.pnl_overzicht.Controls.Add(this.btnMin);
            this.pnl_overzicht.Controls.Add(this.panel2);
            this.pnl_overzicht.Controls.Add(this.panel_Header);
            this.pnl_overzicht.Location = new System.Drawing.Point(0, 0);
            this.pnl_overzicht.Name = "pnl_overzicht";
            this.pnl_overzicht.Size = new System.Drawing.Size(1576, 942);
            this.pnl_overzicht.TabIndex = 22;
            // 
            // txtNaam
            // 
            this.txtNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.Location = new System.Drawing.Point(36, 146);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(153, 32);
            this.txtNaam.TabIndex = 0;
            // 
            // dateTijd
            // 
            this.dateTijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTijd.Location = new System.Drawing.Point(37, 522);
            this.dateTijd.Name = "dateTijd";
            this.dateTijd.Size = new System.Drawing.Size(365, 32);
            this.dateTijd.TabIndex = 6;
            this.dateTijd.ValueChanged += new System.EventHandler(this.dateTijd_ValueChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Voornaam";
            // 
            // lblAantalPersonen
            // 
            this.lblAantalPersonen.AutoSize = true;
            this.lblAantalPersonen.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalPersonen.Location = new System.Drawing.Point(36, 405);
            this.lblAantalPersonen.Name = "lblAantalPersonen";
            this.lblAantalPersonen.Size = new System.Drawing.Size(147, 23);
            this.lblAantalPersonen.TabIndex = 5;
            this.lblAantalPersonen.Text = "Aantal Personen";
            // 
            // btnUpdateRes
            // 
            this.btnUpdateRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btnUpdateRes.FlatAppearance.BorderSize = 0;
            this.btnUpdateRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRes.Font = new System.Drawing.Font("Roboto", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRes.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRes.Location = new System.Drawing.Point(1148, 755);
            this.btnUpdateRes.Name = "btnUpdateRes";
            this.btnUpdateRes.Size = new System.Drawing.Size(205, 102);
            this.btnUpdateRes.TabIndex = 6;
            this.btnUpdateRes.Text = "Opslaan";
            this.btnUpdateRes.UseVisualStyleBackColor = false;
            this.btnUpdateRes.Click += new System.EventHandler(this.btnUpdateRes_Click);
            // 
            // btnDeleteRes
            // 
            this.btnDeleteRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btnDeleteRes.FlatAppearance.BorderSize = 0;
            this.btnDeleteRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRes.Font = new System.Drawing.Font("Roboto", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRes.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRes.Location = new System.Drawing.Point(410, 752);
            this.btnDeleteRes.Name = "btnDeleteRes";
            this.btnDeleteRes.Size = new System.Drawing.Size(238, 102);
            this.btnDeleteRes.TabIndex = 7;
            this.btnDeleteRes.Text = "Verwijder";
            this.btnDeleteRes.UseVisualStyleBackColor = false;
            this.btnDeleteRes.Click += new System.EventHandler(this.btnDeleteRes_Click);
            // 
            // NumericAantal
            // 
            this.NumericAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericAantal.Location = new System.Drawing.Point(40, 432);
            this.NumericAantal.Name = "NumericAantal";
            this.NumericAantal.Size = new System.Drawing.Size(120, 32);
            this.NumericAantal.TabIndex = 4;
            // 
            // lstReserveringDag
            // 
            this.lstReserveringDag.Font = new System.Drawing.Font("Roboto", 15F);
            this.lstReserveringDag.HideSelection = false;
            this.lstReserveringDag.Location = new System.Drawing.Point(3, 60);
            this.lstReserveringDag.Name = "lstReserveringDag";
            this.lstReserveringDag.Size = new System.Drawing.Size(943, 561);
            this.lstReserveringDag.TabIndex = 9;
            this.lstReserveringDag.UseCompatibleStateImageBehavior = false;
            this.lstReserveringDag.View = System.Windows.Forms.View.Details;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.White;
            this.lblDatum.Location = new System.Drawing.Point(13, 14);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(588, 38);
            this.lblDatum.TabIndex = 10;
            this.lblDatum.Text = "Ingeplande Reserveringen voor vandaag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Geboorte Datum";
            // 
            // txtTellie
            // 
            this.txtTellie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTellie.Location = new System.Drawing.Point(40, 344);
            this.txtTellie.Name = "txtTellie";
            this.txtTellie.Size = new System.Drawing.Size(184, 32);
            this.txtTellie.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Telefoon Nummer";
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAchternaam.Location = new System.Drawing.Point(211, 146);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(155, 32);
            this.txtAchternaam.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Achternaam";
            // 
            // cmbTafel
            // 
            this.cmbTafel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTafel.FormattingEnabled = true;
            this.cmbTafel.Location = new System.Drawing.Point(232, 432);
            this.cmbTafel.Name = "cmbTafel";
            this.cmbTafel.Size = new System.Drawing.Size(47, 33);
            this.cmbTafel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tafel";
            // 
            // geboorteDatumPicker
            // 
            this.geboorteDatumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geboorteDatumPicker.Location = new System.Drawing.Point(36, 242);
            this.geboorteDatumPicker.Name = "geboorteDatumPicker";
            this.geboorteDatumPicker.Size = new System.Drawing.Size(365, 32);
            this.geboorteDatumPicker.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Reservering Datum";
            // 
            // pnlReservering
            // 
            this.pnlReservering.BackColor = System.Drawing.Color.Transparent;
            this.pnlReservering.Controls.Add(this.panel3);
            this.pnlReservering.Controls.Add(this.label7);
            this.pnlReservering.Controls.Add(this.geboorteDatumPicker);
            this.pnlReservering.Controls.Add(this.label6);
            this.pnlReservering.Controls.Add(this.cmbTafel);
            this.pnlReservering.Controls.Add(this.label5);
            this.pnlReservering.Controls.Add(this.txtAchternaam);
            this.pnlReservering.Controls.Add(this.btnSelectKlant);
            this.pnlReservering.Controls.Add(this.label2);
            this.pnlReservering.Controls.Add(this.txtTellie);
            this.pnlReservering.Controls.Add(this.label1);
            this.pnlReservering.Controls.Add(this.NumericAantal);
            this.pnlReservering.Controls.Add(this.btnDeleteRes);
            this.pnlReservering.Controls.Add(this.btnUpdateRes);
            this.pnlReservering.Controls.Add(this.lblAantalPersonen);
            this.pnlReservering.Controls.Add(this.lblName);
            this.pnlReservering.Controls.Add(this.dateTijd);
            this.pnlReservering.Controls.Add(this.txtNaam);
            this.pnlReservering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReservering.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReservering.Location = new System.Drawing.Point(0, 0);
            this.pnlReservering.Name = "pnlReservering";
            this.pnlReservering.Size = new System.Drawing.Size(1576, 942);
            this.pnlReservering.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.panel3.Controls.Add(this.lstReserveringDag);
            this.panel3.Controls.Add(this.lblDatum);
            this.panel3.Location = new System.Drawing.Point(407, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 624);
            this.panel3.TabIndex = 32;
            // 
            // btnSelectKlant
            // 
            this.btnSelectKlant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btnSelectKlant.FlatAppearance.BorderSize = 0;
            this.btnSelectKlant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectKlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.75F);
            this.btnSelectKlant.ForeColor = System.Drawing.Color.White;
            this.btnSelectKlant.Location = new System.Drawing.Point(964, 12);
            this.btnSelectKlant.Name = "btnSelectKlant";
            this.btnSelectKlant.Size = new System.Drawing.Size(353, 85);
            this.btnSelectKlant.TabIndex = 15;
            this.btnSelectKlant.Text = "Klant Systeem";
            this.btnSelectKlant.UseVisualStyleBackColor = false;
            this.btnSelectKlant.Click += new System.EventHandler(this.btnSelectKlant_Click);
            // 
            // RestaurantOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_overzicht);
            this.Controls.Add(this.pnlReservering);
            this.Controls.Add(this.pnlKlantSysteem);
            this.Name = "RestaurantOverzicht";
            this.Size = new System.Drawing.Size(1576, 942);
            this.Load += new System.EventHandler(this.RestaurantOverzicht_Load);
            this.pnlKlantSysteem.ResumeLayout(false);
            this.pnlKlantSysteem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_overzicht.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericAantal)).EndInit();
            this.pnlReservering.ResumeLayout(false);
            this.pnlReservering.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlKlantSysteem;
        private System.Windows.Forms.Label lblKlantGeselct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaamKlant;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnKlantOpslaan;
        private System.Windows.Forms.ListView lstKlantSysteem;
        private System.Windows.Forms.Label lblZoeken;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.ListView lstReservering;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lstTafelStatus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.Panel pnl_overzicht;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.DateTimePicker dateTijd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAantalPersonen;
        private System.Windows.Forms.Button btnUpdateRes;
        private System.Windows.Forms.Button btnDeleteRes;
        private System.Windows.Forms.NumericUpDown NumericAantal;
        private System.Windows.Forms.ListView lstReserveringDag;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTellie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTafel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker geboorteDatumPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlReservering;
        private System.Windows.Forms.Button btnSelectKlant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKlantSysteem;
        private System.Windows.Forms.Panel panel3;
    }
}