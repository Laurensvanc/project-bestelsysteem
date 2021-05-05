
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.cbox_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Instruction = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.flp_MenuOverview = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.pnl_MenuChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_MenuChange
            // 
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
            this.pnl_MenuChange.Size = new System.Drawing.Size(721, 393);
            this.pnl_MenuChange.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(599, 348);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 35);
            this.btn_Add.TabIndex = 21;
            this.btn_Add.TabStop = false;
            this.btn_Add.Text = "Add product";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cbox_Category
            // 
            this.cbox_Category.FormattingEnabled = true;
            this.cbox_Category.Location = new System.Drawing.Point(128, 366);
            this.cbox_Category.Name = "cbox_Category";
            this.cbox_Category.Size = new System.Drawing.Size(138, 21);
            this.cbox_Category.TabIndex = 20;
            this.cbox_Category.DropDown += new System.EventHandler(this.cbox_Category_DropDown);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(10, 366);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(112, 17);
            this.lbl_Category.TabIndex = 19;
            this.lbl_Category.Text = "Kies categorie";
            // 
            // lbl_Instruction
            // 
            this.lbl_Instruction.AutoSize = true;
            this.lbl_Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instruction.Location = new System.Drawing.Point(10, 345);
            this.lbl_Instruction.Name = "lbl_Instruction";
            this.lbl_Instruction.Size = new System.Drawing.Size(267, 17);
            this.lbl_Instruction.TabIndex = 18;
            this.lbl_Instruction.Text = "Kies product om toe te voegen aan ";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(444, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Location = new System.Drawing.Point(525, 6);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(187, 20);
            this.tb_Search.TabIndex = 16;
            this.tb_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyDown);
            this.tb_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyUp);
            // 
            // flp_MenuOverview
            // 
            this.flp_MenuOverview.AutoScroll = true;
            this.flp_MenuOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_MenuOverview.Location = new System.Drawing.Point(12, 29);
            this.flp_MenuOverview.Name = "flp_MenuOverview";
            this.flp_MenuOverview.Size = new System.Drawing.Size(700, 313);
            this.flp_MenuOverview.TabIndex = 13;
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.Location = new System.Drawing.Point(12, 7);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(47, 17);
            this.lbl_Menu.TabIndex = 22;
            this.lbl_Menu.Text = "Kaart";
            // 
            // MenuChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 393);
            this.Controls.Add(this.pnl_MenuChange);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuChange";
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
    }
}