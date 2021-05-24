namespace Login
{
    partial class BestellingOpnemen
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
            this.listMenuView = new System.Windows.Forms.ListView();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnRemoveFromOrder = new System.Windows.Forms.Button();
            this.listOrderView = new System.Windows.Forms.ListView();
            this.pnl_Bestellen = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInstructies = new System.Windows.Forms.Button();
            this.btnKlacht = new System.Windows.Forms.Button();
            this.btnKaartOverzicht = new System.Windows.Forms.Button();
            this.pnl_MenuType = new System.Windows.Forms.Panel();
            this.btnNagerecht = new System.Windows.Forms.Button();
            this.btnTussengerecht = new System.Windows.Forms.Button();
            this.btnTafelOverzicht = new System.Windows.Forms.Button();
            this.btnHoofdgerecht = new System.Windows.Forms.Button();
            this.btnDrankKaart = new System.Windows.Forms.Button();
            this.btnVoorgerecht = new System.Windows.Forms.Button();
            this.lblTafelnr = new System.Windows.Forms.Label();
            this.pnl_TafelSelect = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTafel10 = new System.Windows.Forms.Button();
            this.btnTafel9 = new System.Windows.Forms.Button();
            this.btnTafel8 = new System.Windows.Forms.Button();
            this.btnTafel7 = new System.Windows.Forms.Button();
            this.btnTafel6 = new System.Windows.Forms.Button();
            this.btnTafel5 = new System.Windows.Forms.Button();
            this.btnTafel4 = new System.Windows.Forms.Button();
            this.btnTafel3 = new System.Windows.Forms.Button();
            this.btnTafel2 = new System.Windows.Forms.Button();
            this.btnTafel1 = new System.Windows.Forms.Button();
            this.pnl_Drank = new System.Windows.Forms.Panel();
            this.btnKoffieThee = new System.Windows.Forms.Button();
            this.btnGedestDrank = new System.Windows.Forms.Button();
            this.btnFrisdrank = new System.Windows.Forms.Button();
            this.btnBieren = new System.Windows.Forms.Button();
            this.btnWijnen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Tafelnr = new System.Windows.Forms.Panel();
            this.pnl_Klacht = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKlacht = new System.Windows.Forms.TextBox();
            this.btnKaartoverzicht2 = new System.Windows.Forms.Button();
            this.pnl_Instructies = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInstructies = new System.Windows.Forms.TextBox();
            this.btnKaartoverzicht3 = new System.Windows.Forms.Button();
            this.pnl_Bestellen.SuspendLayout();
            this.pnl_MenuType.SuspendLayout();
            this.pnl_TafelSelect.SuspendLayout();
            this.pnl_Drank.SuspendLayout();
            this.pnl_Tafelnr.SuspendLayout();
            this.pnl_Klacht.SuspendLayout();
            this.pnl_Instructies.SuspendLayout();
            this.SuspendLayout();
            // 
            // listMenuView
            // 
            this.listMenuView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listMenuView.FullRowSelect = true;
            this.listMenuView.GridLines = true;
            this.listMenuView.HideSelection = false;
            this.listMenuView.Location = new System.Drawing.Point(30, 66);
            this.listMenuView.Name = "listMenuView";
            this.listMenuView.Size = new System.Drawing.Size(367, 335);
            this.listMenuView.TabIndex = 5;
            this.listMenuView.UseCompatibleStateImageBehavior = false;
            this.listMenuView.View = System.Windows.Forms.View.Details;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.btnAddToOrder.Location = new System.Drawing.Point(49, 418);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(75, 59);
            this.btnAddToOrder.TabIndex = 2;
            this.btnAddToOrder.Text = "+";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnPlaceOrder.Location = new System.Drawing.Point(49, 497);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(328, 59);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Plaats bestelling";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnRemoveFromOrder
            // 
            this.btnRemoveFromOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.btnRemoveFromOrder.Location = new System.Drawing.Point(302, 421);
            this.btnRemoveFromOrder.Name = "btnRemoveFromOrder";
            this.btnRemoveFromOrder.Size = new System.Drawing.Size(75, 59);
            this.btnRemoveFromOrder.TabIndex = 5;
            this.btnRemoveFromOrder.Text = "-";
            this.btnRemoveFromOrder.UseVisualStyleBackColor = true;
            this.btnRemoveFromOrder.Click += new System.EventHandler(this.btnRemoveFromOrder_Click);
            // 
            // listOrderView
            // 
            this.listOrderView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listOrderView.FullRowSelect = true;
            this.listOrderView.GridLines = true;
            this.listOrderView.HideSelection = false;
            this.listOrderView.Location = new System.Drawing.Point(30, 562);
            this.listOrderView.Name = "listOrderView";
            this.listOrderView.Size = new System.Drawing.Size(367, 240);
            this.listOrderView.TabIndex = 6;
            this.listOrderView.UseCompatibleStateImageBehavior = false;
            this.listOrderView.View = System.Windows.Forms.View.Details;
            // 
            // pnl_Bestellen
            // 
            this.pnl_Bestellen.Controls.Add(this.lblTotal);
            this.pnl_Bestellen.Controls.Add(this.label5);
            this.pnl_Bestellen.Controls.Add(this.btnInstructies);
            this.pnl_Bestellen.Controls.Add(this.btnKlacht);
            this.pnl_Bestellen.Controls.Add(this.btnKaartOverzicht);
            this.pnl_Bestellen.Controls.Add(this.listOrderView);
            this.pnl_Bestellen.Controls.Add(this.listMenuView);
            this.pnl_Bestellen.Controls.Add(this.btnRemoveFromOrder);
            this.pnl_Bestellen.Controls.Add(this.btnAddToOrder);
            this.pnl_Bestellen.Controls.Add(this.btnPlaceOrder);
            this.pnl_Bestellen.Location = new System.Drawing.Point(6, 12);
            this.pnl_Bestellen.Name = "pnl_Bestellen";
            this.pnl_Bestellen.Size = new System.Drawing.Size(416, 878);
            this.pnl_Bestellen.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTotal.Location = new System.Drawing.Point(233, 436);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 24);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(146, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Totaal: €";
            // 
            // btnInstructies
            // 
            this.btnInstructies.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnInstructies.Location = new System.Drawing.Point(216, 808);
            this.btnInstructies.Name = "btnInstructies";
            this.btnInstructies.Size = new System.Drawing.Size(197, 59);
            this.btnInstructies.TabIndex = 9;
            this.btnInstructies.Text = "Instructies";
            this.btnInstructies.UseVisualStyleBackColor = true;
            this.btnInstructies.Click += new System.EventHandler(this.btnInstructies_Click);
            // 
            // btnKlacht
            // 
            this.btnKlacht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnKlacht.Location = new System.Drawing.Point(13, 808);
            this.btnKlacht.Name = "btnKlacht";
            this.btnKlacht.Size = new System.Drawing.Size(197, 59);
            this.btnKlacht.TabIndex = 8;
            this.btnKlacht.Text = "Klacht";
            this.btnKlacht.UseVisualStyleBackColor = true;
            this.btnKlacht.Click += new System.EventHandler(this.btnKlacht_Click);
            // 
            // btnKaartOverzicht
            // 
            this.btnKaartOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnKaartOverzicht.Location = new System.Drawing.Point(30, 9);
            this.btnKaartOverzicht.Name = "btnKaartOverzicht";
            this.btnKaartOverzicht.Size = new System.Drawing.Size(247, 51);
            this.btnKaartOverzicht.TabIndex = 7;
            this.btnKaartOverzicht.Text = "< Kaartoverzicht";
            this.btnKaartOverzicht.UseVisualStyleBackColor = true;
            this.btnKaartOverzicht.Click += new System.EventHandler(this.btnKaartOverzicht_Click);
            // 
            // pnl_MenuType
            // 
            this.pnl_MenuType.Controls.Add(this.btnNagerecht);
            this.pnl_MenuType.Controls.Add(this.btnTussengerecht);
            this.pnl_MenuType.Controls.Add(this.btnTafelOverzicht);
            this.pnl_MenuType.Controls.Add(this.btnHoofdgerecht);
            this.pnl_MenuType.Controls.Add(this.btnDrankKaart);
            this.pnl_MenuType.Controls.Add(this.btnVoorgerecht);
            this.pnl_MenuType.Location = new System.Drawing.Point(3, 12);
            this.pnl_MenuType.Name = "pnl_MenuType";
            this.pnl_MenuType.Size = new System.Drawing.Size(419, 409);
            this.pnl_MenuType.TabIndex = 8;
            // 
            // btnNagerecht
            // 
            this.btnNagerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnNagerecht.Location = new System.Drawing.Point(51, 283);
            this.btnNagerecht.Name = "btnNagerecht";
            this.btnNagerecht.Size = new System.Drawing.Size(328, 60);
            this.btnNagerecht.TabIndex = 12;
            this.btnNagerecht.Text = "Nagerechten";
            this.btnNagerecht.UseVisualStyleBackColor = true;
            this.btnNagerecht.Click += new System.EventHandler(this.btnNagerecht_Click);
            // 
            // btnTussengerecht
            // 
            this.btnTussengerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTussengerecht.Location = new System.Drawing.Point(51, 349);
            this.btnTussengerecht.Name = "btnTussengerecht";
            this.btnTussengerecht.Size = new System.Drawing.Size(328, 60);
            this.btnTussengerecht.TabIndex = 11;
            this.btnTussengerecht.Text = "Tussengerechten";
            this.btnTussengerecht.UseVisualStyleBackColor = true;
            this.btnTussengerecht.Click += new System.EventHandler(this.btnTussengerecht_Click);
            // 
            // btnTafelOverzicht
            // 
            this.btnTafelOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTafelOverzicht.Location = new System.Drawing.Point(33, 23);
            this.btnTafelOverzicht.Name = "btnTafelOverzicht";
            this.btnTafelOverzicht.Size = new System.Drawing.Size(247, 51);
            this.btnTafelOverzicht.TabIndex = 8;
            this.btnTafelOverzicht.Text = "< Tafeloverzicht";
            this.btnTafelOverzicht.UseVisualStyleBackColor = true;
            this.btnTafelOverzicht.Click += new System.EventHandler(this.btnTafelOverzicht_Click);
            // 
            // btnHoofdgerecht
            // 
            this.btnHoofdgerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnHoofdgerecht.Location = new System.Drawing.Point(51, 217);
            this.btnHoofdgerecht.Name = "btnHoofdgerecht";
            this.btnHoofdgerecht.Size = new System.Drawing.Size(328, 60);
            this.btnHoofdgerecht.TabIndex = 9;
            this.btnHoofdgerecht.Text = "Hoofdgerechten";
            this.btnHoofdgerecht.UseVisualStyleBackColor = true;
            this.btnHoofdgerecht.Click += new System.EventHandler(this.btnHoofdgerecht_Click);
            // 
            // btnDrankKaart
            // 
            this.btnDrankKaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDrankKaart.Location = new System.Drawing.Point(51, 85);
            this.btnDrankKaart.Name = "btnDrankKaart";
            this.btnDrankKaart.Size = new System.Drawing.Size(328, 60);
            this.btnDrankKaart.TabIndex = 7;
            this.btnDrankKaart.Text = "Drankjes";
            this.btnDrankKaart.UseVisualStyleBackColor = true;
            this.btnDrankKaart.Click += new System.EventHandler(this.btnDrankKaart_Click);
            // 
            // btnVoorgerecht
            // 
            this.btnVoorgerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnVoorgerecht.Location = new System.Drawing.Point(51, 151);
            this.btnVoorgerecht.Name = "btnVoorgerecht";
            this.btnVoorgerecht.Size = new System.Drawing.Size(328, 60);
            this.btnVoorgerecht.TabIndex = 8;
            this.btnVoorgerecht.Text = "Voorgerechten";
            this.btnVoorgerecht.UseVisualStyleBackColor = true;
            this.btnVoorgerecht.Click += new System.EventHandler(this.btnVoorgerecht_Click);
            // 
            // lblTafelnr
            // 
            this.lblTafelnr.AutoSize = true;
            this.lblTafelnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTafelnr.Location = new System.Drawing.Point(134, 14);
            this.lblTafelnr.Name = "lblTafelnr";
            this.lblTafelnr.Size = new System.Drawing.Size(44, 37);
            this.lblTafelnr.TabIndex = 10;
            this.lblTafelnr.Text = "...";
            // 
            // pnl_TafelSelect
            // 
            this.pnl_TafelSelect.Controls.Add(this.label2);
            this.pnl_TafelSelect.Controls.Add(this.btnTafel10);
            this.pnl_TafelSelect.Controls.Add(this.btnTafel9);
            this.pnl_TafelSelect.Controls.Add(this.btnTafel8);
            this.pnl_TafelSelect.Controls.Add(this.btnTafel7);
            this.pnl_TafelSelect.Controls.Add(this.btnTafel6);
            this.pnl_TafelSelect.Controls.Add(this.btnTafel5);
            this.pnl_TafelSelect.Controls.Add(this.btnTafel4);
            this.pnl_TafelSelect.Controls.Add(this.btnTafel3);
            this.pnl_TafelSelect.Controls.Add(this.btnTafel2);
            this.pnl_TafelSelect.Controls.Add(this.btnTafel1);
            this.pnl_TafelSelect.Location = new System.Drawing.Point(12, 12);
            this.pnl_TafelSelect.Name = "pnl_TafelSelect";
            this.pnl_TafelSelect.Size = new System.Drawing.Size(475, 878);
            this.pnl_TafelSelect.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(87, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Selecteer tafel";
            // 
            // btnTafel10
            // 
            this.btnTafel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTafel10.Location = new System.Drawing.Point(211, 635);
            this.btnTafel10.Name = "btnTafel10";
            this.btnTafel10.Size = new System.Drawing.Size(189, 118);
            this.btnTafel10.TabIndex = 16;
            this.btnTafel10.Text = "Tafel 10";
            this.btnTafel10.UseVisualStyleBackColor = true;
            this.btnTafel10.Click += new System.EventHandler(this.btnTafel10_Click);
            // 
            // btnTafel9
            // 
            this.btnTafel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTafel9.Location = new System.Drawing.Point(2, 635);
            this.btnTafel9.Name = "btnTafel9";
            this.btnTafel9.Size = new System.Drawing.Size(189, 118);
            this.btnTafel9.TabIndex = 15;
            this.btnTafel9.Text = "Tafel 9";
            this.btnTafel9.UseVisualStyleBackColor = true;
            this.btnTafel9.Click += new System.EventHandler(this.btnTafel9_Click);
            // 
            // btnTafel8
            // 
            this.btnTafel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTafel8.Location = new System.Drawing.Point(211, 497);
            this.btnTafel8.Name = "btnTafel8";
            this.btnTafel8.Size = new System.Drawing.Size(189, 118);
            this.btnTafel8.TabIndex = 14;
            this.btnTafel8.Text = "Tafel 8";
            this.btnTafel8.UseVisualStyleBackColor = true;
            this.btnTafel8.Click += new System.EventHandler(this.btnTafel8_Click);
            // 
            // btnTafel7
            // 
            this.btnTafel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTafel7.Location = new System.Drawing.Point(2, 497);
            this.btnTafel7.Name = "btnTafel7";
            this.btnTafel7.Size = new System.Drawing.Size(189, 118);
            this.btnTafel7.TabIndex = 13;
            this.btnTafel7.Text = "Tafel 7";
            this.btnTafel7.UseVisualStyleBackColor = true;
            this.btnTafel7.Click += new System.EventHandler(this.btnTafel7_Click);
            // 
            // btnTafel6
            // 
            this.btnTafel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTafel6.Location = new System.Drawing.Point(211, 359);
            this.btnTafel6.Name = "btnTafel6";
            this.btnTafel6.Size = new System.Drawing.Size(189, 118);
            this.btnTafel6.TabIndex = 12;
            this.btnTafel6.Text = "Tafel 6";
            this.btnTafel6.UseVisualStyleBackColor = true;
            this.btnTafel6.Click += new System.EventHandler(this.btnTafel6_Click);
            // 
            // btnTafel5
            // 
            this.btnTafel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTafel5.Location = new System.Drawing.Point(2, 359);
            this.btnTafel5.Name = "btnTafel5";
            this.btnTafel5.Size = new System.Drawing.Size(189, 118);
            this.btnTafel5.TabIndex = 11;
            this.btnTafel5.Text = "Tafel 5";
            this.btnTafel5.UseVisualStyleBackColor = true;
            this.btnTafel5.Click += new System.EventHandler(this.btnTafel5_Click);
            // 
            // btnTafel4
            // 
            this.btnTafel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTafel4.Location = new System.Drawing.Point(211, 221);
            this.btnTafel4.Name = "btnTafel4";
            this.btnTafel4.Size = new System.Drawing.Size(189, 118);
            this.btnTafel4.TabIndex = 10;
            this.btnTafel4.Text = "Tafel 4";
            this.btnTafel4.UseVisualStyleBackColor = true;
            this.btnTafel4.Click += new System.EventHandler(this.btnTafel4_Click);
            // 
            // btnTafel3
            // 
            this.btnTafel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTafel3.Location = new System.Drawing.Point(2, 221);
            this.btnTafel3.Name = "btnTafel3";
            this.btnTafel3.Size = new System.Drawing.Size(189, 118);
            this.btnTafel3.TabIndex = 9;
            this.btnTafel3.Text = "Tafel 3";
            this.btnTafel3.UseVisualStyleBackColor = true;
            this.btnTafel3.Click += new System.EventHandler(this.btnTafel3_Click);
            // 
            // btnTafel2
            // 
            this.btnTafel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTafel2.Location = new System.Drawing.Point(211, 85);
            this.btnTafel2.Name = "btnTafel2";
            this.btnTafel2.Size = new System.Drawing.Size(189, 118);
            this.btnTafel2.TabIndex = 8;
            this.btnTafel2.Text = "Tafel 2";
            this.btnTafel2.UseVisualStyleBackColor = true;
            this.btnTafel2.Click += new System.EventHandler(this.btnTafel2_Click);
            // 
            // btnTafel1
            // 
            this.btnTafel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTafel1.Location = new System.Drawing.Point(2, 85);
            this.btnTafel1.Name = "btnTafel1";
            this.btnTafel1.Size = new System.Drawing.Size(189, 118);
            this.btnTafel1.TabIndex = 7;
            this.btnTafel1.Text = "Tafel 1";
            this.btnTafel1.UseVisualStyleBackColor = true;
            this.btnTafel1.Click += new System.EventHandler(this.btnTafel1_Click);
            // 
            // pnl_Drank
            // 
            this.pnl_Drank.Controls.Add(this.btnKoffieThee);
            this.pnl_Drank.Controls.Add(this.btnGedestDrank);
            this.pnl_Drank.Controls.Add(this.btnFrisdrank);
            this.pnl_Drank.Controls.Add(this.btnBieren);
            this.pnl_Drank.Controls.Add(this.btnWijnen);
            this.pnl_Drank.Location = new System.Drawing.Point(12, 78);
            this.pnl_Drank.Name = "pnl_Drank";
            this.pnl_Drank.Size = new System.Drawing.Size(400, 343);
            this.pnl_Drank.TabIndex = 12;
            // 
            // btnKoffieThee
            // 
            this.btnKoffieThee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnKoffieThee.Location = new System.Drawing.Point(39, 283);
            this.btnKoffieThee.Name = "btnKoffieThee";
            this.btnKoffieThee.Size = new System.Drawing.Size(328, 60);
            this.btnKoffieThee.TabIndex = 12;
            this.btnKoffieThee.Text = "Koffie / Thee";
            this.btnKoffieThee.UseVisualStyleBackColor = true;
            this.btnKoffieThee.Click += new System.EventHandler(this.btnKoffieThee_Click);
            // 
            // btnGedestDrank
            // 
            this.btnGedestDrank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnGedestDrank.Location = new System.Drawing.Point(39, 217);
            this.btnGedestDrank.Name = "btnGedestDrank";
            this.btnGedestDrank.Size = new System.Drawing.Size(328, 60);
            this.btnGedestDrank.TabIndex = 11;
            this.btnGedestDrank.Text = "Gedestilleerde dranken";
            this.btnGedestDrank.UseVisualStyleBackColor = true;
            this.btnGedestDrank.Click += new System.EventHandler(this.btnGedestDrank_Click);
            // 
            // btnFrisdrank
            // 
            this.btnFrisdrank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnFrisdrank.Location = new System.Drawing.Point(39, 19);
            this.btnFrisdrank.Name = "btnFrisdrank";
            this.btnFrisdrank.Size = new System.Drawing.Size(328, 60);
            this.btnFrisdrank.TabIndex = 7;
            this.btnFrisdrank.Text = "Frisdrank";
            this.btnFrisdrank.UseVisualStyleBackColor = true;
            this.btnFrisdrank.Click += new System.EventHandler(this.btnFrisdrank_Click);
            // 
            // btnBieren
            // 
            this.btnBieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBieren.Location = new System.Drawing.Point(39, 85);
            this.btnBieren.Name = "btnBieren";
            this.btnBieren.Size = new System.Drawing.Size(328, 60);
            this.btnBieren.TabIndex = 8;
            this.btnBieren.Text = "Bieren";
            this.btnBieren.UseVisualStyleBackColor = true;
            this.btnBieren.Click += new System.EventHandler(this.btnBieren_Click);
            // 
            // btnWijnen
            // 
            this.btnWijnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnWijnen.Location = new System.Drawing.Point(39, 151);
            this.btnWijnen.Name = "btnWijnen";
            this.btnWijnen.Size = new System.Drawing.Size(328, 60);
            this.btnWijnen.TabIndex = 9;
            this.btnWijnen.Text = "Wijnen";
            this.btnWijnen.UseVisualStyleBackColor = true;
            this.btnWijnen.Click += new System.EventHandler(this.btnWijnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tafelnr:";
            // 
            // pnl_Tafelnr
            // 
            this.pnl_Tafelnr.Controls.Add(this.label1);
            this.pnl_Tafelnr.Controls.Add(this.lblTafelnr);
            this.pnl_Tafelnr.Location = new System.Drawing.Point(244, 3);
            this.pnl_Tafelnr.Name = "pnl_Tafelnr";
            this.pnl_Tafelnr.Size = new System.Drawing.Size(181, 65);
            this.pnl_Tafelnr.TabIndex = 13;
            // 
            // pnl_Klacht
            // 
            this.pnl_Klacht.Controls.Add(this.label3);
            this.pnl_Klacht.Controls.Add(this.txtKlacht);
            this.pnl_Klacht.Controls.Add(this.btnKaartoverzicht2);
            this.pnl_Klacht.Location = new System.Drawing.Point(12, 12);
            this.pnl_Klacht.Name = "pnl_Klacht";
            this.pnl_Klacht.Size = new System.Drawing.Size(400, 556);
            this.pnl_Klacht.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.Location = new System.Drawing.Point(23, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Vul klacht in";
            // 
            // txtKlacht
            // 
            this.txtKlacht.AcceptsReturn = true;
            this.txtKlacht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtKlacht.Location = new System.Drawing.Point(30, 85);
            this.txtKlacht.Multiline = true;
            this.txtKlacht.Name = "txtKlacht";
            this.txtKlacht.Size = new System.Drawing.Size(347, 327);
            this.txtKlacht.TabIndex = 11;
            this.txtKlacht.Text = "\r\n\r\n";
            // 
            // btnKaartoverzicht2
            // 
            this.btnKaartoverzicht2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnKaartoverzicht2.Location = new System.Drawing.Point(72, 463);
            this.btnKaartoverzicht2.Name = "btnKaartoverzicht2";
            this.btnKaartoverzicht2.Size = new System.Drawing.Size(247, 51);
            this.btnKaartoverzicht2.TabIndex = 10;
            this.btnKaartoverzicht2.Text = "< Kaartoverzicht";
            this.btnKaartoverzicht2.UseVisualStyleBackColor = true;
            this.btnKaartoverzicht2.Click += new System.EventHandler(this.btnKaartoverzicht2_Click);
            // 
            // pnl_Instructies
            // 
            this.pnl_Instructies.Controls.Add(this.label4);
            this.pnl_Instructies.Controls.Add(this.txtInstructies);
            this.pnl_Instructies.Controls.Add(this.btnKaartoverzicht3);
            this.pnl_Instructies.Location = new System.Drawing.Point(3, 15);
            this.pnl_Instructies.Name = "pnl_Instructies";
            this.pnl_Instructies.Size = new System.Drawing.Size(422, 556);
            this.pnl_Instructies.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(23, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 37);
            this.label4.TabIndex = 17;
            this.label4.Text = "Instructies";
            // 
            // txtInstructies
            // 
            this.txtInstructies.AcceptsReturn = true;
            this.txtInstructies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtInstructies.Location = new System.Drawing.Point(30, 85);
            this.txtInstructies.Multiline = true;
            this.txtInstructies.Name = "txtInstructies";
            this.txtInstructies.Size = new System.Drawing.Size(356, 327);
            this.txtInstructies.TabIndex = 11;
            this.txtInstructies.Text = "\r\n\r\n";
            // 
            // btnKaartoverzicht3
            // 
            this.btnKaartoverzicht3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnKaartoverzicht3.Location = new System.Drawing.Point(78, 460);
            this.btnKaartoverzicht3.Name = "btnKaartoverzicht3";
            this.btnKaartoverzicht3.Size = new System.Drawing.Size(247, 51);
            this.btnKaartoverzicht3.TabIndex = 10;
            this.btnKaartoverzicht3.Text = "< Kaartoverzicht";
            this.btnKaartoverzicht3.UseVisualStyleBackColor = true;
            this.btnKaartoverzicht3.Click += new System.EventHandler(this.btnKaartoverzicht3_Click);
            // 
            // BestellingOpnemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Instructies);
            this.Controls.Add(this.pnl_Tafelnr);
            this.Controls.Add(this.pnl_Klacht);
            this.Controls.Add(this.pnl_Drank);
            this.Controls.Add(this.pnl_TafelSelect);
            this.Controls.Add(this.pnl_MenuType);
            this.Controls.Add(this.pnl_Bestellen);
            this.Name = "BestellingOpnemen";
            this.Size = new System.Drawing.Size(428, 926);
            this.pnl_Bestellen.ResumeLayout(false);
            this.pnl_Bestellen.PerformLayout();
            this.pnl_MenuType.ResumeLayout(false);
            this.pnl_TafelSelect.ResumeLayout(false);
            this.pnl_TafelSelect.PerformLayout();
            this.pnl_Drank.ResumeLayout(false);
            this.pnl_Tafelnr.ResumeLayout(false);
            this.pnl_Tafelnr.PerformLayout();
            this.pnl_Klacht.ResumeLayout(false);
            this.pnl_Klacht.PerformLayout();
            this.pnl_Instructies.ResumeLayout(false);
            this.pnl_Instructies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listMenuView;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnRemoveFromOrder;
        private System.Windows.Forms.ListView listOrderView;
        private System.Windows.Forms.Panel pnl_Bestellen;
        private System.Windows.Forms.Button btnKaartOverzicht;
        private System.Windows.Forms.Panel pnl_MenuType;
        private System.Windows.Forms.Button btnTafelOverzicht;
        private System.Windows.Forms.Label lblTafelnr;
        private System.Windows.Forms.Button btnHoofdgerecht;
        private System.Windows.Forms.Button btnVoorgerecht;
        private System.Windows.Forms.Button btnDrankKaart;
        private System.Windows.Forms.Panel pnl_TafelSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTafel10;
        private System.Windows.Forms.Button btnTafel9;
        private System.Windows.Forms.Button btnTafel8;
        private System.Windows.Forms.Button btnTafel7;
        private System.Windows.Forms.Button btnTafel6;
        private System.Windows.Forms.Button btnTafel5;
        private System.Windows.Forms.Button btnTafel4;
        private System.Windows.Forms.Button btnTafel3;
        private System.Windows.Forms.Button btnTafel2;
        private System.Windows.Forms.Button btnTafel1;
        private System.Windows.Forms.Button btnTussengerecht;
        private System.Windows.Forms.Panel pnl_Drank;
        private System.Windows.Forms.Button btnKoffieThee;
        private System.Windows.Forms.Button btnGedestDrank;
        private System.Windows.Forms.Button btnFrisdrank;
        private System.Windows.Forms.Button btnBieren;
        private System.Windows.Forms.Button btnWijnen;
        private System.Windows.Forms.Button btnNagerecht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Tafelnr;
        private System.Windows.Forms.Button btnInstructies;
        private System.Windows.Forms.Button btnKlacht;
        private System.Windows.Forms.Panel pnl_Klacht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKlacht;
        private System.Windows.Forms.Button btnKaartoverzicht2;
        private System.Windows.Forms.Panel pnl_Instructies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInstructies;
        private System.Windows.Forms.Button btnKaartoverzicht3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
    }
}