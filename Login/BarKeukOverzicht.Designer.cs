namespace Login
{
    partial class BarKeukOverzicht
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
            this.btn_complete = new System.Windows.Forms.Button();
            this.btn_workingOn = new System.Windows.Forms.Button();
            this.btn_setOpen = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.btn_filter = new System.Windows.Forms.Button();
            this.lv_orderList = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_generalOrder = new System.Windows.Forms.Button();
            this.btn_kitchenOrder = new System.Windows.Forms.Button();
            this.btn_barOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_complete
            // 
            this.btn_complete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(237)))), ((int)(((byte)(99)))));
            this.btn_complete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_complete.Font = new System.Drawing.Font("Roboto", 36F);
            this.btn_complete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_complete.Location = new System.Drawing.Point(35, 735);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(243, 144);
            this.btn_complete.TabIndex = 1;
            this.btn_complete.Text = "Afgerond";
            this.btn_complete.UseVisualStyleBackColor = false;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // btn_workingOn
            // 
            this.btn_workingOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btn_workingOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_workingOn.Font = new System.Drawing.Font("Roboto", 36F);
            this.btn_workingOn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_workingOn.Location = new System.Drawing.Point(463, 735);
            this.btn_workingOn.Name = "btn_workingOn";
            this.btn_workingOn.Size = new System.Drawing.Size(243, 144);
            this.btn_workingOn.TabIndex = 2;
            this.btn_workingOn.Text = "Bezig";
            this.btn_workingOn.UseVisualStyleBackColor = false;
            this.btn_workingOn.Click += new System.EventHandler(this.btn_workingOn_Click);
            // 
            // btn_setOpen
            // 
            this.btn_setOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.btn_setOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setOpen.Font = new System.Drawing.Font("Roboto", 36F);
            this.btn_setOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_setOpen.Location = new System.Drawing.Point(912, 735);
            this.btn_setOpen.Name = "btn_setOpen";
            this.btn_setOpen.Size = new System.Drawing.Size(243, 144);
            this.btn_setOpen.TabIndex = 3;
            this.btn_setOpen.Text = "Nieuw";
            this.btn_setOpen.UseVisualStyleBackColor = false;
            this.btn_setOpen.Click += new System.EventHandler(this.btn_setOpen_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Roboto", 36F);
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Location = new System.Drawing.Point(1238, 29);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(268, 195);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(78)))), ((int)(((byte)(124)))));
            this.panel_Header.Controls.Add(this.label1);
            this.panel_Header.Controls.Add(this.btn_filter);
            this.panel_Header.Controls.Add(this.lv_orderList);
            this.panel_Header.Controls.Add(this.label11);
            this.panel_Header.Location = new System.Drawing.Point(35, 29);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1120, 649);
            this.panel_Header.TabIndex = 29;
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.White;
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter.Font = new System.Drawing.Font("Roboto", 16F);
            this.btn_filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(78)))), ((int)(((byte)(124)))));
            this.btn_filter.Location = new System.Drawing.Point(951, 9);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(125, 37);
            this.btn_filter.TabIndex = 29;
            this.btn_filter.Text = "vandaag";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // lv_orderList
            // 
            this.lv_orderList.Font = new System.Drawing.Font("Roboto", 18F);
            this.lv_orderList.FullRowSelect = true;
            this.lv_orderList.HideSelection = false;
            this.lv_orderList.Location = new System.Drawing.Point(3, 55);
            this.lv_orderList.Name = "lv_orderList";
            this.lv_orderList.Size = new System.Drawing.Size(1114, 591);
            this.lv_orderList.TabIndex = 28;
            this.lv_orderList.UseCompatibleStateImageBehavior = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 37);
            this.label11.TabIndex = 27;
            this.label11.Text = "Bestelling";
            // 
            // btn_generalOrder
            // 
            this.btn_generalOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_generalOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generalOrder.Font = new System.Drawing.Font("Roboto", 24F);
            this.btn_generalOrder.ForeColor = System.Drawing.Color.White;
            this.btn_generalOrder.Location = new System.Drawing.Point(1238, 307);
            this.btn_generalOrder.Name = "btn_generalOrder";
            this.btn_generalOrder.Size = new System.Drawing.Size(268, 75);
            this.btn_generalOrder.TabIndex = 29;
            this.btn_generalOrder.Text = "Bestellingen";
            this.btn_generalOrder.UseVisualStyleBackColor = false;
            this.btn_generalOrder.Click += new System.EventHandler(this.btn_generalOrder_Click);
            // 
            // btn_kitchenOrder
            // 
            this.btn_kitchenOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_kitchenOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitchenOrder.Font = new System.Drawing.Font("Roboto", 24F);
            this.btn_kitchenOrder.ForeColor = System.Drawing.Color.White;
            this.btn_kitchenOrder.Location = new System.Drawing.Point(1238, 407);
            this.btn_kitchenOrder.Name = "btn_kitchenOrder";
            this.btn_kitchenOrder.Size = new System.Drawing.Size(268, 75);
            this.btn_kitchenOrder.TabIndex = 30;
            this.btn_kitchenOrder.Text = "Keuken";
            this.btn_kitchenOrder.UseVisualStyleBackColor = false;
            this.btn_kitchenOrder.Click += new System.EventHandler(this.btn_kitchenOrder_Click);
            // 
            // btn_barOrder
            // 
            this.btn_barOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_barOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_barOrder.Font = new System.Drawing.Font("Roboto", 24F);
            this.btn_barOrder.ForeColor = System.Drawing.Color.White;
            this.btn_barOrder.Location = new System.Drawing.Point(1238, 506);
            this.btn_barOrder.Name = "btn_barOrder";
            this.btn_barOrder.Size = new System.Drawing.Size(268, 75);
            this.btn_barOrder.TabIndex = 31;
            this.btn_barOrder.Text = "Bar";
            this.btn_barOrder.UseVisualStyleBackColor = false;
            this.btn_barOrder.Click += new System.EventHandler(this.btn_barOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(872, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "Filter:";
            // 
            // BarKeukOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_barOrder);
            this.Controls.Add(this.btn_kitchenOrder);
            this.Controls.Add(this.btn_generalOrder);
            this.Controls.Add(this.panel_Header);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_setOpen);
            this.Controls.Add(this.btn_workingOn);
            this.Controls.Add(this.btn_complete);
            this.Name = "BarKeukOverzicht";
            this.Size = new System.Drawing.Size(1576, 942);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_complete;
        private System.Windows.Forms.Button btn_workingOn;
        private System.Windows.Forms.Button btn_setOpen;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lv_orderList;
        private System.Windows.Forms.Button btn_generalOrder;
        private System.Windows.Forms.Button btn_kitchenOrder;
        private System.Windows.Forms.Button btn_barOrder;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Label label1;
    }
}