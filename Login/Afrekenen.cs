using ChapooLogic;
using ChapooModel;
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
    public partial class Afrekenen : Form
    {
        private Transaction_Service _transaction_Service = new Transaction_Service();
        private double _totaalPrijs;
        private List<Order> _orderList;
        private Order_Info _orderInfo;
        private List<int> _bestellingIDs;
        private DateTime _nu = DateTime.Now;

        public Afrekenen()
        {
            InitializeComponent();
            pnl_Afrekenen.Hide();
            pnl_Opmerking.Hide();
            LoadTables();
        }
        public void LoadTables()
        {
            flp_TableSelect.Controls.Clear();
            txtOpmerking.Text = "";
            List<int> tableList = _transaction_Service.GetTables();

            foreach (int t in tableList)
            {
                Button btn = new Button();
                btn.Name = t.ToString();
                btn.Text = t.ToString();
                btn.Size = new Size(300, 75);
                btn.FlatStyle = FlatStyle.Popup;
                btn.BackColor = Color.White;
                btn.Click += btn_Click;
                flp_TableSelect.Controls.Add(btn);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            rbtnPinnen.Checked = false;
            rbtnContant.Checked = false;
            btnBetaal.Enabled = false;
            pnl_Afrekenen.Show();
            // searches for item clicked
            Button button = (Button)sender;
            lblAfrekenen.Text = $"Afrekenen tafel {button.Name}";
            LoadListView(int.Parse(button.Name));        
        }
        public void LoadListView(int id)
        {   
            listOrderView.Clear();
            listOrderViewTip.Clear();
            listOrderViewTotaal.Clear();
            _totaalPrijs = 0;
            _bestellingIDs = new List<int>();

            listOrderView.Columns.Add("BestellingID", 100);
            listOrderView.Columns.Add("Bestelling", 150);
            listOrderView.Columns.Add("Aantal", 75);
            listOrderView.Columns.Add("Prijs", 75);

            _orderInfo = _transaction_Service.GetOrderInfo(id);
            if (_orderInfo.Betaald)
            {   // Make new empty transaction to fill in with data later
                _transaction_Service.AddTransaction();
                LoadListView(id);
            } else
            {
                lblTransID.Text = "ID: " + _orderInfo.TransactieID.ToString();
                lblTijd.Text = "Tijd: " + _orderInfo.Tijd.TotalMinutes.ToString("00:00");
                lblGeholpen.Text = "Geholpen door: " + _orderInfo.Naam;
            }

            _orderList = _transaction_Service.GetOrders(id);
            foreach (Order order in _orderList)
            {
                ListViewItem li = new ListViewItem(order.BestellingID.ToString());
                li.SubItems.Add(order.ProductNaam);
                li.SubItems.Add(order.Aantal.ToString());
                li.SubItems.Add("€ " + order.Prijs.ToString("00.00"));
                listOrderView.Items.Add(li);
                _totaalPrijs += order.Prijs;

                if (!_bestellingIDs.Contains(order.BestellingID)) _bestellingIDs.Add(order.BestellingID);
            }

            listOrderViewTip.Columns.Add("Tip:", 100);
            listOrderViewTotaal.Columns.Add("Totaal prijs:", 325);
            _totaalPrijs += double.Parse(nudTip.Text);
            listOrderViewTotaal.Columns.Add("€ " + _totaalPrijs.ToString("00.00"), 75);
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            _totaalPrijs += double.Parse(nudTip.Text);
            listOrderViewTotaal.Columns[1].Text = "€ " + _totaalPrijs.ToString("00.00");
            LoadListView(int.Parse(lblAfrekenen.Text.Replace("Afrekenen tafel ", "")));
        }
        private void btnBetaal_Click(object sender, EventArgs e)
        {
            bool BonGeprint = false;
            _totaalPrijs += double.Parse(nudTip.Text);
            listOrderViewTotaal.Columns[1].Text = "€ " + _totaalPrijs.ToString("00.00");
            int tafel = int.Parse(lblAfrekenen.Text.Replace("Afrekenen tafel ", ""));
            LoadListView(tafel);

            DialogResult dialogResult = MessageBox.Show("print bon?", "Chapoo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BonGeprint = true;
            }
            string betaalWijze = "";
            if (rbtnContant.Checked) betaalWijze = "contant";
            else if (rbtnPinnen.Checked) betaalWijze = "pin";

            Transactie transactie = new Transactie(
                _bestellingIDs,
                _orderInfo.TransactieID,
                BonGeprint, 
                _orderInfo.WerknemerID,
                txtOpmerking.Text, 
                float.Parse(_totaalPrijs.ToString()), 
                float.Parse(nudTip.Text),
                betaalWijze);
            if(_transaction_Service.UpdateTransaction(transactie))
            {
                MessageBox.Show($"Rekening tafel {tafel} van €{_totaalPrijs.ToString("0.00")} is betaald.", "Chapoo");
                MessageBox.Show("Bon is uitgeprint.", "Chapoo");
            }

            pnl_Afrekenen.Hide();
            LoadTables();
        }

        private void rbtnPinnen_CheckedChanged(object sender, EventArgs e)
        {
            btnBetaal.Enabled = true;
        }
        private void rbtnContant_CheckedChanged(object sender, EventArgs e)
        {
            btnBetaal.Enabled = true;
        }
        private void btnOpmerking_Click(object sender, EventArgs e)
        {
            pnl_Opmerking.Show();
            pnl_Afrekenen.Hide();
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            pnl_Opmerking.Hide();
            pnl_Afrekenen.Show();
        }
        private void btnTerugOverzicht_Click(object sender, EventArgs e)
        {
            pnl_Afrekenen.Hide();
        }
    }
}
