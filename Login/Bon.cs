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
    public partial class Bon : Form
    {
        private List<Order> _orderList;
        private int _tafelID;
        private string _medewerkerNaam;
        private double _fooi = 0;
        private string _betaalWijze;
        public Bon(List<Order> orderList, int tafelID, string medewerkerNaam, double fooi, string betaalWijze)
        {
            _orderList = orderList;
            _tafelID = tafelID;
            _medewerkerNaam = medewerkerNaam;
            _fooi = fooi;
            _betaalWijze = betaalWijze;

            InitializeComponent();
            ShowBon();
        }
        public void ShowBon()
        {
            lblMedewerker.Text = _medewerkerNaam;
            lblTafel.Text = _tafelID.ToString();
            lblDatum.Text = DateTime.Now.ToString("dd/MM/yyyy");

            listBonView.Columns.Add("Bestelling", 320);
            listBonView.Columns.Add("Aantal", 75);
            listBonView.Columns.Add("Prijs", 90);
            listBonView.Columns.Add("BTW %", 75);

            double subTotaalPrijs = 0;
            double totaalPrijs = 0;
            string spatie = "";
            foreach (Order order in _orderList)
            {
                ListViewItem li = new ListViewItem(order.ProductNaam);
                li.SubItems.Add(order.Aantal.ToString());
                if (order.Prijs < 10) spatie = "    ";
                else if (order.Prijs > 10 && order.Prijs < 100) spatie = "  ";
                li.SubItems.Add("€ " + spatie + order.Prijs.ToString("0.00"));
                if (order.isAlcohol)
                {
                    li.SubItems.Add("21%");
                    subTotaalPrijs += order.Prijs * 0.79;
                }
                else
                {
                    li.SubItems.Add(" 9%");
                    subTotaalPrijs += order.Prijs * 0.81;
                }
                listBonView.Items.Add(li);
                totaalPrijs += order.Prijs;
            }
            ListViewItem newLine1 = new ListViewItem("");
            listBonView.Items.Add(newLine1);

            spatie = "";
            if (subTotaalPrijs < 10) spatie = "    ";
            else if (subTotaalPrijs > 10 && subTotaalPrijs < 100) spatie = "  ";
            ListViewItem subTotaal = new ListViewItem("Subtotaal");
            subTotaal.SubItems.Add("");
            subTotaal.SubItems.Add("€ " + spatie + subTotaalPrijs.ToString("0.00"));
            listBonView.Items.Add(subTotaal);

            spatie = "";
            double btwPrijs = totaalPrijs - subTotaalPrijs;
            if (btwPrijs < 10) spatie = "    ";
            else if (btwPrijs > 10 && btwPrijs < 100) spatie = "  ";
            ListViewItem btw = new ListViewItem("BTW");
            btw.SubItems.Add("");
            btw.SubItems.Add("€ " + spatie + btwPrijs.ToString("0.00"));
            listBonView.Items.Add(btw);

            spatie = "";
            if (_fooi < 10) spatie = "    ";
            else if (_fooi > 10 && _fooi < 100) spatie = "  ";
            ListViewItem fooiItem = new ListViewItem("Fooi");
            fooiItem.SubItems.Add("");
            fooiItem.SubItems.Add("€ " + spatie + _fooi.ToString("0.00"));
            listBonView.Items.Add(fooiItem);

            ListViewItem newLine2 = new ListViewItem("");
            listBonView.Items.Add(newLine2);

            spatie = "";
            totaalPrijs += _fooi;
            if (totaalPrijs < 10) spatie = "    ";
            else if (totaalPrijs > 10 && totaalPrijs < 100) spatie = "  ";
            ListViewItem totaal = new ListViewItem("Totaal");
            totaal.SubItems.Add("");
            totaal.SubItems.Add("€ " + spatie + totaalPrijs.ToString("0.00"));
            listBonView.Items.Add(totaal);

            ListViewItem newLine3 = new ListViewItem("");
            listBonView.Items.Add(newLine3);

            ListViewItem betaaldItem = new ListViewItem("Betaald met:");
            betaaldItem.SubItems.Add("");
            betaaldItem.SubItems.Add(_betaalWijze);
            listBonView.Items.Add(betaaldItem);
        }
    }
}
