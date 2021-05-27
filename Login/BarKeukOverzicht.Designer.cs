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
            this.orderList = new System.Windows.Forms.ListView();
            this.btn_complete = new System.Windows.Forms.Button();
            this.btn_workingOn = new System.Windows.Forms.Button();
            this.btn_setOpen = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_removeCompleted = new System.Windows.Forms.Button();
            this.txb_header = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // orderList
            // 
            this.orderList.HideSelection = false;
            this.orderList.Location = new System.Drawing.Point(35, 72);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(994, 509);
            this.orderList.TabIndex = 0;
            this.orderList.UseCompatibleStateImageBehavior = false;
            // 
            // btn_complete
            // 
            this.btn_complete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(237)))), ((int)(((byte)(99)))));
            this.btn_complete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_complete.Font = new System.Drawing.Font("Roboto", 36F);
            this.btn_complete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_complete.Location = new System.Drawing.Point(35, 614);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(243, 144);
            this.btn_complete.TabIndex = 1;
            this.btn_complete.Text = "Compleet";
            this.btn_complete.UseVisualStyleBackColor = false;
            // 
            // btn_workingOn
            // 
            this.btn_workingOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.btn_workingOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_workingOn.Font = new System.Drawing.Font("Roboto", 36F);
            this.btn_workingOn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_workingOn.Location = new System.Drawing.Point(383, 614);
            this.btn_workingOn.Name = "btn_workingOn";
            this.btn_workingOn.Size = new System.Drawing.Size(243, 144);
            this.btn_workingOn.TabIndex = 2;
            this.btn_workingOn.Text = "Bezig";
            this.btn_workingOn.UseVisualStyleBackColor = false;
            // 
            // btn_setOpen
            // 
            this.btn_setOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_setOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setOpen.Font = new System.Drawing.Font("Roboto", 36F);
            this.btn_setOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_setOpen.Location = new System.Drawing.Point(720, 614);
            this.btn_setOpen.Name = "btn_setOpen";
            this.btn_setOpen.Size = new System.Drawing.Size(243, 144);
            this.btn_setOpen.TabIndex = 3;
            this.btn_setOpen.Text = "Open";
            this.btn_setOpen.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(99)))), ((int)(((byte)(151)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Roboto", 36F);
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Location = new System.Drawing.Point(1108, 29);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(244, 195);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_removeCompleted
            // 
            this.btn_removeCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btn_removeCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeCompleted.Font = new System.Drawing.Font("Roboto", 36F);
            this.btn_removeCompleted.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_removeCompleted.Location = new System.Drawing.Point(1108, 386);
            this.btn_removeCompleted.Name = "btn_removeCompleted";
            this.btn_removeCompleted.Size = new System.Drawing.Size(244, 195);
            this.btn_removeCompleted.TabIndex = 5;
            this.btn_removeCompleted.Text = "Verwijder Compleet";
            this.btn_removeCompleted.UseVisualStyleBackColor = false;
            // 
            // txb_header
            // 
            this.txb_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(61)))), ((int)(((byte)(102)))));
            this.txb_header.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_header.ForeColor = System.Drawing.Color.White;
            this.txb_header.Location = new System.Drawing.Point(35, 29);
            this.txb_header.Name = "txb_header";
            this.txb_header.ReadOnly = true;
            this.txb_header.Size = new System.Drawing.Size(994, 46);
            this.txb_header.TabIndex = 7;
            this.txb_header.TabStop = false;
            // 
            // BarKeukOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txb_header);
            this.Controls.Add(this.btn_removeCompleted);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_setOpen);
            this.Controls.Add(this.btn_workingOn);
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.orderList);
            this.Name = "BarKeukOverzicht";
            this.Size = new System.Drawing.Size(1421, 794);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView orderList;
        private System.Windows.Forms.Button btn_complete;
        private System.Windows.Forms.Button btn_workingOn;
        private System.Windows.Forms.Button btn_setOpen;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_removeCompleted;
        private System.Windows.Forms.TextBox txb_header;
    }
}