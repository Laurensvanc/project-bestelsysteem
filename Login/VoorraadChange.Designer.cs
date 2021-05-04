
namespace Login
{
    partial class VoorraadChange
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
            this.pnl_VoorraadChange = new System.Windows.Forms.Panel();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.lbl_TypeTxt = new System.Windows.Forms.Label();
            this.cbox_Type = new System.Windows.Forms.ComboBox();
            this.cb_Alcoholic = new System.Windows.Forms.CheckBox();
            this.lbl_AlcoholicTxt = new System.Windows.Forms.Label();
            this.nud_Amount = new System.Windows.Forms.NumericUpDown();
            this.lbl_AmountTxt = new System.Windows.Forms.Label();
            this.tb_PurchasePrice = new System.Windows.Forms.TextBox();
            this.lbl_PurchasePriceTxt = new System.Windows.Forms.Label();
            this.tb_MenuPrice = new System.Windows.Forms.TextBox();
            this.lbl_MenuPriceTxt = new System.Windows.Forms.Label();
            this.tb_ProductName = new System.Windows.Forms.TextBox();
            this.lbl_ProductIDValue = new System.Windows.Forms.Label();
            this.lbl_ProductNameTxt = new System.Windows.Forms.Label();
            this.lbl_ProductIDTxt = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_ChangeBtn = new System.Windows.Forms.Panel();
            this.pnl_AddBtn = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pnl_VoorraadChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnl_ChangeBtn.SuspendLayout();
            this.pnl_AddBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_VoorraadChange
            // 
            this.pnl_VoorraadChange.Controls.Add(this.pnl_ChangeBtn);
            this.pnl_VoorraadChange.Controls.Add(this.pnl_AddBtn);
            this.pnl_VoorraadChange.Controls.Add(this.lbl_TypeTxt);
            this.pnl_VoorraadChange.Controls.Add(this.cbox_Type);
            this.pnl_VoorraadChange.Controls.Add(this.cb_Alcoholic);
            this.pnl_VoorraadChange.Controls.Add(this.lbl_AlcoholicTxt);
            this.pnl_VoorraadChange.Controls.Add(this.nud_Amount);
            this.pnl_VoorraadChange.Controls.Add(this.lbl_AmountTxt);
            this.pnl_VoorraadChange.Controls.Add(this.tb_PurchasePrice);
            this.pnl_VoorraadChange.Controls.Add(this.lbl_PurchasePriceTxt);
            this.pnl_VoorraadChange.Controls.Add(this.tb_MenuPrice);
            this.pnl_VoorraadChange.Controls.Add(this.lbl_MenuPriceTxt);
            this.pnl_VoorraadChange.Controls.Add(this.tb_ProductName);
            this.pnl_VoorraadChange.Controls.Add(this.lbl_ProductIDValue);
            this.pnl_VoorraadChange.Controls.Add(this.lbl_ProductNameTxt);
            this.pnl_VoorraadChange.Controls.Add(this.lbl_ProductIDTxt);
            this.pnl_VoorraadChange.Location = new System.Drawing.Point(12, 12);
            this.pnl_VoorraadChange.Name = "pnl_VoorraadChange";
            this.pnl_VoorraadChange.Size = new System.Drawing.Size(373, 240);
            this.pnl_VoorraadChange.TabIndex = 0;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(188, 8);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 8;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(44, 8);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 7;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // lbl_TypeTxt
            // 
            this.lbl_TypeTxt.AutoSize = true;
            this.lbl_TypeTxt.Location = new System.Drawing.Point(7, 149);
            this.lbl_TypeTxt.Name = "lbl_TypeTxt";
            this.lbl_TypeTxt.Size = new System.Drawing.Size(38, 13);
            this.lbl_TypeTxt.TabIndex = 13;
            this.lbl_TypeTxt.Text = "Soort: ";
            // 
            // cbox_Type
            // 
            this.cbox_Type.FormattingEnabled = true;
            this.cbox_Type.Items.AddRange(new object[] {
            "Eten",
            "Drinken"});
            this.cbox_Type.Location = new System.Drawing.Point(122, 146);
            this.cbox_Type.Name = "cbox_Type";
            this.cbox_Type.Size = new System.Drawing.Size(121, 21);
            this.cbox_Type.TabIndex = 6;
            // 
            // cb_Alcoholic
            // 
            this.cb_Alcoholic.AutoSize = true;
            this.cb_Alcoholic.Location = new System.Drawing.Point(122, 127);
            this.cb_Alcoholic.Name = "cb_Alcoholic";
            this.cb_Alcoholic.Size = new System.Drawing.Size(15, 14);
            this.cb_Alcoholic.TabIndex = 5;
            this.cb_Alcoholic.UseVisualStyleBackColor = true;
            // 
            // lbl_AlcoholicTxt
            // 
            this.lbl_AlcoholicTxt.AutoSize = true;
            this.lbl_AlcoholicTxt.Location = new System.Drawing.Point(7, 127);
            this.lbl_AlcoholicTxt.Name = "lbl_AlcoholicTxt";
            this.lbl_AlcoholicTxt.Size = new System.Drawing.Size(67, 13);
            this.lbl_AlcoholicTxt.TabIndex = 10;
            this.lbl_AlcoholicTxt.Text = "Alcoholisch: ";
            // 
            // nud_Amount
            // 
            this.nud_Amount.Location = new System.Drawing.Point(122, 103);
            this.nud_Amount.Name = "nud_Amount";
            this.nud_Amount.Size = new System.Drawing.Size(66, 20);
            this.nud_Amount.TabIndex = 4;
            this.nud_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_AmountTxt
            // 
            this.lbl_AmountTxt.AutoSize = true;
            this.lbl_AmountTxt.Location = new System.Drawing.Point(7, 105);
            this.lbl_AmountTxt.Name = "lbl_AmountTxt";
            this.lbl_AmountTxt.Size = new System.Drawing.Size(43, 13);
            this.lbl_AmountTxt.TabIndex = 8;
            this.lbl_AmountTxt.Text = "Aantal: ";
            // 
            // tb_PurchasePrice
            // 
            this.tb_PurchasePrice.Location = new System.Drawing.Point(122, 80);
            this.tb_PurchasePrice.Name = "tb_PurchasePrice";
            this.tb_PurchasePrice.Size = new System.Drawing.Size(66, 20);
            this.tb_PurchasePrice.TabIndex = 3;
            this.tb_PurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_PurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PurchasePrice_KeyPress);
            this.tb_PurchasePrice.Validating += new System.ComponentModel.CancelEventHandler(this.tb_PurchasePrice_Validating);
            // 
            // lbl_PurchasePriceTxt
            // 
            this.lbl_PurchasePriceTxt.AutoSize = true;
            this.lbl_PurchasePriceTxt.Location = new System.Drawing.Point(7, 83);
            this.lbl_PurchasePriceTxt.Name = "lbl_PurchasePriceTxt";
            this.lbl_PurchasePriceTxt.Size = new System.Drawing.Size(83, 13);
            this.lbl_PurchasePriceTxt.TabIndex = 6;
            this.lbl_PurchasePriceTxt.Text = "Inkoop Prijs (€): ";
            // 
            // tb_MenuPrice
            // 
            this.tb_MenuPrice.Location = new System.Drawing.Point(122, 58);
            this.tb_MenuPrice.Name = "tb_MenuPrice";
            this.tb_MenuPrice.Size = new System.Drawing.Size(66, 20);
            this.tb_MenuPrice.TabIndex = 2;
            this.tb_MenuPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_MenuPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_MenuPrice_KeyPress);
            this.tb_MenuPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tb_MenuPrice_Validating);
            // 
            // lbl_MenuPriceTxt
            // 
            this.lbl_MenuPriceTxt.AutoSize = true;
            this.lbl_MenuPriceTxt.Location = new System.Drawing.Point(7, 61);
            this.lbl_MenuPriceTxt.Name = "lbl_MenuPriceTxt";
            this.lbl_MenuPriceTxt.Size = new System.Drawing.Size(90, 13);
            this.lbl_MenuPriceTxt.TabIndex = 4;
            this.lbl_MenuPriceTxt.Text = "Verkoop Prijs (€): ";
            // 
            // tb_ProductName
            // 
            this.tb_ProductName.Location = new System.Drawing.Point(122, 36);
            this.tb_ProductName.Name = "tb_ProductName";
            this.tb_ProductName.Size = new System.Drawing.Size(222, 20);
            this.tb_ProductName.TabIndex = 1;
            this.tb_ProductName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ProductName_Validating);
            // 
            // lbl_ProductIDValue
            // 
            this.lbl_ProductIDValue.AutoSize = true;
            this.lbl_ProductIDValue.Location = new System.Drawing.Point(122, 17);
            this.lbl_ProductIDValue.Name = "lbl_ProductIDValue";
            this.lbl_ProductIDValue.Size = new System.Drawing.Size(33, 13);
            this.lbl_ProductIDValue.TabIndex = 1;
            this.lbl_ProductIDValue.Text = "value";
            // 
            // lbl_ProductNameTxt
            // 
            this.lbl_ProductNameTxt.AutoSize = true;
            this.lbl_ProductNameTxt.Location = new System.Drawing.Point(7, 39);
            this.lbl_ProductNameTxt.Name = "lbl_ProductNameTxt";
            this.lbl_ProductNameTxt.Size = new System.Drawing.Size(81, 13);
            this.lbl_ProductNameTxt.TabIndex = 2;
            this.lbl_ProductNameTxt.Text = "Product Naam: ";
            // 
            // lbl_ProductIDTxt
            // 
            this.lbl_ProductIDTxt.AutoSize = true;
            this.lbl_ProductIDTxt.Location = new System.Drawing.Point(7, 17);
            this.lbl_ProductIDTxt.Name = "lbl_ProductIDTxt";
            this.lbl_ProductIDTxt.Size = new System.Drawing.Size(61, 13);
            this.lbl_ProductIDTxt.TabIndex = 0;
            this.lbl_ProductIDTxt.Text = "ProductID: ";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pnl_ChangeBtn
            // 
            this.pnl_ChangeBtn.Controls.Add(this.btn_Remove);
            this.pnl_ChangeBtn.Controls.Add(this.btn_Change);
            this.pnl_ChangeBtn.Location = new System.Drawing.Point(34, 182);
            this.pnl_ChangeBtn.Name = "pnl_ChangeBtn";
            this.pnl_ChangeBtn.Size = new System.Drawing.Size(308, 39);
            this.pnl_ChangeBtn.TabIndex = 14;
            // 
            // pnl_AddBtn
            // 
            this.pnl_AddBtn.Controls.Add(this.btn_Add);
            this.pnl_AddBtn.Location = new System.Drawing.Point(34, 182);
            this.pnl_AddBtn.Name = "pnl_AddBtn";
            this.pnl_AddBtn.Size = new System.Drawing.Size(308, 39);
            this.pnl_AddBtn.TabIndex = 15;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(107, 8);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // VoorraadChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 264);
            this.Controls.Add(this.pnl_VoorraadChange);
            this.MinimizeBox = false;
            this.Name = "VoorraadChange";
            this.Text = "Voorraad veranderen";
            this.pnl_VoorraadChange.ResumeLayout(false);
            this.pnl_VoorraadChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnl_ChangeBtn.ResumeLayout(false);
            this.pnl_AddBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_VoorraadChange;
        private System.Windows.Forms.Label lbl_ProductNameTxt;
        private System.Windows.Forms.Label lbl_ProductIDValue;
        private System.Windows.Forms.Label lbl_ProductIDTxt;
        private System.Windows.Forms.Label lbl_MenuPriceTxt;
        private System.Windows.Forms.Label lbl_PurchasePriceTxt;
        private System.Windows.Forms.TextBox tb_PurchasePrice;
        private System.Windows.Forms.Label lbl_AlcoholicTxt;
        private System.Windows.Forms.NumericUpDown nud_Amount;
        private System.Windows.Forms.Label lbl_AmountTxt;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Label lbl_TypeTxt;
        private System.Windows.Forms.ComboBox cbox_Type;
        private System.Windows.Forms.CheckBox cb_Alcoholic;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tb_MenuPrice;
        private System.Windows.Forms.TextBox tb_ProductName;
        private System.Windows.Forms.Panel pnl_ChangeBtn;
        private System.Windows.Forms.Panel pnl_AddBtn;
        private System.Windows.Forms.Button btn_Add;
    }
}