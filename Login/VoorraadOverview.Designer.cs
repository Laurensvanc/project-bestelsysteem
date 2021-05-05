namespace Login
{
    partial class VoorraadOverview
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
            this.pnl_VoorraadOverview = new System.Windows.Forms.Panel();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Showing = new System.Windows.Forms.Label();
            this.btn_Toggle = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lv_Voorraad = new System.Windows.Forms.ListView();
            this.ch0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_VoorraadOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_VoorraadOverview
            // 
            this.pnl_VoorraadOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_VoorraadOverview.Controls.Add(this.btn_Menu);
            this.pnl_VoorraadOverview.Controls.Add(this.btn_Search);
            this.pnl_VoorraadOverview.Controls.Add(this.tb_Search);
            this.pnl_VoorraadOverview.Controls.Add(this.btn_Change);
            this.pnl_VoorraadOverview.Controls.Add(this.btn_Add);
            this.pnl_VoorraadOverview.Controls.Add(this.lbl_Showing);
            this.pnl_VoorraadOverview.Controls.Add(this.btn_Toggle);
            this.pnl_VoorraadOverview.Controls.Add(this.btn_Refresh);
            this.pnl_VoorraadOverview.Controls.Add(this.lv_Voorraad);
            this.pnl_VoorraadOverview.Location = new System.Drawing.Point(0, 0);
            this.pnl_VoorraadOverview.Name = "pnl_VoorraadOverview";
            this.pnl_VoorraadOverview.Size = new System.Drawing.Size(800, 450);
            this.pnl_VoorraadOverview.TabIndex = 0;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(500, 386);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(113, 34);
            this.btn_Menu.TabIndex = 3;
            this.btn_Menu.Text = "Menu Overview";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(534, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Location = new System.Drawing.Point(615, 14);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(167, 20);
            this.tb_Search.TabIndex = 6;
            this.tb_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyDown);
            this.tb_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyUp);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(182, 386);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(113, 34);
            this.btn_Change.TabIndex = 2;
            this.btn_Change.Text = "Change/Remove";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(28, 386);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(113, 34);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Showing
            // 
            this.lbl_Showing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Showing.AutoSize = true;
            this.lbl_Showing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Showing.Location = new System.Drawing.Point(12, 16);
            this.lbl_Showing.Name = "lbl_Showing";
            this.lbl_Showing.Size = new System.Drawing.Size(41, 17);
            this.lbl_Showing.TabIndex = 3;
            this.lbl_Showing.Text = "Eten";
            // 
            // btn_Toggle
            // 
            this.btn_Toggle.Location = new System.Drawing.Point(132, 12);
            this.btn_Toggle.Name = "btn_Toggle";
            this.btn_Toggle.Size = new System.Drawing.Size(75, 23);
            this.btn_Toggle.TabIndex = 5;
            this.btn_Toggle.Text = "Show drinks";
            this.btn_Toggle.UseVisualStyleBackColor = true;
            this.btn_Toggle.Click += new System.EventHandler(this.btn_Toggle_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(654, 386);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(113, 34);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lv_Voorraad
            // 
            this.lv_Voorraad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Voorraad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch0,
            this.ch1,
            this.ch2});
            this.lv_Voorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Voorraad.HideSelection = false;
            this.lv_Voorraad.Location = new System.Drawing.Point(12, 36);
            this.lv_Voorraad.Name = "lv_Voorraad";
            this.lv_Voorraad.Size = new System.Drawing.Size(770, 330);
            this.lv_Voorraad.TabIndex = 0;
            this.lv_Voorraad.UseCompatibleStateImageBehavior = false;
            this.lv_Voorraad.View = System.Windows.Forms.View.Details;
            // 
            // ch0
            // 
            this.ch0.Text = "ID";
            this.ch0.Width = 50;
            // 
            // ch1
            // 
            this.ch1.Text = "Product Naam";
            this.ch1.Width = 637;
            // 
            // ch2
            // 
            this.ch2.Text = "Aantal";
            this.ch2.Width = 120;
            // 
            // VoorraadOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_VoorraadOverview);
            this.Name = "VoorraadOverview";
            this.Text = "Voorraad Overview";
            this.Load += new System.EventHandler(this.VoorraadOverview_Load);
            this.pnl_VoorraadOverview.ResumeLayout(false);
            this.pnl_VoorraadOverview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_VoorraadOverview;
        private System.Windows.Forms.ListView lv_Voorraad;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ColumnHeader ch0;
        private System.Windows.Forms.ColumnHeader ch1;
        private System.Windows.Forms.ColumnHeader ch2;
        private System.Windows.Forms.Button btn_Toggle;
        private System.Windows.Forms.Label lbl_Showing;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Menu;
    }
}