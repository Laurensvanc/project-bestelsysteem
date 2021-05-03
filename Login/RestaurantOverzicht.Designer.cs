namespace Login
{
    partial class RestaurantOverzicht
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
            this.lstReservering = new System.Windows.Forms.ListView();
            this.lstTafelStatus = new System.Windows.Forms.ListView();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnFresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstReservering
            // 
            this.lstReservering.HideSelection = false;
            this.lstReservering.Location = new System.Drawing.Point(599, 12);
            this.lstReservering.Name = "lstReservering";
            this.lstReservering.Size = new System.Drawing.Size(179, 409);
            this.lstReservering.TabIndex = 0;
            this.lstReservering.UseCompatibleStateImageBehavior = false;
            this.lstReservering.View = System.Windows.Forms.View.Details;
            // 
            // lstTafelStatus
            // 
            this.lstTafelStatus.HideSelection = false;
            this.lstTafelStatus.Location = new System.Drawing.Point(12, 27);
            this.lstTafelStatus.Name = "lstTafelStatus";
            this.lstTafelStatus.Size = new System.Drawing.Size(561, 299);
            this.lstTafelStatus.TabIndex = 1;
            this.lstTafelStatus.UseCompatibleStateImageBehavior = false;
            this.lstTafelStatus.View = System.Windows.Forms.View.Details;
            this.lstTafelStatus.SelectedIndexChanged += new System.EventHandler(this.lstTafelStatus_SelectedIndexChanged);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(26, 359);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(44, 34);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(92, 359);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(44, 34);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnFresh
            // 
            this.btnFresh.Location = new System.Drawing.Point(161, 359);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(76, 34);
            this.btnFresh.TabIndex = 4;
            this.btnFresh.Text = "refresh";
            this.btnFresh.UseVisualStyleBackColor = true;
            // 
            // RestaurantOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lstTafelStatus);
            this.Controls.Add(this.lstReservering);
            this.Name = "RestaurantOverzicht";
            this.Text = "RestaurantOverzicht";
            this.Load += new System.EventHandler(this.RestaurantOverzicht_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstReservering;
        private System.Windows.Forms.ListView lstTafelStatus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnFresh;
    }
}