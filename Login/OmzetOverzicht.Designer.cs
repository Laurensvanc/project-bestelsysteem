
namespace Login
{
    partial class OmzetOverzicht
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
            this.lbl_expense = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.lbl_revenue = new System.Windows.Forms.Label();
            this.lst_expense = new System.Windows.Forms.ListView();
            this.lst_income = new System.Windows.Forms.ListView();
            this.lst_revenue = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txb_totalExpense = new System.Windows.Forms.TextBox();
            this.txb_totalIncome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_expense
            // 
            this.lbl_expense.AutoSize = true;
            this.lbl_expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_expense.Location = new System.Drawing.Point(52, 42);
            this.lbl_expense.Name = "lbl_expense";
            this.lbl_expense.Size = new System.Drawing.Size(86, 26);
            this.lbl_expense.TabIndex = 0;
            this.lbl_expense.Text = "Uitgave";
            // 
            // lbl_income
            // 
            this.lbl_income.AutoSize = true;
            this.lbl_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_income.Location = new System.Drawing.Point(385, 42);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(96, 26);
            this.lbl_income.TabIndex = 1;
            this.lbl_income.Text = "Inkomen";
            // 
            // lbl_revenue
            // 
            this.lbl_revenue.AutoSize = true;
            this.lbl_revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_revenue.Location = new System.Drawing.Point(52, 275);
            this.lbl_revenue.Name = "lbl_revenue";
            this.lbl_revenue.Size = new System.Drawing.Size(77, 26);
            this.lbl_revenue.TabIndex = 2;
            this.lbl_revenue.Text = "Omzet";
            // 
            // lst_expense
            // 
            this.lst_expense.HideSelection = false;
            this.lst_expense.Location = new System.Drawing.Point(57, 67);
            this.lst_expense.Name = "lst_expense";
            this.lst_expense.Size = new System.Drawing.Size(280, 172);
            this.lst_expense.TabIndex = 3;
            this.lst_expense.UseCompatibleStateImageBehavior = false;
            // 
            // lst_income
            // 
            this.lst_income.HideSelection = false;
            this.lst_income.Location = new System.Drawing.Point(390, 67);
            this.lst_income.Name = "lst_income";
            this.lst_income.Size = new System.Drawing.Size(280, 172);
            this.lst_income.TabIndex = 4;
            this.lst_income.UseCompatibleStateImageBehavior = false;
            // 
            // lst_revenue
            // 
            this.lst_revenue.HideSelection = false;
            this.lst_revenue.Location = new System.Drawing.Point(57, 304);
            this.lst_revenue.Name = "lst_revenue";
            this.lst_revenue.Size = new System.Drawing.Size(280, 79);
            this.lst_revenue.TabIndex = 5;
            this.lst_revenue.UseCompatibleStateImageBehavior = false;
            // 
            // txb_totalExpense
            // 
            this.txb_totalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_totalExpense.Location = new System.Drawing.Point(57, 213);
            this.txb_totalExpense.Name = "txb_totalExpense";
            this.txb_totalExpense.ReadOnly = true;
            this.txb_totalExpense.Size = new System.Drawing.Size(280, 26);
            this.txb_totalExpense.TabIndex = 6;
            // 
            // txb_totalIncome
            // 
            this.txb_totalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_totalIncome.Location = new System.Drawing.Point(390, 213);
            this.txb_totalIncome.Name = "txb_totalIncome";
            this.txb_totalIncome.ReadOnly = true;
            this.txb_totalIncome.Size = new System.Drawing.Size(280, 26);
            this.txb_totalIncome.TabIndex = 7;
            // 
            // OmzetOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_totalIncome);
            this.Controls.Add(this.txb_totalExpense);
            this.Controls.Add(this.lst_revenue);
            this.Controls.Add(this.lst_income);
            this.Controls.Add(this.lst_expense);
            this.Controls.Add(this.lbl_revenue);
            this.Controls.Add(this.lbl_income);
            this.Controls.Add(this.lbl_expense);
            this.Name = "OmzetOverzicht";
            this.Text = "OmzetOverzicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_expense;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.Label lbl_revenue;
        private System.Windows.Forms.ListView lst_expense;
        private System.Windows.Forms.ListView lst_income;
        private System.Windows.Forms.ListView lst_revenue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txb_totalExpense;
        private System.Windows.Forms.TextBox txb_totalIncome;
    }
}