﻿
namespace Login
{
    partial class MenuOverview
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
            this.pnl_MenuOverview = new System.Windows.Forms.Panel();
            this.pnl_MenuDinerButtons = new System.Windows.Forms.Panel();
            this.btn_DinerT = new System.Windows.Forms.Button();
            this.btn_DinerH = new System.Windows.Forms.Button();
            this.btn_DinerN = new System.Windows.Forms.Button();
            this.btn_DinerV = new System.Windows.Forms.Button();
            this.pnl_MenuDrankButtons = new System.Windows.Forms.Panel();
            this.btn_DrankB = new System.Windows.Forms.Button();
            this.btn_DrankW = new System.Windows.Forms.Button();
            this.btn_DrankK = new System.Windows.Forms.Button();
            this.btn_DrankG = new System.Windows.Forms.Button();
            this.btn_DrankF = new System.Windows.Forms.Button();
            this.pnl_MenuLunchButtons = new System.Windows.Forms.Panel();
            this.btn_LunchH = new System.Windows.Forms.Button();
            this.btn_LunchN = new System.Windows.Forms.Button();
            this.btn_LunchV = new System.Windows.Forms.Button();
            this.pnl_ActionButtons = new System.Windows.Forms.Panel();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pnl_MenuButtons = new System.Windows.Forms.Panel();
            this.btn_Drank = new System.Windows.Forms.Button();
            this.btn_Diner = new System.Windows.Forms.Button();
            this.btn_Lunch = new System.Windows.Forms.Button();
            this.flp_MenuOverview = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Instruction = new System.Windows.Forms.Label();
            this.lbl_Instruction2 = new System.Windows.Forms.Label();
            this.pnl_MenuOverview.SuspendLayout();
            this.pnl_MenuDinerButtons.SuspendLayout();
            this.pnl_MenuDrankButtons.SuspendLayout();
            this.pnl_MenuLunchButtons.SuspendLayout();
            this.pnl_ActionButtons.SuspendLayout();
            this.pnl_MenuButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_MenuOverview
            // 
            this.pnl_MenuOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_MenuOverview.AutoSize = true;
            this.pnl_MenuOverview.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_MenuOverview.Controls.Add(this.lbl_Instruction2);
            this.pnl_MenuOverview.Controls.Add(this.lbl_Instruction);
            this.pnl_MenuOverview.Controls.Add(this.pnl_MenuDinerButtons);
            this.pnl_MenuOverview.Controls.Add(this.pnl_MenuDrankButtons);
            this.pnl_MenuOverview.Controls.Add(this.pnl_MenuLunchButtons);
            this.pnl_MenuOverview.Controls.Add(this.flp_MenuOverview);
            this.pnl_MenuOverview.Controls.Add(this.pnl_ActionButtons);
            this.pnl_MenuOverview.Controls.Add(this.pnl_MenuButtons);
            this.pnl_MenuOverview.Location = new System.Drawing.Point(0, 0);
            this.pnl_MenuOverview.Name = "pnl_MenuOverview";
            this.pnl_MenuOverview.Size = new System.Drawing.Size(800, 450);
            this.pnl_MenuOverview.TabIndex = 0;
            // 
            // pnl_MenuDinerButtons
            // 
            this.pnl_MenuDinerButtons.Controls.Add(this.btn_DinerT);
            this.pnl_MenuDinerButtons.Controls.Add(this.btn_DinerH);
            this.pnl_MenuDinerButtons.Controls.Add(this.btn_DinerN);
            this.pnl_MenuDinerButtons.Controls.Add(this.btn_DinerV);
            this.pnl_MenuDinerButtons.Location = new System.Drawing.Point(144, 253);
            this.pnl_MenuDinerButtons.Name = "pnl_MenuDinerButtons";
            this.pnl_MenuDinerButtons.Size = new System.Drawing.Size(632, 51);
            this.pnl_MenuDinerButtons.TabIndex = 1;
            // 
            // btn_DinerT
            // 
            this.btn_DinerT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DinerT.Location = new System.Drawing.Point(198, 3);
            this.btn_DinerT.Name = "btn_DinerT";
            this.btn_DinerT.Size = new System.Drawing.Size(120, 45);
            this.btn_DinerT.TabIndex = 2;
            this.btn_DinerT.TabStop = false;
            this.btn_DinerT.Text = "Tussengerechten";
            this.btn_DinerT.UseVisualStyleBackColor = true;
            this.btn_DinerT.Click += new System.EventHandler(this.btn_DinerT_Click);
            // 
            // btn_DinerH
            // 
            this.btn_DinerH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DinerH.Location = new System.Drawing.Point(324, 3);
            this.btn_DinerH.Name = "btn_DinerH";
            this.btn_DinerH.Size = new System.Drawing.Size(120, 45);
            this.btn_DinerH.TabIndex = 2;
            this.btn_DinerH.TabStop = false;
            this.btn_DinerH.Text = "Hoofdgerechten";
            this.btn_DinerH.UseVisualStyleBackColor = true;
            this.btn_DinerH.Click += new System.EventHandler(this.btn_DinerH_Click);
            // 
            // btn_DinerN
            // 
            this.btn_DinerN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DinerN.Location = new System.Drawing.Point(450, 3);
            this.btn_DinerN.Name = "btn_DinerN";
            this.btn_DinerN.Size = new System.Drawing.Size(120, 45);
            this.btn_DinerN.TabIndex = 2;
            this.btn_DinerN.TabStop = false;
            this.btn_DinerN.Text = "Nagerechten";
            this.btn_DinerN.UseVisualStyleBackColor = true;
            this.btn_DinerN.Click += new System.EventHandler(this.btn_DinerN_Click);
            // 
            // btn_DinerV
            // 
            this.btn_DinerV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DinerV.Location = new System.Drawing.Point(72, 3);
            this.btn_DinerV.Name = "btn_DinerV";
            this.btn_DinerV.Size = new System.Drawing.Size(120, 45);
            this.btn_DinerV.TabIndex = 2;
            this.btn_DinerV.TabStop = false;
            this.btn_DinerV.Text = "Voorgerechten";
            this.btn_DinerV.UseVisualStyleBackColor = true;
            this.btn_DinerV.Click += new System.EventHandler(this.btn_DinerV_Click);
            // 
            // pnl_MenuDrankButtons
            // 
            this.pnl_MenuDrankButtons.Controls.Add(this.btn_DrankB);
            this.pnl_MenuDrankButtons.Controls.Add(this.btn_DrankW);
            this.pnl_MenuDrankButtons.Controls.Add(this.btn_DrankK);
            this.pnl_MenuDrankButtons.Controls.Add(this.btn_DrankG);
            this.pnl_MenuDrankButtons.Controls.Add(this.btn_DrankF);
            this.pnl_MenuDrankButtons.Location = new System.Drawing.Point(126, 396);
            this.pnl_MenuDrankButtons.Name = "pnl_MenuDrankButtons";
            this.pnl_MenuDrankButtons.Size = new System.Drawing.Size(632, 51);
            this.pnl_MenuDrankButtons.TabIndex = 4;
            // 
            // btn_DrankB
            // 
            this.btn_DrankB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DrankB.Location = new System.Drawing.Point(130, 3);
            this.btn_DrankB.Name = "btn_DrankB";
            this.btn_DrankB.Size = new System.Drawing.Size(120, 45);
            this.btn_DrankB.TabIndex = 2;
            this.btn_DrankB.TabStop = false;
            this.btn_DrankB.Text = "Bieren";
            this.btn_DrankB.UseVisualStyleBackColor = true;
            this.btn_DrankB.Click += new System.EventHandler(this.btn_DrankB_Click);
            // 
            // btn_DrankW
            // 
            this.btn_DrankW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DrankW.Location = new System.Drawing.Point(256, 3);
            this.btn_DrankW.Name = "btn_DrankW";
            this.btn_DrankW.Size = new System.Drawing.Size(120, 45);
            this.btn_DrankW.TabIndex = 2;
            this.btn_DrankW.TabStop = false;
            this.btn_DrankW.Text = "Wijnen";
            this.btn_DrankW.UseVisualStyleBackColor = true;
            this.btn_DrankW.Click += new System.EventHandler(this.btn_DrankW_Click);
            // 
            // btn_DrankK
            // 
            this.btn_DrankK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DrankK.Location = new System.Drawing.Point(508, 3);
            this.btn_DrankK.Name = "btn_DrankK";
            this.btn_DrankK.Size = new System.Drawing.Size(120, 45);
            this.btn_DrankK.TabIndex = 2;
            this.btn_DrankK.TabStop = false;
            this.btn_DrankK.Text = "Koffie / Thee";
            this.btn_DrankK.UseVisualStyleBackColor = true;
            this.btn_DrankK.Click += new System.EventHandler(this.btn_DrankK_Click);
            // 
            // btn_DrankG
            // 
            this.btn_DrankG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DrankG.Location = new System.Drawing.Point(382, 3);
            this.btn_DrankG.Name = "btn_DrankG";
            this.btn_DrankG.Size = new System.Drawing.Size(120, 45);
            this.btn_DrankG.TabIndex = 2;
            this.btn_DrankG.TabStop = false;
            this.btn_DrankG.Text = "Gedistilleerde dranken";
            this.btn_DrankG.UseVisualStyleBackColor = true;
            this.btn_DrankG.Click += new System.EventHandler(this.btn_DrankG_Click);
            // 
            // btn_DrankF
            // 
            this.btn_DrankF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DrankF.Location = new System.Drawing.Point(4, 3);
            this.btn_DrankF.Name = "btn_DrankF";
            this.btn_DrankF.Size = new System.Drawing.Size(120, 45);
            this.btn_DrankF.TabIndex = 2;
            this.btn_DrankF.TabStop = false;
            this.btn_DrankF.Text = "Frisdrank";
            this.btn_DrankF.UseVisualStyleBackColor = true;
            this.btn_DrankF.Click += new System.EventHandler(this.btn_DrankF_Click);
            // 
            // pnl_MenuLunchButtons
            // 
            this.pnl_MenuLunchButtons.Controls.Add(this.btn_LunchH);
            this.pnl_MenuLunchButtons.Controls.Add(this.btn_LunchN);
            this.pnl_MenuLunchButtons.Controls.Add(this.btn_LunchV);
            this.pnl_MenuLunchButtons.Location = new System.Drawing.Point(144, 321);
            this.pnl_MenuLunchButtons.Name = "pnl_MenuLunchButtons";
            this.pnl_MenuLunchButtons.Size = new System.Drawing.Size(632, 51);
            this.pnl_MenuLunchButtons.TabIndex = 3;
            // 
            // btn_LunchH
            // 
            this.btn_LunchH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LunchH.Location = new System.Drawing.Point(253, 3);
            this.btn_LunchH.Name = "btn_LunchH";
            this.btn_LunchH.Size = new System.Drawing.Size(120, 45);
            this.btn_LunchH.TabIndex = 2;
            this.btn_LunchH.TabStop = false;
            this.btn_LunchH.Text = "Hoofdgerechten";
            this.btn_LunchH.UseVisualStyleBackColor = true;
            this.btn_LunchH.Click += new System.EventHandler(this.btn_LunchH_Click);
            // 
            // btn_LunchN
            // 
            this.btn_LunchN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LunchN.Location = new System.Drawing.Point(379, 3);
            this.btn_LunchN.Name = "btn_LunchN";
            this.btn_LunchN.Size = new System.Drawing.Size(120, 45);
            this.btn_LunchN.TabIndex = 2;
            this.btn_LunchN.TabStop = false;
            this.btn_LunchN.Text = "Nagerechten";
            this.btn_LunchN.UseVisualStyleBackColor = true;
            this.btn_LunchN.Click += new System.EventHandler(this.btn_LunchN_Click);
            // 
            // btn_LunchV
            // 
            this.btn_LunchV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LunchV.Location = new System.Drawing.Point(127, 3);
            this.btn_LunchV.Name = "btn_LunchV";
            this.btn_LunchV.Size = new System.Drawing.Size(120, 45);
            this.btn_LunchV.TabIndex = 2;
            this.btn_LunchV.TabStop = false;
            this.btn_LunchV.Text = "Voorgerechten";
            this.btn_LunchV.UseVisualStyleBackColor = true;
            this.btn_LunchV.Click += new System.EventHandler(this.btn_LunchV_Click);
            // 
            // pnl_ActionButtons
            // 
            this.pnl_ActionButtons.Controls.Add(this.btn_Remove);
            this.pnl_ActionButtons.Controls.Add(this.btn_Add);
            this.pnl_ActionButtons.Location = new System.Drawing.Point(3, 57);
            this.pnl_ActionButtons.Name = "pnl_ActionButtons";
            this.pnl_ActionButtons.Size = new System.Drawing.Size(95, 155);
            this.pnl_ActionButtons.TabIndex = 1;
            // 
            // btn_Remove
            // 
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Location = new System.Drawing.Point(3, 50);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(89, 45);
            this.btn_Remove.TabIndex = 1;
            this.btn_Remove.TabStop = false;
            this.btn_Remove.Text = "Product Verwijderen";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(89, 45);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.TabStop = false;
            this.btn_Add.Text = "Product Toevoegen";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pnl_MenuButtons
            // 
            this.pnl_MenuButtons.Controls.Add(this.btn_Lunch);
            this.pnl_MenuButtons.Controls.Add(this.btn_Drank);
            this.pnl_MenuButtons.Controls.Add(this.btn_Diner);
            this.pnl_MenuButtons.Location = new System.Drawing.Point(420, 3);
            this.pnl_MenuButtons.Name = "pnl_MenuButtons";
            this.pnl_MenuButtons.Size = new System.Drawing.Size(368, 51);
            this.pnl_MenuButtons.TabIndex = 0;
            // 
            // btn_Drank
            // 
            this.btn_Drank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Drank.Location = new System.Drawing.Point(3, 3);
            this.btn_Drank.Name = "btn_Drank";
            this.btn_Drank.Size = new System.Drawing.Size(120, 45);
            this.btn_Drank.TabIndex = 2;
            this.btn_Drank.TabStop = false;
            this.btn_Drank.Text = "Drank Kaart";
            this.btn_Drank.UseVisualStyleBackColor = true;
            this.btn_Drank.Click += new System.EventHandler(this.btn_Drank_Click);
            // 
            // btn_Diner
            // 
            this.btn_Diner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Diner.Location = new System.Drawing.Point(245, 3);
            this.btn_Diner.Name = "btn_Diner";
            this.btn_Diner.Size = new System.Drawing.Size(120, 45);
            this.btn_Diner.TabIndex = 2;
            this.btn_Diner.TabStop = false;
            this.btn_Diner.Text = "Diner Kaart";
            this.btn_Diner.UseVisualStyleBackColor = true;
            this.btn_Diner.Click += new System.EventHandler(this.btn_Diner_Click);
            // 
            // btn_Lunch
            // 
            this.btn_Lunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lunch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Lunch.Location = new System.Drawing.Point(124, 3);
            this.btn_Lunch.Name = "btn_Lunch";
            this.btn_Lunch.Size = new System.Drawing.Size(120, 45);
            this.btn_Lunch.TabIndex = 3;
            this.btn_Lunch.TabStop = false;
            this.btn_Lunch.Text = "Lunch Kaart";
            this.btn_Lunch.UseVisualStyleBackColor = true;
            this.btn_Lunch.Click += new System.EventHandler(this.btn_Lunch_Click);
            // 
            // flp_MenuOverview
            // 
            this.flp_MenuOverview.AutoScroll = true;
            this.flp_MenuOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_MenuOverview.Location = new System.Drawing.Point(99, 57);
            this.flp_MenuOverview.Name = "flp_MenuOverview";
            this.flp_MenuOverview.Size = new System.Drawing.Size(686, 336);
            this.flp_MenuOverview.TabIndex = 1;
            // 
            // lbl_Instruction
            // 
            this.lbl_Instruction.AutoSize = true;
            this.lbl_Instruction.Location = new System.Drawing.Point(105, 41);
            this.lbl_Instruction.Name = "lbl_Instruction";
            this.lbl_Instruction.Size = new System.Drawing.Size(154, 13);
            this.lbl_Instruction.TabIndex = 5;
            this.lbl_Instruction.Text = "Klik een product voor meer info";
            // 
            // lbl_Instruction2
            // 
            this.lbl_Instruction2.AutoSize = true;
            this.lbl_Instruction2.Location = new System.Drawing.Point(228, 22);
            this.lbl_Instruction2.Name = "lbl_Instruction2";
            this.lbl_Instruction2.Size = new System.Drawing.Size(186, 13);
            this.lbl_Instruction2.TabIndex = 6;
            this.lbl_Instruction2.Text = "Kies een menu om aan te beginnen ->";
            // 
            // MenuOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_MenuOverview);
            this.Name = "MenuOverview";
            this.Text = "Menu Overview";
            this.Load += new System.EventHandler(this.MenuOverview_Load);
            this.pnl_MenuOverview.ResumeLayout(false);
            this.pnl_MenuOverview.PerformLayout();
            this.pnl_MenuDinerButtons.ResumeLayout(false);
            this.pnl_MenuDrankButtons.ResumeLayout(false);
            this.pnl_MenuLunchButtons.ResumeLayout(false);
            this.pnl_ActionButtons.ResumeLayout(false);
            this.pnl_MenuButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MenuOverview;
        private System.Windows.Forms.Panel pnl_MenuDinerButtons;
        private System.Windows.Forms.Button btn_DinerT;
        private System.Windows.Forms.Button btn_DinerH;
        private System.Windows.Forms.Button btn_DinerN;
        private System.Windows.Forms.Button btn_DinerV;
        private System.Windows.Forms.Panel pnl_MenuDrankButtons;
        private System.Windows.Forms.Button btn_DrankB;
        private System.Windows.Forms.Button btn_DrankW;
        private System.Windows.Forms.Button btn_DrankK;
        private System.Windows.Forms.Button btn_DrankG;
        private System.Windows.Forms.Button btn_DrankF;
        private System.Windows.Forms.Panel pnl_MenuLunchButtons;
        private System.Windows.Forms.Button btn_LunchH;
        private System.Windows.Forms.Button btn_LunchN;
        private System.Windows.Forms.Button btn_LunchV;
        private System.Windows.Forms.Panel pnl_ActionButtons;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel pnl_MenuButtons;
        private System.Windows.Forms.Button btn_Drank;
        private System.Windows.Forms.Button btn_Diner;
        private System.Windows.Forms.Button btn_Lunch;
        private System.Windows.Forms.FlowLayoutPanel flp_MenuOverview;
        private System.Windows.Forms.Label lbl_Instruction;
        private System.Windows.Forms.Label lbl_Instruction2;
    }
}