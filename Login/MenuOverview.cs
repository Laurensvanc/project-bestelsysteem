using ChapooLogic;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class MenuOverview : Form
    {
        private Menu_Service _menuService;
        private List<MenuName> _menus;
        private string _menuName;
        private string _menuType;
        private Point _typeButtonsLocation = new Point(126, 396);
        private bool _deleting = false;

        public MenuOverview()
        {
            InitializeComponent();
        }

        private void MenuOverview_Load(object sender, EventArgs e)
        {
            _menuService = new Menu_Service();

            // hide fields and set button location
            lbl_Instruction.Hide();
            pnl_MenuDrankButtons.Location = _typeButtonsLocation;
            pnl_MenuDinerButtons.Location = _typeButtonsLocation;
            pnl_MenuLunchButtons.Location = _typeButtonsLocation;
            pnl_MenuDrankButtons.Hide();
            pnl_MenuDinerButtons.Hide();
            pnl_MenuLunchButtons.Hide();
            pnl_ActionButtons.Hide();

            Menu_Refresh();
        }

        private void Menu_Refresh()
        {
            // refresh menu
            _menus = _menuService.GetMenus();
            flp_MenuOverview.Controls.Clear();
            FillOverview();
        }

        private void FillOverview()
        {
            // fill flowlayoutpanel
            List<Button> buttons = new List<Button>();
            foreach (MenuName menu in _menus) // make buttons for every item matching filter
            {
                if (menu.Name == _menuName)
                {
                    foreach (MenuType menuType in menu.menuTypes)
                    {
                        if (menuType.Type == _menuType)
                        {
                            foreach (Product product in menuType.products)
                            {
                                Button btn = new Button();
                                btn.Name = product.ProductId.ToString();
                                btn.Text = product.ProductNaam;
                                btn.Size = new Size(165, 75);
                                btn.FlatStyle = FlatStyle.Popup;
                                btn.BackColor = Color.White;
                                btn.Click += btn_Click;
                                buttons.Add(btn);
                            }
                        }
                    }
                }
            }

            foreach (Button b in buttons)
            {
                flp_MenuOverview.Controls.Add(b);
            }
            if (flp_MenuOverview.Controls.Count > 0)
            {
                lbl_Instruction.Show();
            }
            else
            {
                lbl_Instruction.Hide();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MenuName menu = _menus.Find(m => m.Name == _menuName);
            MenuType menuType = menu.menuTypes.Find(mt => mt.Type == _menuType);
            Product product = menuType.products.Find(p => p.ProductId == int.Parse(button.Name));

            if (_deleting == true)
            {
                // if deleting mode is on delete item
                Product p = new Product(product.ProductId);
                MenuType mt = new MenuType(menuType.SoortID);
                mt.products.Add(p);
                MenuName m = new MenuName(menu.MenuId);
                m.menuTypes.Add(mt);

                DialogResult confirm = MessageBox.Show($"[{product}] zal verwijderd worden van de [{menu.Name}] onder de categorie [{menuType.Type}].\n\nWeet je het zeker?", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK) // if confirmed delete product from menu
                {
                    _menuService.RemoveMenu(m);
                    MessageBox.Show("Product verwijderd.", "Succes");
                    Menu_Refresh();
                }
            }
            else
            {
                // display info when clicking on a product
                MessageBox.Show($"Aantal:\t\t{product.Aantal}\nPrijs:\t\t€{product.Prijs.ToString("0.00")}\nAlcoholisch:\t{product.IsAlcohol}", product.ToString());
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (_deleting == false)
            {
                // turn delete mode on and change colours
                _deleting = true;
                button.BackColor = Color.Red;
                lbl_Instruction.ForeColor = Color.Red;
                lbl_Instruction.Text = "Klik een product om te verwijderen";
            }
            else
            {
                // turn delete mode off and turn colours back
                _deleting = false;
                lbl_Instruction.ForeColor = SystemColors.ControlText;
                lbl_Instruction.Text = "Klik een product voor meer info";
                button.BackColor = SystemColors.Control;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // opens window to add/change menu
            int menuId = 0;
            foreach (MenuName menu in _menus)
            {
                if (_menuName == menu.Name)
                {
                    menuId = menu.MenuId;
                    break;
                }
            }
            if (menuId > 0)
            {
                bool drinks = false;
                if (_menuName == "Drank Kaart")
                {
                    drinks = true;
                }
                using (var menuChange = new MenuChange(_menuName, menuId, drinks))
                {
                    menuChange.ShowDialog();
                }
                Menu_Refresh();
            }
        }

        private void OverviewChanged()
        {
            // whenever a button is pressed check for labels and refresh menu
            lbl_Instruction.Hide();
            flp_MenuOverview.Controls.Clear();
            if (!String.IsNullOrEmpty(_menuName))
            {
                pnl_ActionButtons.Show();
                lbl_Instruction2.Hide();
            }
            else
            {
                lbl_Instruction2.Show();
                pnl_ActionButtons.Hide();
            }
            Menu_Refresh();
        }

        private void btn_Drank_Click(object sender, EventArgs e)
        {
            pnl_MenuDinerButtons.Hide();
            pnl_MenuLunchButtons.Hide();
            pnl_MenuDrankButtons.Show();

            _menuName = "Drank Kaart";
            _menuType = "";
            OverviewChanged();
        }

        private void btn_Diner_Click(object sender, EventArgs e)
        {
            pnl_MenuDrankButtons.Hide();
            pnl_MenuLunchButtons.Hide();
            pnl_MenuDinerButtons.Show();

            _menuName = "Diner Kaart";
            _menuType = "";
            OverviewChanged();
        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            pnl_MenuDrankButtons.Hide();
            pnl_MenuDinerButtons.Hide();
            pnl_MenuLunchButtons.Show();

            _menuName = "Lunch Kaart";
            _menuType = "";
            OverviewChanged();
        }

        private void btn_DrankF_Click(object sender, EventArgs e)
        {
            _menuType = "Frisdrank";
            OverviewChanged();
        }

        private void btn_DrankB_Click(object sender, EventArgs e)
        {
            _menuType = "Bieren";
            OverviewChanged();
        }

        private void btn_DrankW_Click(object sender, EventArgs e)
        {
            _menuType = "Wijnen";
            OverviewChanged();
        }

        private void btn_DrankG_Click(object sender, EventArgs e)
        {
            _menuType = "Gedistilleerde dranken";
            OverviewChanged();
        }

        private void btn_DrankK_Click(object sender, EventArgs e)
        {
            _menuType = "Koffie / Thee";
            OverviewChanged();
        }

        private void btn_LunchV_Click(object sender, EventArgs e)
        {
            _menuType = "Voorgerechten";
            OverviewChanged();
        }

        private void btn_LunchH_Click(object sender, EventArgs e)
        {
            _menuType = "Hoofdgerechten";
            OverviewChanged();
        }

        private void btn_LunchN_Click(object sender, EventArgs e)
        {
            _menuType = "Nagerechten";
            OverviewChanged();
        }

        private void btn_DinerV_Click(object sender, EventArgs e)
        {
            _menuType = "Voorgerechten";
            OverviewChanged();
        }

        private void btn_DinerT_Click(object sender, EventArgs e)
        {
            _menuType = "Tussengerechten";
            OverviewChanged();
        }

        private void btn_DinerH_Click(object sender, EventArgs e)
        {
            _menuType = "Hoofdgerechten";
            OverviewChanged();
        }

        private void btn_DinerN_Click(object sender, EventArgs e)
        {
            _menuType = "Nagerechten";
            OverviewChanged();
        }
    }
}