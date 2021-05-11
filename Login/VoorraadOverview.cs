﻿using ChapooLogic;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class VoorraadOverview : Form
    {
        private bool _showingDrinks = false;
        private List<Product> _products;
        private Product_Service product_Service;

        public VoorraadChange VoorraadChange { get; private set; }

        public VoorraadOverview()
        {
            InitializeComponent();
        }

        private void VoorraadOverview_Load(object sender, EventArgs e)
        {
            product_Service = new Product_Service();
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
            lv_Voorraad.Columns[0].Width = -2;
            lv_Voorraad.Columns[2].Width = -2;
        }

        private void FillGridView(Product p)
        {
            // fill grid with product
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
                        if ((p.IsDrinken == true && _showingDrinks == true) || (p.IsDrinken == false && _showingDrinks == false))
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

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            // opens menu overview
            FormClosingEventArgs f = new FormClosingEventArgs(0, false);
            VoorraadOverview_FormClosing(sender, f);
            this.Close();
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

        private void VoorraadOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            // transition between menu and voorraad overview (open, closing)
        }

        private void lv_Voorraad_DoubleClick(object sender, EventArgs e)
        {
            // product info
            Product product = _products.Find(p => p.ProductId == int.Parse(lv_Voorraad.SelectedItems[0].Text));
            string alcohol;
            if (product.IsAlcohol == true)
            {
                alcohol = "Ja";
            }
            else
            {
                alcohol = "Nee";
            }
            MessageBox.Show($"{product}\n\nProductID:\t{product.ProductId}\nPrijs:\t\t€{product.Prijs.ToString("0.00")}\nInkoop prijs:\t€{product.InkoopPrijs.ToString("0.00")}\nAantal:\t\t{product.Aantal}\nAlcoholisch:\t{alcohol}", "Product Info");
        }
    }
}