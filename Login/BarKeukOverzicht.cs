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
        private List<BarKeukenBestelling> _orderList;
        private Order_Product_Service orderProductService = new Order_Product_Service();

        public BarKeukOverzicht()
        {
            InitializeComponent();

            SetListView();
            GetOrders();
            InsertListView();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SetListView();
            GetOrders();
            InsertListView();
        }

        private void SetListView()
        {
            // reset list
            orderList.Clear();

            orderList.View = View.Details;

            // place headers
            orderList.Columns.Add("Tafelnr", 120, HorizontalAlignment.Center);
            orderList.Columns.Add("Gerecht", 550);
            orderList.Columns.Add("Status", 150, HorizontalAlignment.Center);
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
                    orderList.Items.Add(li);

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

                    orderList.Items.Add(li);
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

                    orderList.Items.Add(li);
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
            ListViewItem item = orderList.SelectedItems[0];

            BarKeukenBestelling order = _orderList[item.Index];
            //orderProductService.UpdateOrderStatus(order.OrderID, order.ProductID, "Bezig");

            GetOrders();
            item.SubItems[2].Text = "Bezig";
        }

        private void btn_setOpen_Click(object sender, EventArgs e)
        {
            ListViewItem item = orderList.SelectedItems[0];
            item.SubItems[2].Text = "Nieuw";
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            ListViewItem item = orderList.SelectedItems[0];
            item.SubItems[2].Text = "Compleet";
        }
    }
}
