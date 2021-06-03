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
    public partial class BestellingOpnemenDesktop : UserControl
    {
        public Product_Service productService = new Product_Service();
        public List<Product> productList = new List<Product>();
        private Tafel_Service TafelService = new Tafel_Service();
        private int _tableNr = 0;
        private Account _account;
        public BestellingOpnemenDesktop(Account account)
        {
            _account = account;
            InitializeComponent();
            ShowTables(); // Tafels
            DisableButtons(); // Disable buttons before selecting a table
            pnl_Drank.Hide();
            txtNotities.Show();
            txtKlacht.Hide();
        }
        public void ShowTables()
        {
            flp_TableSelect.Controls.Clear();
            for (int i = 1; i < 11; i++)
            {
                Button btn = new Button();
                btn.Name = i.ToString();
                btn.Text = "Tafel " + i.ToString();
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Size = new Size(205, 34);
                btn.FlatStyle = FlatStyle.Flat;
                if (_tableNr == i) btn.BackColor = Color.FromArgb(176, 113, 137);
                else btn.BackColor = Color.FromArgb(146, 60, 93);
                btn.Margin = new Padding(0, 0, 0, 0);
                btn.Click += btn_Click;
                flp_TableSelect.Controls.Add(btn);
            }

            if (_tableNr == 0) lblTafelSelectAlert.Show();
            else lblTafelSelectAlert.Hide();
        }
        public void DisableButtons()
        {
            btnDrankKaart.Enabled = false;
            btnVoorgerecht.Enabled = false;
            btnHoofdgerecht.Enabled = false;
            btnNagerecht.Enabled = false;
            btnTussengerecht.Enabled = false;
        }
        public void EnableButtons()
        {
            btnDrankKaart.Enabled = true;
            btnVoorgerecht.Enabled = true;
            btnHoofdgerecht.Enabled = true;
            btnNagerecht.Enabled = true;
            btnTussengerecht.Enabled = true;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            bool dontSwitchTable = false;
            if (listOrderView.Items.Count > 0)
            {
                string message = "Bestelling is niet opgeslagen. Weet u zeker dat u een nieuwe tafel wilt selecteren?";
                string caption = "Chapoo";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    lblTotal.Text = "0.00";
                    listMenuView.Clear();
                    listOrderView.Clear();
                }
                else dontSwitchTable = true;
            }
            else
            {
                listMenuView.Clear();
            }
            Button button = (Button)sender;
            if (!dontSwitchTable) _tableNr = int.Parse(button.Name);
            EnableButtons();
            ShowTables();
            ShowColumns();
            pnl_MenuType.Show();
        }
        public void ShowColumns()
        {
            listOrderView.Columns.Add("Bestelling", 615);
            listOrderView.Columns.Add("Aantal", 75);
            listOrderView.Columns.Add("Prijs", 80);
            listOrderView.Columns.Add("ID", 40);
        }
        public void ShowMenuItems(int soortID)
        {
            listMenuView.Columns.Clear();
            listMenuView.Items.Clear();
            productList = productService.GetSpecificProduct(soortID);

            listMenuView.Columns.Add("Bestelling", 615);
            listMenuView.Columns.Add("Aantal", 75);
            listMenuView.Columns.Add("Prijs", 80);
            listMenuView.Columns.Add("ID", 40);

            foreach (Product product in productList)
            {
                ListViewItem li = new ListViewItem(product.ProductNaam);
                li.SubItems.Add(product.Aantal.ToString());
                li.SubItems.Add(product.Prijs.ToString("0.00"));
                li.SubItems.Add(product.ProductId.ToString());
                if (product.Aantal == 0) li.ForeColor = Color.Red;
                listMenuView.Items.Add(li);
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listMenuView.Items.Count; i++)
            {
                if (listMenuView.Items[i].Selected && int.Parse(listMenuView.Items[i].SubItems[1].Text) != 0)
                {
                    float total = float.Parse(lblTotal.Text);
                    bool enoughStock = true;
                    if (listOrderView.Items.Count == 0)
                    {
                        ListViewItem li = new ListViewItem(productList[i].ProductNaam);
                        li.SubItems.Add("1");
                        li.SubItems.Add(productList[i].Prijs.ToString("0.00"));
                        li.SubItems.Add(productList[i].ProductId.ToString());
                        listOrderView.Items.Add(li);
                    }
                    else
                    {
                        int item = 0;
                        bool duplicate = false;
                        do
                        {
                            if (listOrderView.Items[item].SubItems[3].Text == listMenuView.Items[i].SubItems[3].Text && listMenuView.Items[i].SubItems[1].Text != listOrderView.Items[item].SubItems[1].Text)
                            {
                                int quantity = int.Parse(listOrderView.Items[item].SubItems[1].Text) + 1;
                                float totalProduct = float.Parse(listOrderView.Items[item].SubItems[2].Text) + float.Parse(listMenuView.Items[i].SubItems[2].Text);
                                listOrderView.Items[item].SubItems[1].Text = quantity.ToString();
                                listOrderView.Items[item].SubItems[2].Text = totalProduct.ToString("0.00");
                                duplicate = true;
                                break;
                            } else if (listMenuView.Items[i].SubItems[1].Text == listOrderView.Items[item].SubItems[1].Text)
                            {
                                MessageBox.Show($"Niet genoeg voorraad product '{listMenuView.Items[i].SubItems[0].Text}' voor bestelling", "Chapoo");
                                enoughStock = false;
                            }
                            item++;
                        } while (item < listOrderView.Items.Count);
                        if (!duplicate && enoughStock)
                        {
                            ListViewItem li = new ListViewItem(productList[i].ProductNaam);
                            li.SubItems.Add("1");
                            li.SubItems.Add(productList[i].Prijs.ToString("0.00"));
                            li.SubItems.Add(productList[i].ProductId.ToString());
                            listOrderView.Items.Add(li);
                        }
                    }
                    if (enoughStock)
                    {
                        total += float.Parse(listMenuView.Items[i].SubItems[2].Text);
                        lblTotal.Text = total.ToString("0.00");
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
                    int quantity = int.Parse(listOrderView.Items[i].SubItems[1].Text);
                    float individualPrice = float.Parse(listOrderView.Items[i].SubItems[2].Text) / float.Parse(quantity.ToString());

                    float total = float.Parse(lblTotal.Text);
                    total -= individualPrice;
                    lblTotal.Text = total.ToString("0.00");

                    if (quantity > 1)
                    {
                        quantity--;
                        float totalProduct = float.Parse(listOrderView.Items[i].SubItems[2].Text) - individualPrice;
                        listOrderView.Items[i].SubItems[2].Text = totalProduct.ToString("0.00");
                        listOrderView.Items[i].SubItems[1].Text = quantity.ToString();
                    }
                    else
                    {
                        listOrderView.Items[i].Remove();
                    }
                }
            }
        }
        public void OpenBottle(int soortID) // if whine glas=0: bottle-1, whine glas+5
        {
            for (int i = 0; i < listMenuView.Items.Count; i++)
            {
                if (listMenuView.Items[i].SubItems[0].Text.Contains("(glas)") && listMenuView.Items[i].SubItems[1].Text == "0")
                {
                    int bottleID = GetBottleID(listMenuView.Items[i].SubItems[0].Text);
                    if (bottleID != 0)
                    {
                        productService.OpenBottle(bottleID, int.Parse(listMenuView.Items[i].SubItems[3].Text));
                    }
                }
            }
            ShowMenuItems(soortID);
        }
        public int GetBottleID(string glasNaam)
        {
            string flesNaam = glasNaam.Replace("(glas)", "(fles)");
            int bottleID = 0;
            for (int i = 0; i < listMenuView.Items.Count; i++)
            {
                if (listMenuView.Items[i].SubItems[0].Text.Contains(flesNaam) && listMenuView.Items[i].SubItems[1].Text != "0")
                {
                    bottleID = int.Parse(listMenuView.Items[i].SubItems[3].Text); // return id from bottle
                }
            }
            return bottleID;
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
            OpenBottle(7);
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
                {
                    lblTotal.Text = "0.00";
                    listOrderView.Clear();
                }
            }
            else 
            {
                listOrderView.Clear();
            }
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            List<Order_Product> OrderList = new List<Order_Product>();
            for (int i = 0; i < listOrderView.Items.Count; i++)
            {
                int id = int.Parse(listOrderView.Items[i].SubItems[3].Text);
                int aantal = int.Parse(listOrderView.Items[i].SubItems[1].Text);
                Order_Product orderItem = new Order_Product(id, aantal);
                OrderList.Add(orderItem);
            }
            Bestelling bestelling = new Bestelling 
            (
                TafelService.GetTafel(_tableNr),
                float.Parse(lblTotal.Text),
                txtKlacht.Text,
                txtNotities.Text,
                "Nieuw",
                _account.WerknemerID,
                OrderList
            );
            Bestelling_Service bestellingService = new Bestelling_Service();
            if (OrderList.Count() == 0)
            {
                MessageBox.Show("Geen bestelling gevonden, probeer nog een keer.");
            } else if  (bestellingService.AddBestelling(bestelling))
            {
                Tafel_Service tafelService = new Tafel_Service();
                tafelService.UpdateTafelMedewerker(_account.WerknemerID, _tableNr);
                lblTotal.Text = "0.00";
                listOrderView.Clear();
                txtNotities.Text = "";
                ShowTables(); // Tafels
                DisableButtons(); // Disable buttons before selecting a table
                pnl_Drank.Hide();
                pnl_MenuType.Show();
                txtNotities.Show();
                txtKlacht.Hide();
                MessageBox.Show($"Bestelling voor tafel {_tableNr} is geplaatst.");
                _tableNr = 0;
            }
        }
        private void btnKlacht_Click(object sender, EventArgs e)
        {
            lblNotitieKlacht.Text = "Klacht";
            txtNotities.Hide();
            txtKlacht.Show();
        }

        private void btnNotities_Click(object sender, EventArgs e)
        {
            lblNotitieKlacht.Text = "Notities";
            txtNotities.Show();
            txtKlacht.Hide();
        }
    }
}
