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
    public partial class RestaurantOverzicht : Form
    {
        public RestaurantOverzicht()
        {
            InitializeComponent();
        }

        private void lstTafelStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RestaurantOverzicht_Load(object sender, EventArgs e)
        {
            ChapooLogic.Tafel_Service tafel_Service = new ChapooLogic.Tafel_Service();
            List<Tafel> tafels = tafel_Service.GetTafels();

            lstTafelStatus.Clear();

            lstTafelStatus.Columns.Add("TafelNummer", 75);
            lstTafelStatus.Columns.Add("Capaciteit", 75);
            lstTafelStatus.Columns.Add("Werknemer", 75);
            lstTafelStatus.Columns.Add("Status", 150);

            foreach(ChapooModel.Tafel t in tafels)
            {
                ListViewItem li = new ListViewItem(t.TafelNummer.ToString());
                li.SubItems.Add(t.Capaciteit.ToString());
                li.SubItems.Add(t.WerknemerId.ToString());
                li.SubItems.Add(t.Status);
                lstTafelStatus.Items.Add(li);
            }
        }
    }
}
