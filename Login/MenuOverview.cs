using ChapooLogic;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Login
{
    public partial class MenuOverview : UserControl
    {
        private Menu_Service _menuService;
        private List<MenuName> _menus;
        private string _menuName;
        private string _menuType;
        private readonly Point _typeButtonsLocation = new Point(370, 849); // location submenu bar
        private bool _deleting;

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
            foreach (MenuName menu in _menus) // make buttons for every item matching filter
            {
                if (menu.Name != _menuName) continue; // if not match continue
                foreach (MenuType menuType in menu.MenuTypes)
                {
                    if (menuType.Type != _menuType) continue; // if not match continue
                    foreach (Product product in menuType.Products)
                    {
                        Button btn = new Button
                        {
                            Name = product.ProductId.ToString(),
                            Text = product.ProductNaam,
                            Size = new Size(215, 100),
                            FlatStyle = FlatStyle.Popup,
                            BackColor = Color.White
                        };
                        btn.Click += btn_Click;
                        flp_MenuOverview.Controls.Add(btn);
                    }
                }
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
            // searches for item clicked
            Button button = (Button)sender;
            MenuName menu = _menus.Find(m => m.Name == _menuName);
            MenuType menuType = menu.MenuTypes.Find(mt => mt.Type == _menuType);
            Product product = menuType.Products.Find(p => p.ProductId == int.Parse(button.Name));

            if (_deleting) // check if deleting mode is on
            {
                // delete item from menu
                DeleteFromMenu(product, menuType, menu);
            }
            else
            {
                // display info when clicking on a product
                string alcohol;
                if (product.IsAlcohol)
                {
                    alcohol = "Ja";
                }
                else
                {
                    alcohol = "Nee";
                }
                MessageBox.Show($"Aantal:\t\t{product.Aantal}\nPrijs:\t\t€{product.Prijs.ToString("0.00")}\nAlcoholisch:\t{alcohol}", product.ToString());
            }
        }

        private void DeleteFromMenu(Product product, MenuType menuType, MenuName menu)
        {
            // put product in correct menutype and menu
            Product p = new Product(product.ProductId);
            MenuType mt = new MenuType(menuType.SoortID);
            mt.Products.Add(p);
            MenuName m = new MenuName(menu.MenuId);
            m.MenuTypes.Add(mt);

            DialogResult confirm = MessageBox.Show($"[{product}] zal verwijderd worden van de [{menu.Name}] onder de categorie [{menuType.Type}].\n\nWeet je het zeker?", "Confirmation", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK) // if confirmed delete product from menu
            {
                _menuService.RemoveMenu(m);
                MessageBox.Show("Product verwijderd.", "Succes");
                Menu_Refresh();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            // switches delete mode on and off
            Button button = (Button)sender;
            if (_deleting == false)
            {
                // turn delete mode on and change colours
                _deleting = true;
                button.BackColor = Color.Red;
                lbl_Instruction.ForeColor = Color.Red;
                lbl_Instruction.Text = "Druk op een product om te verwijderen";
            }
            else
            {
                // turn delete mode off and turn colours back
                _deleting = false;
                lbl_Instruction.ForeColor = Color.White;
                lbl_Instruction.Text = "Druk op een product voor meer info";
                button.BackColor = Color.FromArgb(237, 99, 151);
                if (String.IsNullOrEmpty(_menuType)) // if no submenu is selected hide button
                {
                    button.Hide();
                }
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
            if (menuId > 0) // checks which products to load
            {
                bool drinks = _menuName == "Drank Kaart";
                using (var menuChange = new MenuChange(_menuName, menuId, drinks))
                {
                    menuChange.ShowDialog();
                }
                Menu_Refresh();
            }
        }

        private void OverviewChanged(object sender)
        {
            // whenever a button is pressed check for labels and buttons to show
            lbl_Instruction.Hide();
            flp_MenuOverview.Controls.Clear();
            Button button = (Button)sender;
            if (button.Text == _menuName) // if selected menu is current menu selected > unselect menu
            {
                // hide buttons and show instruction
                lbl_Instruction2.Show();
                pnl_ActionButtons.Hide();
                pnl_MenuDinerButtons.Hide();
                pnl_MenuDrankButtons.Hide();
                pnl_MenuLunchButtons.Hide();
                _menuName = null;
                _menuType = null;

                // reset colours
                Control control = ((Button)sender).Parent;
                Panel panel = (Panel)control;
                ResetColors(panel);
            }
            else if (button.Parent != pnl_MenuButtons) // if menu selected is not a main menu > show submenu, show remove button
            {
                _menuType = button.Text;
                btn_Remove.Show();
                ButtonColor(sender);
            }
            else // another menu is selected > hide submenu
            {
                _menuType = null;
                if (_deleting == false) // if delete mode is off hide button
                {
                    btn_Remove.Hide();
                }
                pnl_ActionButtons.Show();
                _menuName = button.Text;
                lbl_Instruction2.Hide();
                ButtonColor(sender);
            }
            FillOverview();
        }

        private void ButtonColor(object sender)
        {
            // changes button colour if button is pressed
            Button button = (Button)sender;
            Control panel = ((Button)sender).Parent;

            // change button colour to selected mode
            foreach (Button b in panel.Controls.OfType<Button>())
            {
                if (b.Name != button.Name)
                {
                    b.FlatAppearance.BorderSize = 0;
                }
                else
                {
                    b.FlatAppearance.BorderSize = 3;
                }
            }
        }

        private void ResetColors(Panel pnl_MenuDrankButtons)
        {
            // reset colours to default
            foreach (Button b in pnl_MenuDrankButtons.Controls.OfType<Button>())
            {
                b.FlatAppearance.BorderSize = 0;
            }
        }

        private void btn_Drank_Click(object sender, EventArgs e)
        {
            pnl_MenuDinerButtons.Hide();
            pnl_MenuLunchButtons.Hide();
            pnl_MenuDrankButtons.Show();

            OverviewChanged(sender);
            ResetColors(pnl_MenuDrankButtons);
        }

        private void btn_Diner_Click(object sender, EventArgs e)
        {
            pnl_MenuDrankButtons.Hide();
            pnl_MenuLunchButtons.Hide();
            pnl_MenuDinerButtons.Show();

            OverviewChanged(sender);
            ResetColors(pnl_MenuDinerButtons);
        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            pnl_MenuDrankButtons.Hide();
            pnl_MenuDinerButtons.Hide();
            pnl_MenuLunchButtons.Show();

            OverviewChanged(sender);
            ResetColors(pnl_MenuLunchButtons);
        }

        private void btn_DrankF_Click(object sender, EventArgs e)
        {
            OverviewChanged(sender);
        }

        private void btn_DrankB_Click(object sender, EventArgs e)
        {
            OverviewChanged(sender);
        }

        private void btn_DrankW_Click(object sender, EventArgs e)
        {
            OverviewChanged(sender);
        }

        private void btn_DrankG_Click(object sender, EventArgs e)
        {
            OverviewChanged(sender);
        }

        private void btn_DrankK_Click(object sender, EventArgs e)
        {
            OverviewChanged(sender);
        }

        private void btn_LunchV_Click(object sender, EventArgs e)
        {
            OverviewChanged(sender);
        }

        private void btn_LunchH_Click(object sender, EventArgs e)
        {
            OverviewChanged(sender);
        }

        private void btn_LunchN_Click(object sender, EventArgs e)
        {
            OverviewChanged(sender);
        }

        private void btn_DinerV_Click(object sender, EventArgs e)
        {
            OverviewChanged(sender);
        }

        private void btn_DinerT_Click(object sender, EventArgs e)
        {
            OverviewChanged(sender);
        }

        private void btn_DinerH_Click(object sender, EventArgs e)
        {
            OverviewChanged(sender);
        }

        private void btn_DinerN_Click(object sender, EventArgs e)
        {
            OverviewChanged(sender);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Menu_Refresh();
        }
    }
}