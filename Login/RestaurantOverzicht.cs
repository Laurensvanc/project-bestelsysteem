using ChapooLogic;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class RestaurantOverzicht : UserControl
    {
        private ChapooLogic.Reservering_Service _reservering_Service;
        private ChapooLogic.Klant_Service _klant_Service;
        private int _klantId;

        public RestaurantOverzicht()
        {
            InitializeComponent();

            geboorteDatumPicker.Format = DateTimePickerFormat.Custom;
            geboorteDatumPicker.CustomFormat = "dd-MM-yyyy";
            geboorteDatumPicker.MaxDate = DateTime.Today;
        }

        private void RestaurantOverzicht_Load(object sender, EventArgs e)
        {
            pnlReservering.Hide();
            pnlKlantSysteem.Hide();
            loadLists();
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            pnl_overzicht.Hide();
            pnlReservering.Show();
        }

        private void btnDeleteRes_Click(object sender, EventArgs e)
        {
            pnlReservering.Hide();
            pnl_overzicht.Show();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (lstReservering.SelectedItems.Count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Weet je het zeker?", "Verwijderen Reservering", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var i = lstReservering.SelectedItems[0];

                    Reservering reservering = new Reservering(
                        int.Parse(i.SubItems[0].Text));

                    _reservering_Service.DeleteReservering(reservering);
                    loadLists();
                }
            }
            else
            {
                MessageBox.Show("Geen reservering geselecteerd", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateRes_Click(object sender, EventArgs e)
        {
            DateTime begintijd = dateTijd.Value;
            int AantalPersonen = (int)NumericAantal.Value;

            if (String.IsNullOrEmpty(txtNaam.Text) || String.IsNullOrEmpty(txtAchternaam.Text) || String.IsNullOrEmpty(txtTellie.Text) || String.IsNullOrEmpty(cmbTafel.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Vul Persoonsgegevens in", "Error");
            }
            else if (txtAchternaam.Text.Length > 50 || txtNaam.Text.Length > 50 || txtTellie.Text.Length > 30)
            {
                DialogResult dialogResult = MessageBox.Show("Maximaal Aantal Character overtreden", "Error");
            }
            else
            {
                LoadKlanten();

                if (!bestaatDeKlant())
                {
                    VoegKlantToe();
                    LoadKlanten();
                    if (bestaatDeKlant())
                    {
                        Reservering reservering = new Reservering(int.Parse(cmbTafel.Text), begintijd, begintijd.AddHours(2), _klantId, AantalPersonen);
                        _reservering_Service.AddReservering(reservering);
                        MessageBox.Show("Reservering voor " + txtNaam.Text + " Gezet, op: " + dateTijd.Value.ToShortDateString(), "Success");
                    }
                    else
                    {
                        MessageBox.Show("Geen Persoon gevonden", "Error");
                    }
                }
                else
                {
                    Reservering reservering = new Reservering(int.Parse(cmbTafel.Text), begintijd, begintijd.AddHours(2), _klantId, AantalPersonen);
                    _reservering_Service.AddReservering(reservering);
                    MessageBox.Show("Reservering voor " + txtNaam.Text + " Gezet, op: " + dateTijd.Value.ToShortDateString(), "Success");
                }

                pnlReservering.Hide();
                Refresh();
                txtNaam.Clear();
                txtAchternaam.Clear();
                txtTellie.Clear();
            }
        }

        private void Refresh()
        {
            loadLists();
        }

        private void loadLists()
        {
            // Tafels bezet
            Transaction_Service transaction_Service = new Transaction_Service();
            List<int> tableList = transaction_Service.GetTables();
            // Reservering
            _reservering_Service = new Reservering_Service();
            List<Reservering> reserverings = _reservering_Service.GetReserverings();

            List<int> tafelToBezet = new List<int>();
            List<int> tafelToGereserveerd = new List<int>();

            lstReservering.Clear();
            lstReserveringDag.Clear();

            lstReservering.Columns.Add("Reservering Nummer");
            lstReservering.Columns.Add("Tafel Nummer");
            lstReservering.Columns.Add("Begin Tijd");
            lstReservering.Columns.Add("Eind Tijd");
            lstReservering.Columns.Add("Klant Naam");
            lstReservering.Columns.Add("Aantal");

            lstReservering.FullRowSelect = true;
            lstReservering.GridLines = true;

            lstReserveringDag.Columns.Add("Reservering Nummer");
            lstReserveringDag.Columns.Add("Tafel Nummer");
            lstReserveringDag.Columns.Add("Begin Tijd");
            lstReserveringDag.Columns.Add("Eind Tijd");
            lstReserveringDag.Columns.Add("Klant Naam");
            lstReserveringDag.Columns.Add("Aantal");

            lstReserveringDag.FullRowSelect = true;
            lstReserveringDag.GridLines = true;

            foreach (Reservering r in reserverings)
            {
                if (r.EindTijd.AddHours(1)  > DateTime.Today) // show only reservations with end time lower than time now (1 hour leeway)
                {
                    ListViewItem li = new ListViewItem(r.ReserveringID.ToString());
                    li.SubItems.Add(r.TafelID.ToString());
                    li.SubItems.Add(r.BeginTijd.ToString());
                    li.SubItems.Add(r.EindTijd.ToString());
                    li.SubItems.Add(r.KlantNaam.ToString());
                    li.SubItems.Add(r.AantalPersonen.ToString());
                    lstReservering.Items.Add(li);
                }
                // Update Tafelstatus
                DateTime nu = dateTijd.Value;
                dateTijd.MinDate = DateTime.Today;
                if (r.BeginTijd < nu && r.EindTijd > nu || tableList.Contains(r.TafelID))
                {
                    tafelToBezet.Add(r.TafelID);
                }
                else if (r.BeginTijd < nu.AddHours(2) && r.EindTijd > nu)
                {
                    tafelToGereserveerd.Add(r.TafelID);
                }
            }
            foreach (ColumnHeader ch in lstReservering.Columns)
            {
                ch.Width = -2;
            }
            // Tafel & status
            ChapooLogic.Tafel_Service tafel_Service = new Tafel_Service();
            List<Tafel> tafels = tafel_Service.GetTafels();
            cmbTafel.Items.Clear();
            lstTafelStatus.Clear();

            lstTafelStatus.Columns.Add("Tafel#", 75);
            lstTafelStatus.Columns.Add("Capaciteit", 75);
            lstTafelStatus.Columns.Add("Werknemer", 100);
            lstTafelStatus.Columns.Add("Status", 75);

            lstTafelStatus.FullRowSelect = true;
            lstTafelStatus.GridLines = true;

            foreach (Tafel t in tafels)
            {
                if (tafelToBezet.Contains(t.TafelNummer)) t.Status = "Bezet";
                if (tafelToGereserveerd.Contains(t.TafelNummer)) t.Status = "Gereserveerd";
                ListViewItem li = new ListViewItem(t.TafelNummer.ToString());
                li.SubItems.Add(t.Capaciteit.ToString());
                li.SubItems.Add(t.WerknemerId.ToString());
                li.SubItems.Add(t.Status);
                if (t.Status == "Bezet")
                {
                    li.SubItems[3].BackColor = Color.Red;
                }
                else if (t.Status == "Gereserveerd")
                {
                    li.SubItems[3].BackColor = Color.Orange;
                }
                else
                {
                    li.SubItems[3].BackColor = Color.Green;
                }

                li.UseItemStyleForSubItems = false;
                cmbTafel.Items.Add(t.TafelNummer);
                lstTafelStatus.Items.Add(li);
            }
            foreach (ColumnHeader ch in lstTafelStatus.Columns)
            {
                ch.Width = -2;
            }

            dateTijd.Format = DateTimePickerFormat.Custom;
            dateTijd.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            DateTime time = dateTijd.Value;

            foreach (Reservering r in reserverings)
            {
                if (r.BeginTijd.Date == time.Date)
                {
                    ListViewItem li = new ListViewItem(r.ReserveringID.ToString());
                    li.SubItems.Add(r.TafelID.ToString());
                    li.SubItems.Add(r.BeginTijd.Hour.ToString() + ":" + r.BeginTijd.Minute.ToString("D2"));
                    li.SubItems.Add(r.EindTijd.Hour.ToString() + ":" + r.EindTijd.Minute.ToString("D2"));
                    li.SubItems.Add(r.KlantNaam.ToString());
                    li.SubItems.Add(r.AantalPersonen.ToString());

                    lstReserveringDag.Items.Add(li);
                }
            }
            foreach (ColumnHeader ch in lstReserveringDag.Columns)
            {
                ch.Width = -2;
            }
        }

        private void dateTijd_ValueChanged(object sender, EventArgs e)
        {
            loadLists();
            lblDatum.Text = "Reserveringen voor: " + dateTijd.Value.Date.ToShortDateString();
        }

        private void btnSelectKlant_Click(object sender, EventArgs e)
        {
            LoadKlanten();
            pnlReservering.Hide();
            pnlKlantSysteem.Show();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            pnlKlantSysteem.Hide();
            pnlReservering.Show();
        }

        private void LoadKlanten()
        {
            _klant_Service = new Klant_Service();
            List<Klant> klanten = _klant_Service.GetKlants();

            lstKlantSysteem.Clear();

            lstKlantSysteem.Columns.Add("KlantNummer", 75);
            lstKlantSysteem.Columns.Add("Voornaam", 75);
            lstKlantSysteem.Columns.Add("Achternaam", 100);
            lstKlantSysteem.Columns.Add("GeboorteDatum", 75);
            lstKlantSysteem.Columns.Add("Mobiel", 75);

            lstKlantSysteem.FullRowSelect = true;
            lstKlantSysteem.GridLines = true;

            foreach (Klant k in klanten)
            {
                if (!String.IsNullOrEmpty(txtNaamKlant.Text))
                {
                    if (k.Voornaam.Contains(txtNaamKlant.Text) || k.Achternaam.Contains(txtNaamKlant.Text))
                    {
                        ListViewItem li = new ListViewItem(k.KlantID.ToString());
                        li.SubItems.Add(k.Voornaam.ToString());
                        li.SubItems.Add(k.Achternaam.ToString());
                        li.SubItems.Add(k.GeboorteDatum.ToString());
                        li.SubItems.Add(k.Mobiel.ToString());

                        lstKlantSysteem.Items.Add(li);
                    }
                }
                else
                {
                    ListViewItem li = new ListViewItem(k.KlantID.ToString());
                    li.SubItems.Add(k.Voornaam.ToString());
                    li.SubItems.Add(k.Achternaam.ToString());
                    li.SubItems.Add(k.GeboorteDatum.ToString());
                    li.SubItems.Add(k.Mobiel.ToString());

                    lstKlantSysteem.Items.Add(li);
                }
            }
        }

        private void lstKlantSysteem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstKlantSysteem.SelectedItems.Count == 0)
                return;

            var i = lstKlantSysteem.SelectedItems[0];
            lblKlantGeselct.Text = "U Heeft: " + i.SubItems[1].Text + " " + i.SubItems[2].Text + " Geselecteerd";
        }

        private void txtNaamKlant_TextChanged(object sender, EventArgs e)
        {
            LoadKlanten();
            lblZoeken.Text = "Zoeken op: " + txtNaamKlant.Text;
        }

        private void btnKlantOpslaan_Click(object sender, EventArgs e)
        {
            string date = geboorteDatumPicker.Value.ToString();
            if (lstKlantSysteem.SelectedItems.Count == 0)
                return;
            var i = lstKlantSysteem.SelectedItems[0];
            txtNaam.Text = i.SubItems[1].Text;
            txtAchternaam.Text = i.SubItems[2].Text;
            date = i.SubItems[3].Text;
            txtTellie.Text = i.SubItems[4].Text;
            _klantId = int.Parse(i.SubItems[0].Text);

            pnlKlantSysteem.Hide();
            pnlReservering.Show();
        }

        private void VoegKlantToe()
        {
            string date = geboorteDatumPicker.Value.ToString();
            Klant klant = new Klant(txtNaam.Text, txtAchternaam.Text, date, txtTellie.Text);
            _klant_Service.AddKlant(klant);
        }

        private bool bestaatDeKlant()
        {
            bool bestaat = false;
            for (int i = 0; i < lstKlantSysteem.Items.Count; i++)
            {
                if (lstKlantSysteem.Items[i].SubItems[1].Text.Contains(txtNaam.Text) && lstKlantSysteem.Items[i].SubItems[2].Text.Contains(txtAchternaam.Text))
                {
                    _klantId = int.Parse(lstKlantSysteem.Items[i].SubItems[0].Text);
                    bestaat = true;
                }
            }
            return bestaat;
        }
    }
}