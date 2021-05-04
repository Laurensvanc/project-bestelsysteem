using ChapooModel;
using ChapooLogic;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Login
{
    public partial class VoorraadChange : Form
    {
        private Product _product;

        public VoorraadChange(Product product)
        {
            InitializeComponent();
            LoadFields(product);
            pnl_AddBtn.Hide();
            pnl_ChangeBtn.Show();
        }
        public VoorraadChange()
        {
            InitializeComponent();
            pnl_ChangeBtn.Hide();
            lbl_ProductIDTxt.Hide();
            lbl_ProductIDValue.Hide();
            pnl_AddBtn.Show();
        }
        private void LoadFields(Product product)
        {
            _product = product;
            lbl_ProductIDValue.Text = _product.ProductId.ToString();
            tb_ProductName.Text = _product.ProductNaam;
            tb_MenuPrice.Text = _product.Prijs.ToString("0.00");
            tb_PurchasePrice.Text = _product.InkoopPrijs.ToString("0.00");
            nud_Amount.Value = _product.Aantal;
            cb_Alcoholic.Checked = _product.IsAlcohol;
            if (_product.IsDrinken == false)
            {
                cbox_Type.SelectedIndex = 0;
            }
            else
            {
                cbox_Type.SelectedIndex = 1;
            }
        }

        private void tb_MenuPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // checks input
            CheckPriceInput(textBox, e);
        }

        private void tb_PurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // checks input
            CheckPriceInput(textBox, e);
        }

        private void CheckPriceInput(TextBox textBox, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Check if '.' pressed
            char sepratorChar = 'a';
            if (e.KeyChar == '.')
            {
                // Check if it's in the beginning of text not accept
                if (textBox.Text.Length == 0) e.Handled = true;
                // Check if it's in the beginning of text not accept
                if (textBox.SelectionStart == 0) e.Handled = true;
                // Check if there is already exist a '.' , ','
                if (alreadyExist(textBox.Text, ref sepratorChar)) e.Handled = true;
                // Check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (textBox.SelectionStart != textBox.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = textBox.Text.Substring(textBox.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            // Check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                // Check if a dot exist
                if (alreadyExist(textBox.Text, ref sepratorChar))
                {
                    int sepratorPosition = textBox.Text.IndexOf(sepratorChar);
                    string afterSepratorString = textBox.Text.Substring(sepratorPosition + 1);
                    if (textBox.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private bool alreadyExist(string _text, ref char KeyChar)
        {
            // check if '.' exists
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }

            return false;
        }
        private bool TypeToBool()
        {
            if (cbox_Type.SelectedItem.ToString() == "Drinken")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            Product product = new Product(_product.ProductId, tb_ProductName.Text, double.Parse(tb_MenuPrice.Text), double.Parse(tb_PurchasePrice.Text), Convert.ToInt32(nud_Amount.Value), cb_Alcoholic.Checked, TypeToBool());
            if (!product.Equals(_product)) // check if object has changed
            {
                var voorraadConfirmation = new VoorraadConfirmation(product, "Het product zal de volgende waarden krijgen: ", false, this);

                voorraadConfirmation.ShowDialog();
            }
            else
            {
                MessageBox.Show("Product waarden zijn niet verandert!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Product product = new Product(_product.ProductId, tb_ProductName.Text, double.Parse(tb_MenuPrice.Text), double.Parse(tb_PurchasePrice.Text), Convert.ToInt32(nud_Amount.Value), cb_Alcoholic.Checked, TypeToBool());
            var voorraadConfirmation = new VoorraadConfirmation(product, "Het product met de volgende waarden zal worden verwijderd: ", true, this);

            voorraadConfirmation.ShowDialog();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Product product = new Product(-1, tb_ProductName.Text, double.Parse(tb_MenuPrice.Text), double.Parse(tb_PurchasePrice.Text), Convert.ToInt32(nud_Amount.Value), cb_Alcoholic.Checked, TypeToBool());
            var voorraadConfirmation = new VoorraadConfirmation(product, "Het product met de volgende waarden zal worden toegevoegd: ", false, this);

            voorraadConfirmation.ShowDialog();
        }

        private void Validation(TextBox textBox, CancelEventArgs e, string Error)
        {
            // check if textboxes aren't empty
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, Error);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBox, null);
            }
        }

        private void tb_ProductName_Validating(object sender, CancelEventArgs e)
        {
            Validation(tb_ProductName, e, "Product naam mag niet leeg zijn!");
        }

        private void tb_MenuPrice_Validating(object sender, CancelEventArgs e)
        {
            Validation(tb_MenuPrice, e, "Menu prijs mag niet leeg zijn!");
        }

        private void tb_PurchasePrice_Validating(object sender, CancelEventArgs e)
        {
            Validation(tb_PurchasePrice, e, "Menu prijs mag niet leeg zijn!");
        }

        

       
    }
}