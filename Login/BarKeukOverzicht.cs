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
        private Order_Product_Service orderProductService;

        public BarKeukOverzicht()
        {
            InitializeComponent();

            GetOrders();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void GetOrders()
        {
            //_orderList = orderProductService.GetAllBarKeukenBestellingen();
            txb_header.Text = "Bestelling";
        }
    }
}
