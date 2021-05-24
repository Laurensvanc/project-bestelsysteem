namespace Login
{
    partial class Afrekenen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Afrekenen));
            this.flp_TableSelect = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Afrekenen = new System.Windows.Forms.Panel();
            this.pnl_Opmerking = new System.Windows.Forms.Panel();
            this.btnTerug = new System.Windows.Forms.Button();
            this.txtOpmerking = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTerugOverzicht = new System.Windows.Forms.Button();
            this.btnOpmerking = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbtnContant = new System.Windows.Forms.RadioButton();
            this.rbtnPinnen = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBetaal = new System.Windows.Forms.Button();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.nudTip = new System.Windows.Forms.NumericUpDown();
            this.listOrderViewTotaal = new System.Windows.Forms.ListView();
            this.listOrderViewTip = new System.Windows.Forms.ListView();
            this.listOrderView = new System.Windows.Forms.ListView();
            this.img_Logo = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblGeholpen = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTijd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTransID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAfrekenen = new System.Windows.Forms.Label();
            this.rbtnPin = new System.Windows.Forms.RadioButton();
            this.pnl_Afrekenen.SuspendLayout();
            this.pnl_Opmerking.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_TableSelect
            // 
            this.flp_TableSelect.Location = new System.Drawing.Point(12, 52);
            this.flp_TableSelect.Name = "flp_TableSelect";
            this.flp_TableSelect.Size = new System.Drawing.Size(658, 455);
            this.flp_TableSelect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecteer tafel voor afrekenen";
            // 
            // pnl_Afrekenen
            // 
            this.pnl_Afrekenen.Controls.Add(this.btnTerugOverzicht);
            this.pnl_Afrekenen.Controls.Add(this.btnOpmerking);
            this.pnl_Afrekenen.Controls.Add(this.groupBox5);
            this.pnl_Afrekenen.Controls.Add(this.btnBetaal);
            this.pnl_Afrekenen.Controls.Add(this.btnUpdatePrice);
            this.pnl_Afrekenen.Controls.Add(this.nudTip);
            this.pnl_Afrekenen.Controls.Add(this.listOrderViewTotaal);
            this.pnl_Afrekenen.Controls.Add(this.listOrderViewTip);
            this.pnl_Afrekenen.Controls.Add(this.listOrderView);
            this.pnl_Afrekenen.Controls.Add(this.img_Logo);
            this.pnl_Afrekenen.Controls.Add(this.groupBox4);
            this.pnl_Afrekenen.Controls.Add(this.groupBox3);
            this.pnl_Afrekenen.Controls.Add(this.groupBox2);
            this.pnl_Afrekenen.Controls.Add(this.groupBox1);
            this.pnl_Afrekenen.Controls.Add(this.lblAfrekenen);
            this.pnl_Afrekenen.Location = new System.Drawing.Point(12, 11);
            this.pnl_Afrekenen.Name = "pnl_Afrekenen";
            this.pnl_Afrekenen.Size = new System.Drawing.Size(1017, 546);
            this.pnl_Afrekenen.TabIndex = 19;
            // 
            // pnl_Opmerking
            // 
            this.pnl_Opmerking.Controls.Add(this.btnTerug);
            this.pnl_Opmerking.Controls.Add(this.txtOpmerking);
            this.pnl_Opmerking.Controls.Add(this.label4);
            this.pnl_Opmerking.Location = new System.Drawing.Point(9, 12);
            this.pnl_Opmerking.Name = "pnl_Opmerking";
            this.pnl_Opmerking.Size = new System.Drawing.Size(1020, 545);
            this.pnl_Opmerking.TabIndex = 29;
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnTerug.Location = new System.Drawing.Point(379, 439);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(268, 65);
            this.btnTerug.TabIndex = 29;
            this.btnTerug.Text = "Terug naar afrekenen";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // txtOpmerking
            // 
            this.txtOpmerking.AcceptsReturn = true;
            this.txtOpmerking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtOpmerking.Location = new System.Drawing.Point(313, 106);
            this.txtOpmerking.Multiline = true;
            this.txtOpmerking.Name = "txtOpmerking";
            this.txtOpmerking.Size = new System.Drawing.Size(406, 327);
            this.txtOpmerking.TabIndex = 30;
            this.txtOpmerking.Text = "\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(421, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 37);
            this.label4.TabIndex = 29;
            this.label4.Text = "Opmerking";
            // 
            // btnTerugOverzicht
            // 
            this.btnTerugOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnTerugOverzicht.Location = new System.Drawing.Point(48, 480);
            this.btnTerugOverzicht.Name = "btnTerugOverzicht";
            this.btnTerugOverzicht.Size = new System.Drawing.Size(230, 36);
            this.btnTerugOverzicht.TabIndex = 30;
            this.btnTerugOverzicht.Text = "< Terug naar overzicht";
            this.btnTerugOverzicht.UseVisualStyleBackColor = true;
            this.btnTerugOverzicht.Click += new System.EventHandler(this.btnTerugOverzicht_Click);
            // 
            // btnOpmerking
            // 
            this.btnOpmerking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOpmerking.Location = new System.Drawing.Point(400, 480);
            this.btnOpmerking.Name = "btnOpmerking";
            this.btnOpmerking.Size = new System.Drawing.Size(145, 36);
            this.btnOpmerking.TabIndex = 29;
            this.btnOpmerking.Text = "Opmerking";
            this.btnOpmerking.UseVisualStyleBackColor = true;
            this.btnOpmerking.Click += new System.EventHandler(this.btnOpmerking_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbtnContant);
            this.groupBox5.Controls.Add(this.rbtnPinnen);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(400, 328);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(145, 132);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // rbtnContant
            // 
            this.rbtnContant.AutoSize = true;
            this.rbtnContant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtnContant.Location = new System.Drawing.Point(25, 81);
            this.rbtnContant.Name = "rbtnContant";
            this.rbtnContant.Size = new System.Drawing.Size(75, 21);
            this.rbtnContant.TabIndex = 21;
            this.rbtnContant.TabStop = true;
            this.rbtnContant.Text = "Contant";
            this.rbtnContant.UseVisualStyleBackColor = true;
            this.rbtnContant.CheckedChanged += new System.EventHandler(this.rbtnContant_CheckedChanged);
            // 
            // rbtnPinnen
            // 
            this.rbtnPinnen.AutoSize = true;
            this.rbtnPinnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtnPinnen.Location = new System.Drawing.Point(25, 54);
            this.rbtnPinnen.Name = "rbtnPinnen";
            this.rbtnPinnen.Size = new System.Drawing.Size(46, 21);
            this.rbtnPinnen.TabIndex = 20;
            this.rbtnPinnen.TabStop = true;
            this.rbtnPinnen.Text = "Pin";
            this.rbtnPinnen.UseVisualStyleBackColor = true;
            this.rbtnPinnen.CheckedChanged += new System.EventHandler(this.rbtnPinnen_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Betalen met:";
            // 
            // btnBetaal
            // 
            this.btnBetaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBetaal.Location = new System.Drawing.Point(562, 466);
            this.btnBetaal.Name = "btnBetaal";
            this.btnBetaal.Size = new System.Drawing.Size(268, 65);
            this.btnBetaal.TabIndex = 28;
            this.btnBetaal.Text = "Betaal";
            this.btnBetaal.UseVisualStyleBackColor = true;
            this.btnBetaal.Click += new System.EventHandler(this.btnBetaal_Click);
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnUpdatePrice.Location = new System.Drawing.Point(836, 466);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(131, 36);
            this.btnUpdatePrice.TabIndex = 27;
            this.btnUpdatePrice.Text = "Update prijs";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // nudTip
            // 
            this.nudTip.DecimalPlaces = 2;
            this.nudTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nudTip.Location = new System.Drawing.Point(855, 390);
            this.nudTip.Name = "nudTip";
            this.nudTip.Size = new System.Drawing.Size(112, 35);
            this.nudTip.TabIndex = 26;
            this.nudTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listOrderViewTotaal
            // 
            this.listOrderViewTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listOrderViewTotaal.GridLines = true;
            this.listOrderViewTotaal.HideSelection = false;
            this.listOrderViewTotaal.Location = new System.Drawing.Point(562, 424);
            this.listOrderViewTotaal.Name = "listOrderViewTotaal";
            this.listOrderViewTotaal.Size = new System.Drawing.Size(405, 36);
            this.listOrderViewTotaal.TabIndex = 25;
            this.listOrderViewTotaal.UseCompatibleStateImageBehavior = false;
            this.listOrderViewTotaal.View = System.Windows.Forms.View.Details;
            // 
            // listOrderViewTip
            // 
            this.listOrderViewTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listOrderViewTip.GridLines = true;
            this.listOrderViewTip.HideSelection = false;
            this.listOrderViewTip.Location = new System.Drawing.Point(562, 389);
            this.listOrderViewTip.Name = "listOrderViewTip";
            this.listOrderViewTip.Size = new System.Drawing.Size(405, 36);
            this.listOrderViewTip.TabIndex = 24;
            this.listOrderViewTip.UseCompatibleStateImageBehavior = false;
            this.listOrderViewTip.View = System.Windows.Forms.View.Details;
            // 
            // listOrderView
            // 
            this.listOrderView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listOrderView.GridLines = true;
            this.listOrderView.HideSelection = false;
            this.listOrderView.Location = new System.Drawing.Point(562, 40);
            this.listOrderView.Name = "listOrderView";
            this.listOrderView.Size = new System.Drawing.Size(405, 352);
            this.listOrderView.TabIndex = 23;
            this.listOrderView.UseCompatibleStateImageBehavior = false;
            this.listOrderView.View = System.Windows.Forms.View.Details;
            // 
            // img_Logo
            // 
            this.img_Logo.Image = ((System.Drawing.Image)(resources.GetObject("img_Logo.Image")));
            this.img_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("img_Logo.InitialImage")));
            this.img_Logo.Location = new System.Drawing.Point(374, 94);
            this.img_Logo.Name = "img_Logo";
            this.img_Logo.Size = new System.Drawing.Size(171, 87);
            this.img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Logo.TabIndex = 22;
            this.img_Logo.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblGeholpen);
            this.groupBox4.Location = new System.Drawing.Point(48, 318);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 74);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // lblGeholpen
            // 
            this.lblGeholpen.AutoSize = true;
            this.lblGeholpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblGeholpen.Location = new System.Drawing.Point(6, 25);
            this.lblGeholpen.Name = "lblGeholpen";
            this.lblGeholpen.Size = new System.Drawing.Size(163, 24);
            this.lblGeholpen.TabIndex = 19;
            this.lblGeholpen.Text = "Geholpen door: ...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTijd);
            this.groupBox3.Location = new System.Drawing.Point(203, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 56);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // lblTijd
            // 
            this.lblTijd.AutoSize = true;
            this.lblTijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTijd.Location = new System.Drawing.Point(21, 16);
            this.lblTijd.Name = "lblTijd";
            this.lblTijd.Size = new System.Drawing.Size(96, 24);
            this.lblTijd.TabIndex = 19;
            this.lblTijd.Text = "Tijd: 00:00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTransID);
            this.groupBox2.Location = new System.Drawing.Point(48, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 56);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // lblTransID
            // 
            this.lblTransID.AutoSize = true;
            this.lblTransID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTransID.Location = new System.Drawing.Point(48, 16);
            this.lblTransID.Name = "lblTransID";
            this.lblTransID.Size = new System.Drawing.Size(50, 24);
            this.lblTransID.TabIndex = 19;
            this.lblTransID.Text = "Id: ...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(48, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 74);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.label2.Location = new System.Drawing.Point(90, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 44);
            this.label2.TabIndex = 19;
            this.label2.Text = "Chapoo";
            // 
            // lblAfrekenen
            // 
            this.lblAfrekenen.AutoSize = true;
            this.lblAfrekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblAfrekenen.Location = new System.Drawing.Point(23, 28);
            this.lblAfrekenen.Name = "lblAfrekenen";
            this.lblAfrekenen.Size = new System.Drawing.Size(267, 37);
            this.lblAfrekenen.TabIndex = 17;
            this.lblAfrekenen.Text = "Afrekenen tafel ...";
            // 
            // rbtnPin
            // 
            this.rbtnPin.AutoSize = true;
            this.rbtnPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rbtnPin.Location = new System.Drawing.Point(15, 50);
            this.rbtnPin.Name = "rbtnPin";
            this.rbtnPin.Size = new System.Drawing.Size(55, 28);
            this.rbtnPin.TabIndex = 29;
            this.rbtnPin.TabStop = true;
            this.rbtnPin.Text = "Pin";
            this.rbtnPin.UseVisualStyleBackColor = true;
            // 
            // Afrekenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 578);
            this.Controls.Add(this.pnl_Opmerking);
            this.Controls.Add(this.pnl_Afrekenen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flp_TableSelect);
            this.Name = "Afrekenen";
            this.Text = "Afrekenen";
            this.pnl_Afrekenen.ResumeLayout(false);
            this.pnl_Afrekenen.PerformLayout();
            this.pnl_Opmerking.ResumeLayout(false);
            this.pnl_Opmerking.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_TableSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Afrekenen;
        private System.Windows.Forms.Label lblAfrekenen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblGeholpen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTijd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTransID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox img_Logo;
        private System.Windows.Forms.ListView listOrderView;
        private System.Windows.Forms.ListView listOrderViewTotaal;
        private System.Windows.Forms.ListView listOrderViewTip;
        private System.Windows.Forms.NumericUpDown nudTip;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.Button btnBetaal;
        private System.Windows.Forms.RadioButton rbtnPin;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtnContant;
        private System.Windows.Forms.RadioButton rbtnPinnen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_Opmerking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.TextBox txtOpmerking;
        private System.Windows.Forms.Button btnOpmerking;
        private System.Windows.Forms.Button btnTerugOverzicht;
    }
}