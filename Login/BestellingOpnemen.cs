using ChapooModel;
using ChapooLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class BestellingOpnemen : UserControl
    {
        public Product_Service productService = new Product_Service();
        public List<Product> productList = new List<Product>();
        public BestellingOpnemen()
        {
            InitializeComponent();
            pnl_Drank.Hide();
            pnl_Tafelnr.Hide();
            pnl_Klacht.Hide();
            pnl_Instructies.Hide();
        }
        public void ShowColumns()
        {
            listOrderView.Columns.Add("Bestelling", 210);
            listOrderView.Columns.Add("Prijs", 75);
            listOrderView.Columns.Add("Aantal", 75);
            listOrderView.Columns.Add("ID", 40);
        }
        public void ShowMenuItems(int soortID)
        {
            //productList = productService.GetProducts();
            productList = productService.GetSpecificProduct(soortID);

            listMenuView.Columns.Add("Menu", 295);
            listMenuView.Columns.Add("Prijs", 75);
            listMenuView.Columns.Add("ID", 40);

            foreach (Product product in productList)
            {
                ListViewItem li = new ListViewItem(product.ProductNaam);
                li.SubItems.Add(product.Prijs.ToString("0.00"));
                li.SubItems.Add(product.ProductId.ToString());
                listMenuView.Items.Add(li);
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listMenuView.Items.Count; i++)
            {
                if (listMenuView.Items[i].Selected)
                {
                    float total = float.Parse(lblTotal.Text);
                    total += float.Parse(listMenuView.Items[i].SubItems[1].Text);
                    lblTotal.Text = total.ToString("0.00");
                    if (listOrderView.Items.Count == 0)
                    {
                        ListViewItem li = new ListViewItem(productList[i].ProductNaam);
                        li.SubItems.Add(productList[i].Prijs.ToString("0.00"));
                        li.SubItems.Add("1");
                        li.SubItems.Add(productList[i].ProductId.ToString());
                        listOrderView.Items.Add(li);
                    }
                    else
                    {
                        int item = 0;
                        bool duplicate = false;
                        do
                        {
                            if (listOrderView.Items[item].SubItems[3].Text == listMenuView.Items[i].SubItems[2].Text)
                            {
                                int quantity = int.Parse(listOrderView.Items[item].SubItems[2].Text) + 1;
                                float totalProduct = float.Parse(listOrderView.Items[item].SubItems[1].Text) + float.Parse(listMenuView.Items[i].SubItems[1].Text);
                                listOrderView.Items[item].SubItems[1].Text = totalProduct.ToString("0.00");
                                listOrderView.Items[item].SubItems[2].Text = quantity.ToString();
                                duplicate = true;
                                break;
                            }
                            item++;
                        } while (item < listOrderView.Items.Count);
                        if (!duplicate)
                        {
                            ListViewItem li = new ListViewItem(productList[i].ProductNaam);
                            li.SubItems.Add(productList[i].Prijs.ToString("0.00"));
                            li.SubItems.Add("1");
                            li.SubItems.Add(productList[i].ProductId.ToString());
                            listOrderView.Items.Add(li);
                        }
                    }
                }
            }
        }
        private void btnRemoveFromOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listOrderView.Items.Count; i++)
            {
                if (listOrderView.Items[i].Selected)
                {
                    int quantity = int.Parse(listOrderView.Items[i].SubItems[2].Text);
                    float individualPrice = float.Parse(listOrderView.Items[i].SubItems[1].Text) / float.Parse(quantity.ToString());

                    float total = float.Parse(lblTotal.Text);
                    total -= individualPrice;
                    lblTotal.Text = total.ToString("0.00");

                    if (quantity > 1)
                    {
                        quantity--;
                        float totalProduct = float.Parse(listOrderView.Items[i].SubItems[1].Text) - individualPrice;
                        listOrderView.Items[i].SubItems[1].Text = totalProduct.ToString("0.00");
                        listOrderView.Items[i].SubItems[2].Text = quantity.ToString();
                    }
                    else
                    {
                        listOrderView.Items[i].Remove();
                    }
                }
            }
        }
        private void btnDrankKaart_Click(object sender, EventArgs e)
        {
            pnl_MenuType.Hide();
            pnl_Drank.Show();
        }
        private void btnVoorgerecht_Click(object sender, EventArgs e)
        {
            pnl_MenuType.Hide();
            pnl_Drank.Hide();
            ShowMenuItems(1);
        }
        private void btnHoofdgerecht_Click(object sender, EventArgs e)
        {
            pnl_MenuType.Hide();
            pnl_Drank.Hide();
            ShowMenuItems(2);
        }
        private void btnNagerecht_Click(object sender, EventArgs e)
        {
            pnl_MenuType.Hide();
            pnl_Drank.Hide();
            ShowMenuItems(3);
        }
        private void btnTussengerecht_Click(object sender, EventArgs e)
        {
            pnl_MenuType.Hide();
            ShowMenuItems(4);
        }
        private void btnFrisdrank_Click(object sender, EventArgs e)
        {
            pnl_Drank.Hide();
            ShowMenuItems(5);
        }
        private void btnBieren_Click(object sender, EventArgs e)
        {
            pnl_Drank.Hide();
            ShowMenuItems(6);
        }
        private void btnWijnen_Click(object sender, EventArgs e)
        {
            pnl_Drank.Hide();
            ShowMenuItems(7);
        }
        private void btnGedestDrank_Click(object sender, EventArgs e)
        {
            pnl_Drank.Hide();
            ShowMenuItems(8);
        }
        private void btnKoffieThee_Click(object sender, EventArgs e)
        {
            pnl_Drank.Hide();
            ShowMenuItems(9);
        }
        private void btnKaartOverzicht_Click(object sender, EventArgs e)
        {
            listMenuView.Clear();
            pnl_MenuType.Show();
        }
        private void btnKaartoverzicht2_Click(object sender, EventArgs e)
        {
            listMenuView.Clear();
            pnl_Klacht.Hide();
            pnl_MenuType.Show();
        }
        private void btnKaartoverzicht3_Click(object sender, EventArgs e)
        {
            listMenuView.Clear();
            pnl_Instructies.Hide();
            pnl_MenuType.Show();
        }
        // tafels
        private void btnTafel1_Click(object sender, EventArgs e)
        {
            lblTafelnr.Text = "1";
            HideTableShowMenu();
        }
        private void btnTafel2_Click(object sender, EventArgs e)
        {
            lblTafelnr.Text = "2";
            HideTableShowMenu();
        }
        private void btnTafel3_Click(object sender, EventArgs e)
        {
            lblTafelnr.Text = "3";
            HideTableShowMenu();
        }
        private void btnTafel4_Click(object sender, EventArgs e)
        {
            lblTafelnr.Text = "4";
            HideTableShowMenu();
        }
        private void btnTafel5_Click(object sender, EventArgs e)
        {
            lblTafelnr.Text = "5";
            HideTableShowMenu();
        }
        private void btnTafel6_Click(object sender, EventArgs e)
        {
            lblTafelnr.Text = "6";
            HideTableShowMenu();
        }
        private void btnTafel7_Click(object sender, EventArgs e)
        {
            lblTafelnr.Text = "7";
            HideTableShowMenu();
        }
        private void btnTafel8_Click(object sender, EventArgs e)
        {
            lblTafelnr.Text = "8";
            HideTableShowMenu();
        }
        private void btnTafel9_Click(object sender, EventArgs e)
        {
            lblTafelnr.Text = "9";
            HideTableShowMenu();
        }
        private void btnTafel10_Click(object sender, EventArgs e)
        {
            lblTafelnr.Text = "10";
            HideTableShowMenu();
        }
        public void HideTableShowMenu()
        {
            pnl_TafelSelect.Hide();
            pnl_Tafelnr.Show();
            ShowColumns();
        }
        private void btnTafelOverzicht_Click(object sender, EventArgs e)
        {
            if (listOrderView.Items.Count > 0)
            {
                string message = "Bestelling is niet opgeslagen. Weet u zeker dat u een nieuwe tafel wilt selecteren?";
                string caption = "Chapoo";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                    lblTotal.Text = "0.00";
                    listOrderView.Clear();
                    pnl_TafelSelect.Show();
                    pnl_Tafelnr.Hide();
            }
            else 
                pnl_TafelSelect.Show();
                listOrderView.Clear();
                pnl_Tafelnr.Hide();
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            List<Order_Product> OrderList = new List<Order_Product>();
            for (int i = 0; i < listOrderView.Items.Count; i++)
            {
                int id = int.Parse(listOrderView.Items[i].SubItems[3].Text);
                int aantal = int.Parse(listOrderView.Items[i].SubItems[2].Text);
                Order_Product orderItem = new Order_Product(id, aantal);
                OrderList.Add(orderItem);
            }
            Bestelling bestelling = new Bestelling 
            (
                int.Parse(lblTafelnr.Text),
                float.Parse(lblTotal.Text),
                txtKlacht.Text,
                txtInstructies.Text,
                "Nieuw",
                OrderList
            );
            Bestelling_Service bestellingService = new Bestelling_Service();
            if (bestellingService.AddBestelling(bestelling))
            {
                lblTotal.Text = "0.00";
                listOrderView.Clear();
                pnl_Tafelnr.Hide();
                pnl_TafelSelect.Show();
                MessageBox.Show($"Bestelling voor tafel {lblTafelnr.Text} is geplaatst.");
            }
        }
        private void btnKlacht_Click(object sender, EventArgs e)
        {
            pnl_Klacht.Show();
        }

        private void btnInstructies_Click(object sender, EventArgs e)
        {
            pnl_Instructies.Show();
        }
    }
}
