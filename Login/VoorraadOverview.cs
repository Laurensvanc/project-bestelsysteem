using ChapooLogic;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class VoorraadOverview : UserControl
    {
        private bool _showingDrinks;
        private List<Product> _products;
        private Product_Service _productService;
        private ListViewColumnSorter lvwColumnSorter; // column sort functionality

        public VoorraadOverview()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.lv_Voorraad.ListViewItemSorter = lvwColumnSorter;
        }

        private void VoorraadOverview_Load(object sender, EventArgs e)
        {
            _productService = new Product_Service();
            // add grid lines, rows
            Point point = new Point(12, 12);
            pnl_VoorraadOverview.Location = point;
            lv_Voorraad.GridLines = true;
            lv_Voorraad.FullRowSelect = true;
            lv_Voorraad.MultiSelect = false;

            Voorraad_Refresh();
        }

        private void Voorraad_Refresh()
        {
            _products = _productService.GetProducts();

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
                    if (p.IsDrinken)
                    {
                        FillGridView(p);
                    }
                }
            }
            lv_Voorraad.Columns[0].Width = -2;
            lv_Voorraad.Columns[3].Width = -2;
        }

        private void FillGridView(Product p)
        {
            // fill grid with product
            string[] arr = new string[5];
            double priceDifference = Math.Abs(p.Prijs - p.InkoopPrijs);
            string priceProfit = "";
            if (p.Prijs > p.InkoopPrijs)
            {
                priceProfit = "+";
            }
            else if (p.Prijs < p.InkoopPrijs)
            {
                priceProfit = "-";
            }

            arr[0] = p.ProductId.ToString();
            arr[1] = p.ProductNaam;
            arr[2] = "€" + p.InkoopPrijs.ToString("0.00");
            arr[3] = "€" + p.Prijs.ToString("0.00") + $" ({priceProfit}€{priceDifference.ToString("0.00")})";
            arr[4] = p.Aantal.ToString();

            ListViewItem li = new ListViewItem(arr);
            lv_Voorraad.Items.Add(li);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Voorraad_Refresh();
        }

        private void btn_Toggle_Click(object sender, EventArgs e)
        {
            // toggle between drinks and food
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
            // open new window to change or add products
            using (var voorraadChange = new VoorraadChange())
            {
                voorraadChange.ShowDialog();
            }
            Voorraad_Refresh();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            // opens window to change/remove product
            if (lv_Voorraad.SelectedItems.Count > 0)
            {
                Product product = _products.Find(p => p.ProductId == int.Parse(lv_Voorraad.SelectedItems[0].Text));
                using (var voorraadChange = new VoorraadChange(product))
                {
                    voorraadChange.ShowDialog();
                }
                Voorraad_Refresh();
            }
            else
            {
                MessageBox.Show("Geen product geselecteerd!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SearchVoorraad()
        {
            Voorraad_Refresh();

            // searches product list
            if (!string.IsNullOrWhiteSpace(tb_Search.Text))
            {
                lv_Voorraad.Items.Clear();
                foreach (Product p in _products)
                {
                    if (p.ProductId.ToString().ToLower().Contains(tb_Search.Text.ToLower()) || p.ProductNaam.ToLower().Contains(tb_Search.Text.ToLower()))
                    {
                        if ((p.IsDrinken && _showingDrinks) || (p.IsDrinken == false && _showingDrinks == false))
                        {
                            FillGridView(p);
                        }
                    }
                }
                if (lv_Voorraad.SelectedItems.Count == 1)
                {
                    lv_Voorraad.Focus();
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchVoorraad();
        }

        private void tb_Search_KeyUp(object sender, KeyEventArgs e)
        {
            // enables searching using the enter key
            if (e.KeyCode == Keys.Enter)
            {
                SearchVoorraad();
            }
        }

        private void tb_Search_KeyDown(object sender, KeyEventArgs e)
        {
            // mute ding sound when pressing enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void lv_Voorraad_DoubleClick(object sender, EventArgs e)
        {
            // product info
            Product product = _products.Find(p => p.ProductId == int.Parse(lv_Voorraad.SelectedItems[0].Text));
            string alcohol;
            if (product.IsAlcohol)
            {
                alcohol = "Ja";
            }
            else
            {
                alcohol = "Nee";
            }
            MessageBox.Show($"{product}\n\nProductID:\t{product.ProductId}\nPrijs:\t\t€{product.Prijs.ToString("0.00")}\nInkoop prijs:\t€{product.InkoopPrijs.ToString("0.00")}\nAantal:\t\t{product.Aantal}\nAlcoholisch:\t{alcohol}", "Product Info");
        }

        private void lv_Voorraad_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if ((e.ItemIndex % 2) == 1)
            {
                e.Item.BackColor = Color.WhiteSmoke;
                e.Item.UseItemStyleForSubItems = true;
            }
            else
            {
                e.Item.BackColor = Color.White;
                e.Item.UseItemStyleForSubItems = true;
            }
        }

        private void lv_Voorraad_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ColumnSort(ColumnClickEventArgs e, ListView lv)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            lv.Sort();
        }

        private void lv_Voorraad_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnSort(e, (ListView)sender);
        }
    }
}