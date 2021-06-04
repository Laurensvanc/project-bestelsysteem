using ChapooLogic;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Login
{
    public partial class BestellingOpnemen : UserControl
    {
        private ChoosePlatform _platform;
        private MobileHome _mobileMenu;
        public Product_Service productService;
        private Reservering_Service _reserveringService;
        private Transaction_Service _transactionService;
        public List<Product> productList = new List<Product>();
        private Tafel_Service TafelService = new Tafel_Service();
        public Account _account;

        public BestellingOpnemen(ChoosePlatform platform, MobileHome mobileMenu, Account account)
        {
            InitializeComponent();
            pnl_Drank.Hide();
            pnl_Tafelnr.Hide();
            pnl_Klacht.Hide();
            pnl_Notities.Hide();
            _platform = platform;
            _mobileMenu = mobileMenu;
            _account = account;
            _reserveringService = new Reservering_Service();
            _transactionService = new Transaction_Service();
            UpdateTables();
        }

        public void ShowColumns()
        {
            listOrderView.Columns.Add("Bestelling", 208);
            listOrderView.Columns.Add("Aantal", 75);
            listOrderView.Columns.Add("Prijs", 80);
            listOrderView.Columns.Add("ID", 40);
        }

        public void ShowMenuItems(int soortID)
        {
            listMenuView.Columns.Clear();
            listMenuView.Items.Clear();
            productList = productService.GetSpecificProduct(soortID);

            listMenuView.Columns.Add("Bestelling", 208);
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

        private void UpdateTables()
        {
            List<Button> btns = new List<Button>();

            foreach (Control c in pnl_TafelSelect.Controls)
            {
                if (c is Button && c.Text.Contains("Tafel"))
                {
                    btns.Add((Button)c);
                }
            }
            GetTableStatus(btns);
        }

        private void GetTableStatus(List<Button> btns)
        {
            List<Reservering> reserverings = _reserveringService.GetReserverings();

            List<int> tableList = _transactionService.GetTables();
            List<int> tafelToBezet = new List<int>();
            List<int> tafelToGereserveerd = new List<int>();
            DateTime nu = DateTime.Now;
            foreach (Reservering r in reserverings)
            {
                if (r.BeginTijd < nu && r.EindTijd > nu || tableList.Contains(r.Tafel.TafelNummer))
                {
                    tafelToBezet.Add(r.Tafel.TafelNummer);
                }
                else if (r.BeginTijd < nu.AddHours(2) && r.EindTijd > nu)
                {
                    tafelToGereserveerd.Add(r.Tafel.TafelNummer);
                }
            }

            btns.Reverse();
            for (int i = 0; i < 10; i++)
            {
                if (tafelToBezet.Contains(i + 1))
                {
                    btns[i].Text = $"Tafel {i+1}\n[Bezet]";
                }

                if (tafelToGereserveerd.Contains(i + 1))
                {
                    btns[i].Text = $"Tafel {i+1}\n[Gereserveerd]";
                }
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
                            }
                            else if (listMenuView.Items[i].SubItems[1].Text == listOrderView.Items[item].SubItems[1].Text)
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

        private void btnKaartoverzicht2_Click(object sender, EventArgs e)
        {
            listMenuView.Clear();
            pnl_Klacht.Hide();
            pnl_MenuType.Show();
        }

        private void btnKaartoverzicht3_Click(object sender, EventArgs e)
        {
            listMenuView.Clear();
            pnl_Notities.Hide();
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
                {
                    lblTotal.Text = "0.00";
                    listOrderView.Clear();
                    pnl_TafelSelect.Show();
                    pnl_Tafelnr.Hide();
                }
            }
            else
            {
                pnl_TafelSelect.Show();
                listOrderView.Clear();
                pnl_Tafelnr.Hide();
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            List<Order_Product> OrderList = new List<Order_Product>();
            for (int i = 0; i < listOrderView.Items.Count; i++)
            {
                Product product = new Product(int.Parse(listOrderView.Items[i].SubItems[3].Text));
                int aantal = int.Parse(listOrderView.Items[i].SubItems[1].Text);
                Order_Product orderItem = new Order_Product(product, aantal);
                OrderList.Add(orderItem);
            }
            Bestelling bestelling = new Bestelling
            (
                TafelService.GetTafel(int.Parse(lblTafelnr.Text)),
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
            }
            else if (bestellingService.AddBestelling(bestelling))
            {
                Tafel_Service tafelService = new Tafel_Service();
                tafelService.UpdateTafelMedewerker(_account.WerknemerID, int.Parse(lblTafelnr.Text));
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

        private void btnNotities_Click(object sender, EventArgs e)
        {
            pnl_Notities.Show();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            MobileLogin mobileLogin = new MobileLogin(_platform);

            mobileLogin.Show();
            //this.Hide();
            _mobileMenu.Hide();
        }

        private void btn_RefreshTables_Click(object sender, EventArgs e)
        {
            UpdateTables();
        }
    }
}