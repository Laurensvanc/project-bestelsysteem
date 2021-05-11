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
    public partial class OmzetOverzicht : Form
    {
        private List<ChapooModel.Product> _productList;
        private List<ChapooModel.Reservering> _reserveringList;

        public OmzetOverzicht()
        {
            InitializeComponent();
            OnLoad();
        }

        private void OnLoad()
        {
            LoadExpense();
            LoadIncome();
            LoadRevenue();
        }

        private void LoadExpense()
        {
            bool productsLoaded = false;
            // clear list
            lst_expense.Clear();

            // load in products
            if (productsLoaded == false)
                ProductCatchErr();

            // add products to global list
        }

        private void LoadIncome()
        {
            bool reserveringLoaded = false;
            lst_income.Clear();

            // load in orders
            if (reserveringLoaded == false)
                ReserveringCatchErr();

            // add orders to global list
        }

        private void LoadRevenue()
        {
            lst_revenue.Clear();

            CalculateRevenue();
        }

        private void CalculateRevenue()
        {
            // with both global lists calculate the revenue
            // split revenue by DateTime for week base
        }

        private void ProductCatchErr()
        {
            txb_totalExpense.Text = "Geen uitgave beschikbaar...";
        }

        private void ReserveringCatchErr()
        {
            txb_totalIncome.Text = "Geen incomen beschikbaar...";
        }
    }
}
