using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;
using ChapooLogic;


namespace Login
{
    public partial class BarKeukOverzicht : UserControl
    {
        private List<BarKeukenBestelling> _orderList = new List<BarKeukenBestelling>();
        private Order_Product_Service orderProductService = new Order_Product_Service();

        public BarKeukOverzicht()
        {
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
            lv_orderList.Columns.Add("Gerecht", 425);
            lv_orderList.Columns.Add("Status", 150, HorizontalAlignment.Center);
            lv_orderList.Columns.Add("Opgenomen", 275, HorizontalAlignment.Left);
        }

        private void InsertListView()
        {
            foreach (BarKeukenBestelling item in _orderList)
            {
                for (int i = 0; i < item.Aantal; i++)
                {
                    ListViewItem li = new ListViewItem("#" + item.TafelID.ToString());
                    li.SubItems.Add(item.ProductNaam);
                    switch (item.Status)
                    {
                        default:
                            li.SubItems.Add(item.Status.ToString());
                            break;
                        case "Nieuw":
                            li.SubItems.Add(item.Status.ToString()).ForeColor = Color.Orange;
                            break;
                        case "Bezig":
                            li.SubItems.Add(item.Status.ToString()).ForeColor = Color.Red;
                            break;
                        case "Compleet":
                            li.SubItems.Add(item.Status.ToString()).ForeColor = Color.Green;
                            break;
                    }
                    li.SubItems.Add(item.Opgenomen.ToString());
                    lv_orderList.Items.Add(li);

                }
            }
        }

        private void InsertBarListView()
        {
            foreach (BarKeukenBestelling item in _orderList)
            {
                for (int i = 0; i < item.Aantal; i++)
                {
                    if (!item.IsDrinken)
                        continue;

                    ListViewItem li = new ListViewItem("#" + item.TafelID.ToString());
                    li.SubItems.Add(item.ProductNaam);
                    li.SubItems.Add(item.Status.ToString());

                    lv_orderList.Items.Add(li);
                }
            }
        }

        private void InsertKeukenListView()
        {
            foreach (BarKeukenBestelling item in _orderList)
            {
                for (int i = 0; i < item.Aantal; i++)
                {
                    if (item.IsDrinken)
                        continue;

                    ListViewItem li = new ListViewItem("#" + item.TafelID.ToString());
                    li.SubItems.Add(item.ProductNaam);
                    li.SubItems.Add(item.Status.ToString());

                    lv_orderList.Items.Add(li);
                }
            }
        }

        private void GetOrders()
        {
            _orderList = orderProductService.GetAllBarKeukenBestellingen();

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

            ListViewItem item = lv_orderList.SelectedItems[0];

            BarKeukenBestelling order = _orderList[item.Index];

            if (order.Status == "Bezig") 
            {
                MessageBox.Show("Dit is de huidige status");
                return;
            }

            bool succes = orderProductService.UpdateOrderStatus(order.OrderID, order.ProductID, "Bezig", order.Aantal);

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

            ListViewItem item = lv_orderList.SelectedItems[0];

            BarKeukenBestelling order = _orderList[item.Index];

            if (order.Status == "Nieuw")
            {
                MessageBox.Show("Dit is de huidige status");
                return;
            }

            bool succes = orderProductService.UpdateOrderStatus(order.OrderID, order.ProductID, "Nieuw", order.Aantal);

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

            ListViewItem item = lv_orderList.SelectedItems[0];

            BarKeukenBestelling order = _orderList[item.Index];

            if (order.Status == "Compleet")
            {
                MessageBox.Show("Dit is de huidige status");
                return;
            }

            bool success = orderProductService.UpdateOrderStatus(order.OrderID, order.ProductID, "Compleet", order.Aantal);

            if (!success)
            {
                MessageBox.Show("Kon geen order updaten");
            }

            UpdateList();
        }

        void UpdateList()
        {
            SetListView();
            GetOrders();
            InsertListView();
        }
    }
}
