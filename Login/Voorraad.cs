using ChapooModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login
{
    public partial class Voorraad : Form
    {
        private bool _showingDrinks = false;
        private List<Product> _products;

        public VoorraadChange VoorraadChange { get; private set; }

        public Voorraad()
        {
            InitializeComponent();
            // add grid lines, rows
            lv_Voorraad.View = View.Details;
            lv_Voorraad.GridLines = true;
            lv_Voorraad.FullRowSelect = true;
            lv_Voorraad.MultiSelect = false;
            Voorraad_Refresh();
        }

        private void Voorraad_Refresh()
        {
            ChapooLogic.Product_Service product_Service = new ChapooLogic.Product_Service();
            _products = product_Service.GetProducts();

            // clear list
            lv_Voorraad.Items.Clear();

            string productType;
            if (_showingDrinks == false)
            {
                productType = "Eten";
            }
            else
            {
                productType = "Drankjes";
            }
            lbl_Showing.Text = $"{productType}";

            foreach (Product p in _products)
            {
                if (_showingDrinks == false)
                {
                    if (p.IsDrinken == false)
                    {
                        FillGridView(p);
                    }
                }
                else
                {
                    if (p.IsDrinken == true)
                    {
                        FillGridView(p);
                    }
                }
            }
        }

        private void FillGridView(Product p)
        {
            string[] arr = new string[3];
            ListViewItem li;

            arr[0] = p.ProductId.ToString();
            arr[1] = p.ProductNaam;
            arr[2] = p.Aantal.ToString();

            li = new ListViewItem(arr);
            lv_Voorraad.Items.Add(li);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Voorraad_Refresh();
        }

        private void btn_Toggle_Click(object sender, EventArgs e)
        {
            if (_showingDrinks == false)
            {
                _showingDrinks = true;
                btn_Toggle.Text = "Show food";
            }
            else
            {
                _showingDrinks = false;
                btn_Toggle.Text = "Show drinks";
            }
            Voorraad_Refresh();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var voorraadChange = new VoorraadChange();

            voorraadChange.ShowDialog();
            Voorraad_Refresh();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (lv_Voorraad.SelectedItems.Count > 0)
            {
                Product product = _products.Find(p => p.ProductId == int.Parse(lv_Voorraad.SelectedItems[0].Text));
                var voorraadChange = new VoorraadChange(product);

                voorraadChange.ShowDialog();
                Voorraad_Refresh();
            }
            else
            {
                MessageBox.Show("Geen product geselecteerd!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}