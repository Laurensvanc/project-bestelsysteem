using ChapooLogic;
using ChapooModel;
using System;
using System.Windows.Forms;

namespace Login
{
    public partial class VoorraadConfirmation : Form
    {
        private readonly Product _product;
        private readonly bool _deleting;
        private readonly VoorraadChange _parentForm;
        private readonly Product_Service _productService;

        public VoorraadConfirmation(Product product, string txt, bool deleting, VoorraadChange parentForm)
        {
            InitializeComponent();
            _product = product;
            _deleting = deleting;
            _parentForm = parentForm;
            lbl_PreviewTxt.Text = txt;
            _productService = new Product_Service();
            LoadFields();
        }

        private void LoadFields()
        {
            // fill labels
            string alcohol;
            string type;
            if (_product.IsAlcohol)
            {
                alcohol = "Ja";
            }
            else
            {
                alcohol = "Nee";
            }
            if (_product.IsDrinken)
            {
                type = "Drinken";
            }
            else
            {
                type = "Eten";
            }
            tb_ProductNameValue.Text = _product.ProductNaam;
            lbl_MenuPriceValue.Text = "€ " + _product.Prijs.ToString("0.00");
            lbl_PurchasePriceValue.Text = "€ " + _product.InkoopPrijs.ToString("0.00");
            lbl_AmountValue.Text = _product.Aantal.ToString();
            lbl_AlcoholicValue.Text = alcohol;
            lbl_TypeValue.Text = type;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            // adding/changing item
            if (_deleting) // check if process is deleting
            {
                DialogResult confirm = MessageBox.Show($"Weet je het zeker dat je dit product wilt verwijderen?\nDeze actie is niet terug te draaien!", "Product verwijderen?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirm == DialogResult.OK)
                {
                    // delete item
                    _productService.DeleteProduct(_product);
                    MessageBox.Show("Product verwijderd!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    _parentForm.Close();
                }
                else
                {
                    MessageBox.Show("Taak geannuleerd!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            else if (_product.ProductId == -1) // check if process is adding
            {
                // add item
                _productService.AddProduct(_product);
                MessageBox.Show("Product toegevoegd!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                _parentForm.Close();
            }
            else // else change process
            {
                // change item
                _productService.ChangeProduct(_product);
                MessageBox.Show("Product gewijzigd!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                _parentForm.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Taak geannuleerd!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}