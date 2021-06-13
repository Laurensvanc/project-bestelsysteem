using ChapooLogic;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class BarKeukOverzicht : UserControl
    {
        private List<Order_Product> _orderList = new List<Order_Product>();
        private List<Order_Product> _drinkList = new List<Order_Product>();
        private List<Order_Product> _foodList = new List<Order_Product>();

        private bool _filter;

        private Order_Product_Service _orderProductService = new Order_Product_Service();
        private int _orderDisplay;

        public BarKeukOverzicht()
        {
            _orderDisplay = 2;
            _filter = true;
            InitializeComponent();
            UpdateList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void SetListView()
        {
            // reset list
            lv_orderList.Clear();

            lv_orderList.View = View.Details;

            // place headers
            lv_orderList.Columns.Add("Tafelnr", 100, HorizontalAlignment.Center);
            lv_orderList.Columns.Add("Gerecht", 650);
            lv_orderList.Columns.Add("Status", 115, HorizontalAlignment.Center);
            lv_orderList.Columns.Add("Aantal", 85, HorizontalAlignment.Right);
            lv_orderList.Columns.Add("Minuten", 125, HorizontalAlignment.Right);
        }

        Color StatusColor(string status)
        {
            Color color;

            switch (status)
            {
                default:
                    color = Color.Black;
                    break;

                case "Nieuw":
                    color = Color.FromArgb(252, 181, 40);
                    break;
                case "Bezig":
                    color = Color.FromArgb(245, 90, 90);
                    break;
                case "Afgerond":
                    color = Color.FromArgb(104, 237, 99);
                    break;
            }

            return color;
        }

        private void InsertListView()
        {
            foreach (Order_Product order in _orderList)
            {
                if (order.Bestelling.Opgenomen.Date != DateTime.Today && _filter)
                    continue;

                TimeSpan time = order.Bestelling.Opgenomen - DateTime.Now;
                int minutes = Convert.ToInt32(time.TotalMinutes * -1);

                ListViewItem li = new ListViewItem("#" + order.Bestelling.Tafel.TafelNummer.ToString());
                li.SubItems.Add(order.Product.ProductNaam);
                li.SubItems.Add(order.Status.ToString());
                li.SubItems.Add(order.Aantal.ToString());
                li.SubItems.Add(minutes.ToString());

                lv_orderList.Items.Add(li);
            }

            // update status color
            UpdateListStatusColor();
        }

        private void InsertBarListView()
        {
            foreach (Order_Product order in _drinkList)
            {
                if (order.Bestelling.Opgenomen.Date != DateTime.Today && _filter)
                    continue;

                TimeSpan time = order.Bestelling.Opgenomen - DateTime.Now;
                int minutes = Convert.ToInt32(time.TotalMinutes * -1);

                ListViewItem li = new ListViewItem("#" + order.Bestelling.Tafel.TafelNummer.ToString());
                li.SubItems.Add(order.Product.ProductNaam);
                li.SubItems.Add(order.Status.ToString());
                li.SubItems.Add(order.Aantal.ToString());
                li.SubItems.Add(minutes.ToString());

                lv_orderList.Items.Add(li);
            }

            // update status color
            UpdateListStatusColor();
        }

        private void InsertKitchenListView()
        {
            foreach (Order_Product order in _foodList)
            {
                if (order.Bestelling.Opgenomen.Date != DateTime.Today && _filter)
                    continue;

                TimeSpan time = order.Bestelling.Opgenomen - DateTime.Now;
                int minutes = Convert.ToInt32(time.TotalMinutes * -1);

                ListViewItem li = new ListViewItem("#" + order.Bestelling.Tafel.TafelNummer.ToString());

                li.SubItems.Add(order.Product.ProductNaam);
                li.SubItems.Add(order.Status);
                li.SubItems.Add(order.Aantal.ToString());
                li.SubItems.Add(minutes.ToString());

                lv_orderList.Items.Add(li);
            }

            // update status color
            UpdateListStatusColor();
        }

        void UpdateListStatusColor()
        {
            foreach (ListViewItem item in lv_orderList.Items)
            {
                item.UseItemStyleForSubItems = false;
                item.SubItems[2].ForeColor = StatusColor(item.SubItems[2].Text);
            }
        }

        private void GetOrders()
        {
            _orderList.Clear();
            _foodList.Clear();
            _drinkList.Clear();

            _orderList = _orderProductService.GetAllOrderProducts();

            foreach (Order_Product order in _orderList)
            {
                if (order.Product.IsDrinken)
                    continue;

                _foodList.Add(order);
            }

            foreach (Order_Product order in _orderList)
            {
                if (!order.Product.IsDrinken)
                    continue;

                _drinkList.Add(order);
            }

            if (_orderList.Count == 0)
            {
                MessageBox.Show("Geen bestellingen gevonden");
                return;
            }
        }

        private void btn_workingOn_Click(object sender, EventArgs e)
        {
            if (lv_orderList.SelectedItems.Count <= 0)
                return;

            Order_Product order = GetListOrder();

            if (CheckForStatusDuplicate(order, "Bezig"))
                return;

            order.Status = "Bezig";

            bool succes = _orderProductService.UpdateOrderStatus(order);

            if (!succes)
            {
                MessageBox.Show("Kon geen order updaten");
            }

            UpdateList();
        }

        private void btn_setOpen_Click(object sender, EventArgs e)
        {
            if (lv_orderList.SelectedItems.Count <= 0)
                return;

            Order_Product order = GetListOrder();

            if (CheckForStatusDuplicate(order, "Nieuw"))
                return;

            order.Status = "Nieuw";

            bool succes = _orderProductService.UpdateOrderStatus(order);

            if (!succes)
            {
                MessageBox.Show("Kon geen order updaten");
            }

            UpdateList();
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            if (lv_orderList.SelectedItems.Count <= 0)
                return;

            Order_Product order = GetListOrder();

            if (CheckForStatusDuplicate(order, "Afgerond"))
                return;

            order.Status = "Afgerond";

            bool success = _orderProductService.UpdateOrderStatus(order);

            if (!success)
            {
                MessageBox.Show("Kon geen order updaten");
            }

            UpdateList();
        }

        private void UpdateList()
        {
            SetListView();
            GetOrders();

            switch (_orderDisplay) 
            {
                case 0:
                    InsertKitchenListView();
                    break;
                case 1:
                    InsertBarListView();
                    break;
                case 2:
                    InsertListView();
                    break;
            }
        }

        private Order_Product GetListOrder()
        {
            ListViewItem item = new ListViewItem();
            Order_Product order;

            int intSelectedIndex = lv_orderList.SelectedIndices[0];
            item = lv_orderList.Items[intSelectedIndex];

            switch (_orderDisplay)
            {
                default:
                    order = _orderList[item.Index];
                    break;
                case 0:
                    order = _foodList[item.Index];
                    break;
                case 1:
                    order = _drinkList[item.Index];
                    break;
                case 2:
                    order = _orderList[item.Index];
                    break;
            }

            return order;
        }

        private void btn_generalOrder_Click(object sender, EventArgs e)
        {
            _orderDisplay = 2;
            UpdateList();
        }

        private void btn_kitchenOrder_Click(object sender, EventArgs e)
        {
            _orderDisplay = 0;
            UpdateList();
        }

        private void btn_barOrder_Click(object sender, EventArgs e)
        {
            _orderDisplay = 1;
            UpdateList();
        }

        bool CheckForStatusDuplicate(Order_Product product, string status)
        {
            if (product.Status == status) 
            {
                MessageBox.Show($"{status} is de huidige status");
                return true;
            }

            return false;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            _filter = !_filter;
            UpdateList();

            if (_filter) 
            {
                btn_filter.Text = "vandaag"; 
                return;
            }

            btn_filter.Text = "geen";
        }
    }
}