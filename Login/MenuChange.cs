using ChapooLogic;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class MenuChange : Form
    {
        private Menu_Service _menuService;
        private Product_Service _productService;
        private List<Product> _products;
        private List<MenuName> _menus;
        private int _selectedProduct = 0;
        private string _productName;
        private bool _drinks = false;
        private string _menuName;
        private int _menuId;
        private List<Button> _buttons;

        public MenuChange(string menuName, int menuId, bool drinks)
        {
            InitializeComponent();
            _menuName = menuName;
            _menuId = menuId;
            _drinks = drinks;
            lbl_Menu.Text = _menuName;
        }

        private void MenuChange_Load(object sender, EventArgs e)
        {
            flp_MenuOverview.Controls.Clear();
            _menuService = new Menu_Service();
            _productService = new Product_Service();
            _buttons = new List<Button>();
            UpdateProducts();
            GetProducts();
        }

        private void UpdateProducts()
        {
            // update menu and product lists
            _menus = _menuService.GetMenus();
            _products = _productService.GetProducts();
        }

        private void GetProducts()
        {
            // get products for flowlayoutpanel
            _buttons.Clear();
            foreach (Product product in _products) // make buttons for every item matching filter
            {
                if ((product.IsDrinken == true && _drinks == true) || (product.IsDrinken == false && _drinks == false))
                {
                    MakeButton(product);
                }
            }
            AddButtons();
        }

        private void MakeButton(Product product)
        {
            // make button for flowlayoutpanel
            Button btn = new Button();
            btn.Name = product.ProductId.ToString();
            btn.Text = product.ProductNaam;
            btn.Size = new Size(130, 65);
            btn.FlatStyle = FlatStyle.Popup;
            btn.BackColor = Color.White;
            btn.Click += btn_Click;
            _buttons.Add(btn);
        }

        private void AddButtons()
        {
            // add buttons to flowlayoutpanel
            flp_MenuOverview.Controls.Clear();
            foreach (Button b in _buttons)
            {
                flp_MenuOverview.Controls.Add(b);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // sets product to whichever is clicked and changes its colour
            Button button = (Button)sender;
            _selectedProduct = int.Parse(button.Name);
            _productName = button.Text;
            foreach (Button b in flp_MenuOverview.Controls)
            {
                b.BackColor = Color.White;
            }
            button.BackColor = Color.LightGray;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (_selectedProduct != 0) // if a product is selected
            {
                if (cbox_Category.SelectedIndex > -1) // if a category is selected
                {
                    int typeId = 0;
                    foreach (MenuName m in _menus)
                    {
                        foreach (MenuType mt in m.menuTypes)
                        {
                            if (mt.Type == (String)cbox_Category.SelectedItem) // find matching category ID
                            {
                                typeId = mt.SoortID;
                                break;
                            }
                        }
                    }
                    if (typeId > 0) // if ID is found (should be always but makes errorproof)
                    {
                        // add all ID's into product > menutype > menu
                        Product product = new Product(_selectedProduct);
                        MenuType menuType = new MenuType(typeId);
                        menuType.products.Add(product);
                        MenuName menu = new MenuName(_menuId);
                        menu.menuTypes.Add(menuType);
                        if (!Exists(menu)) // checks if product is already on the menu
                        {
                            DialogResult confirm = MessageBox.Show($"{_productName} zal op de {_menuName} worden toegevoegd bij {(String)cbox_Category.SelectedItem}", "Confirmation", MessageBoxButtons.OKCancel);
                            if (confirm == DialogResult.OK) // if confirmed add product to menu
                            {
                                _menuService.ChangeMenu(menu);
                                UpdateProducts();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product bestaat al op menu!", "Error!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kies een categorie!", "Error!");
                }
            }
            else
            {
                MessageBox.Show("Kies een product!", "Error!");
            }
        }

        private bool Exists(MenuName menu) // checks if product exists on menu
        {
            foreach (MenuName m in _menus)
            {
                if (m.MenuId == menu.MenuId)
                {
                    foreach (MenuType mt in m.menuTypes)
                    {
                        if (mt.SoortID == menu.menuTypes[0].SoortID)
                        {
                            foreach (Product p in mt.products)
                            {
                                if (p.ProductId == menu.menuTypes[0].products[0].ProductId)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        private void SearchProducts()
        {
            // searches product list
            if (!string.IsNullOrWhiteSpace(tb_Search.Text))
            {
                _buttons.Clear();
                foreach (Product p in _products)
                {
                    if (p.ProductId.ToString().ToLower().Contains(tb_Search.Text.ToLower()) || p.ProductNaam.ToLower().Contains(tb_Search.Text.ToLower()))
                    {
                        MakeButton(p);
                    }
                }
                AddButtons();
            }
            else
            {
                GetProducts();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void tb_Search_KeyUp(object sender, KeyEventArgs e)
        {
            // enables searching using the enter key
            if (e.KeyCode == Keys.Enter)
            {
                SearchProducts();
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

        private void cbox_Category_DropDown(object sender, EventArgs e)
        {
            List<MenuType> menuTypes = new List<MenuType>();
            cbox_Category.Items.Clear();
            foreach (MenuName menu in _menus) // find menus matching filter
            {
                if (menu.Name == _menuName)
                {
                    foreach (MenuType menuType in menu.menuTypes)
                    {
                        if (!menuTypes.Exists(m => m.Type == menuType.Type))
                        {
                            menuTypes.Add(menuType);
                        }
                    }
                }
            }
            foreach (MenuType menuType in menuTypes) // add menus to dropdown
            {
                cbox_Category.Items.Add(menuType.Type);
            }
            cbox_Category.Width = DropDownWidth(cbox_Category); // dynamically change combobox width
        }

        private int DropDownWidth(ComboBox myCombo)
        {
            // Get width of longest item in combobox
            int maxWidth = 0, temp = 0;
            foreach (var obj in myCombo.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), myCombo.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            if (maxWidth > myCombo.Width) // if longest item width is longer than current width
            {
                return maxWidth; // change width
            }
            else
            {
                return myCombo.Width; // keep width
            }
        }
    }
}