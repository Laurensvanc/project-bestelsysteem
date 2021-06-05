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
            this.lbl_Instruction = new System.Windows.Forms.Label();
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
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_VoorraadOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_VoorraadOverview
            // 
            this.pnl_VoorraadOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_VoorraadOverview.BackColor = System.Drawing.Color.White;
            this.pnl_VoorraadOverview.Controls.Add(this.lbl_Instruction);
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
            this.pnl_VoorraadOverview.Size = new System.Drawing.Size(1576, 942);
            this.pnl_VoorraadOverview.TabIndex = 0;
            // 
            // lbl_Instruction
            // 
            this.lbl_Instruction.AutoSize = true;
            this.lbl_Instruction.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.lbl_Instruction.Location = new System.Drawing.Point(240, 11);
            this.lbl_Instruction.Name = "lbl_Instruction";
            this.lbl_Instruction.Size = new System.Drawing.Size(391, 23);
            this.lbl_Instruction.TabIndex = 8;
            this.lbl_Instruction.Text = "Dubbel klik een product voor meer informatie";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(663, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(123, 32);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.tb_Search.Location = new System.Drawing.Point(792, 6);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(766, 30);
            this.tb_Search.TabIndex = 6;
            this.tb_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyDown);
            this.tb_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyUp);
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_Change.FlatAppearance.BorderSize = 0;
            this.btn_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Change.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.btn_Change.ForeColor = System.Drawing.Color.White;
            this.btn_Change.Location = new System.Drawing.Point(439, 831);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(220, 60);
            this.btn_Change.TabIndex = 2;
            this.btn_Change.Text = "Aanpassen/Verwijderen";
            this.btn_Change.UseVisualStyleBackColor = false;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(196, 831);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(220, 60);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Toevoegen";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Showing
            // 
            this.lbl_Showing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Showing.AutoSize = true;
            this.lbl_Showing.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.lbl_Showing.Location = new System.Drawing.Point(8, 11);
            this.lbl_Showing.Name = "lbl_Showing";
            this.lbl_Showing.Size = new System.Drawing.Size(47, 23);
            this.lbl_Showing.TabIndex = 3;
            this.lbl_Showing.Text = "Eten";
            // 
            // btn_Toggle
            // 
            this.btn_Toggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_Toggle.FlatAppearance.BorderSize = 0;
            this.btn_Toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Toggle.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.btn_Toggle.ForeColor = System.Drawing.Color.White;
            this.btn_Toggle.Location = new System.Drawing.Point(101, 6);
            this.btn_Toggle.Name = "btn_Toggle";
            this.btn_Toggle.Size = new System.Drawing.Size(123, 32);
            this.btn_Toggle.TabIndex = 5;
            this.btn_Toggle.Text = "Show drinks";
            this.btn_Toggle.UseVisualStyleBackColor = false;
            this.btn_Toggle.Click += new System.EventHandler(this.btn_Toggle_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1170, 831);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(220, 60);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Lijst Verversen";
            this.btn_Refresh.UseVisualStyleBackColor = false;
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
            this.ch2,
            this.ch3,
            this.ch4});
            this.lv_Voorraad.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.lv_Voorraad.HideSelection = false;
            this.lv_Voorraad.Location = new System.Drawing.Point(12, 43);
            this.lv_Voorraad.Name = "lv_Voorraad";
            this.lv_Voorraad.OwnerDraw = true;
            this.lv_Voorraad.Size = new System.Drawing.Size(1546, 750);
            this.lv_Voorraad.TabIndex = 0;
            this.lv_Voorraad.UseCompatibleStateImageBehavior = false;
            this.lv_Voorraad.View = System.Windows.Forms.View.Details;
            this.lv_Voorraad.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_Voorraad_ColumnClick);
            this.lv_Voorraad.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lv_Voorraad_DrawColumnHeader);
            this.lv_Voorraad.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lv_Voorraad_DrawItem);
            this.lv_Voorraad.DoubleClick += new System.EventHandler(this.lv_Voorraad_DoubleClick);
            // 
            // ch0
            // 
            this.ch0.Text = "ID";
            this.ch0.Width = 50;
            // 
            // ch1
            // 
            this.ch1.Text = "Product Naam";
            this.ch1.Width = 1070;
            // 
            // ch2
            // 
            this.ch2.Text = "Inkoop Prijs";
            this.ch2.Width = 135;
            // 
            // ch3
            // 
            this.ch3.Text = "Verkoop Prijs/Winst";
            this.ch3.Width = 150;
            // 
            // ch4
            // 
            this.ch4.Text = "Aantal";
            this.ch4.Width = 120;
            // 
            // VoorraadOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_VoorraadOverview);
            this.Name = "VoorraadOverview";
            this.Size = new System.Drawing.Size(1576, 942);
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
        private System.Windows.Forms.ColumnHeader ch4;
        private System.Windows.Forms.Button btn_Toggle;
        private System.Windows.Forms.Label lbl_Showing;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Instruction;
        private System.Windows.Forms.ColumnHeader ch2;
        private System.Windows.Forms.ColumnHeader ch3;
    }
}