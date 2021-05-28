
namespace Login
{
    partial class MenuChange
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
            this.pnl_MenuChange = new System.Windows.Forms.Panel();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cbox_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Instruction = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.flp_MenuOverview = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_GekozenKaart = new System.Windows.Forms.Label();
            this.pnl_MenuChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_MenuChange
            // 
            this.pnl_MenuChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_MenuChange.Controls.Add(this.lbl_GekozenKaart);
            this.pnl_MenuChange.Controls.Add(this.btn_Close);
            this.pnl_MenuChange.Controls.Add(this.lbl_Menu);
            this.pnl_MenuChange.Controls.Add(this.btn_Add);
            this.pnl_MenuChange.Controls.Add(this.cbox_Category);
            this.pnl_MenuChange.Controls.Add(this.lbl_Category);
            this.pnl_MenuChange.Controls.Add(this.lbl_Instruction);
            this.pnl_MenuChange.Controls.Add(this.btn_Search);
            this.pnl_MenuChange.Controls.Add(this.tb_Search);
            this.pnl_MenuChange.Controls.Add(this.flp_MenuOverview);
            this.pnl_MenuChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MenuChange.Location = new System.Drawing.Point(0, 0);
            this.pnl_MenuChange.Name = "pnl_MenuChange";
            this.pnl_MenuChange.Size = new System.Drawing.Size(884, 461);
            this.pnl_MenuChange.TabIndex = 0;
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Roboto Condensed", 15F);
            this.lbl_Menu.Location = new System.Drawing.Point(147, 12);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(53, 24);
            this.lbl_Menu.TabIndex = 22;
            this.lbl_Menu.Text = "Kaart";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(738, 404);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(134, 48);
            this.btn_Add.TabIndex = 21;
            this.btn_Add.TabStop = false;
            this.btn_Add.Text = "Add product";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cbox_Category
            // 
            this.cbox_Category.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Category.FormattingEnabled = true;
            this.cbox_Category.Location = new System.Drawing.Point(118, 427);
            this.cbox_Category.Name = "cbox_Category";
            this.cbox_Category.Size = new System.Drawing.Size(131, 27);
            this.cbox_Category.TabIndex = 20;
            this.cbox_Category.DropDown += new System.EventHandler(this.cbox_Category_DropDown);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(10, 430);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(102, 19);
            this.lbl_Category.TabIndex = 19;
            this.lbl_Category.Text = "Kies categorie";
            // 
            // lbl_Instruction
            // 
            this.lbl_Instruction.AutoSize = true;
            this.lbl_Instruction.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instruction.Location = new System.Drawing.Point(10, 401);
            this.lbl_Instruction.Name = "lbl_Instruction";
            this.lbl_Instruction.Size = new System.Drawing.Size(239, 19);
            this.lbl_Instruction.TabIndex = 18;
            this.lbl_Instruction.Text = "Kies product om toe te voegen aan ";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(437, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(79, 27);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.Location = new System.Drawing.Point(522, 9);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(348, 27);
            this.tb_Search.TabIndex = 16;
            this.tb_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyDown);
            this.tb_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyUp);
            // 
            // flp_MenuOverview
            // 
            this.flp_MenuOverview.AutoScroll = true;
            this.flp_MenuOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_MenuOverview.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_MenuOverview.Location = new System.Drawing.Point(12, 39);
            this.flp_MenuOverview.Name = "flp_MenuOverview";
            this.flp_MenuOverview.Size = new System.Drawing.Size(860, 359);
            this.flp_MenuOverview.TabIndex = 13;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(598, 404);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(134, 48);
            this.btn_Close.TabIndex = 23;
            this.btn_Close.TabStop = false;
            this.btn_Close.Text = "Sluiten";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_GekozenKaart
            // 
            this.lbl_GekozenKaart.AutoSize = true;
            this.lbl_GekozenKaart.Font = new System.Drawing.Font("Roboto Condensed", 15F);
            this.lbl_GekozenKaart.Location = new System.Drawing.Point(12, 12);
            this.lbl_GekozenKaart.Name = "lbl_GekozenKaart";
            this.lbl_GekozenKaart.Size = new System.Drawing.Size(140, 24);
            this.lbl_GekozenKaart.TabIndex = 24;
            this.lbl_GekozenKaart.Text = "Toevoegen aan: ";
            // 
            // MenuChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pnl_MenuChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Aanpassen";
            this.Load += new System.EventHandler(this.MenuChange_Load);
            this.pnl_MenuChange.ResumeLayout(false);
            this.pnl_MenuChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MenuChange;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cbox_Category;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Instruction;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.FlowLayoutPanel flp_MenuOverview;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_GekozenKaart;
    }
}