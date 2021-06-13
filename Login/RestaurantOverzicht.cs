using ChapooLogic;
using ChapooModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class RestaurantOverzicht : UserControl
    {
        private ChapooLogic.Reservering_Service _reservering_Service;
        private ChapooLogic.Klant_Service _klant_Service;
        private ChapooLogic.Tafel_Service tafel_Service;
        private ListViewColumnSorter lvwColumnSorter; // column sort functionality
        private List<int> tafelToBezet;
        private List<Tafel> tafels;
        private List<int> tafelToGereserveerd;
        private List<int> tableList;
        private List<Klant> klanten;
        private Klant klant;
        private int _klantId;

        public RestaurantOverzicht()
        {
            InitializeComponent();
            DatetimepickerSettings();
            lvwColumnSorter = new ListViewColumnSorter();
            this.lstReservering.ListViewItemSorter = lvwColumnSorter;
            this.lstTafelStatus.ListViewItemSorter = lvwColumnSorter;
            this.lstReserveringDag.ListViewItemSorter = lvwColumnSorter;
            this.lstKlantSysteem.ListViewItemSorter = lvwColumnSorter;
        }

        private void RestaurantOverzicht_Load(object sender, EventArgs e)
        {
            pnlReservering.Hide();
            pnlKlantSysteem.Hide();
            loadLists();
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            LoadKlanten();
            UpdateResSettings();
            loadLists();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            pnl_overzicht.Hide();
            pnlReservering.Show();
        }

        private void btnDeleteRes_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNaam.Text) || !String.IsNullOrEmpty(txtAchternaam.Text) || !String.IsNullOrEmpty(txtTellie.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Weet je het zeker?", "Verwijder ingevulde gegevens", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    txtAchternaam.Clear();
                    txtNaam.Clear();
                    txtTellie.Clear();

                    pnlReservering.Hide();
                    pnl_overzicht.Show();
                }
            }
            else
            {
                pnlReservering.Hide();
                pnl_overzicht.Show();
            }
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
            if (NoReservationPossible(cmbTafel.Text))
            {
                MessageBox.Show($"Voor tafel {cmbTafel.Text} is al een reservering geplaatst op dit tijdstip", "Error: Geen dubbele reservering mogelijk");
            }
            else
            {
                if (String.IsNullOrEmpty(txtNaam.Text) || String.IsNullOrEmpty(txtAchternaam.Text) || String.IsNullOrEmpty(txtTellie.Text) || String.IsNullOrEmpty(cmbTafel.Text))
                {
                    MessageBox.Show("Vul Persoonsgegevens in", "Error");
                }
                else if (txtAchternaam.Text.Length > 50 || txtNaam.Text.Length > 50 || txtTellie.Text.Length > 15)
                {
                    MessageBox.Show("Maximaal Aantal Character overtreden", "Error");
                }
                else
                {
                    LoadKlanten();
                    KlantBestaat();

                    UpdateResSettings();
                }
            }
        }

        //loads everything related to reservering/tafel
        private void loadLists()
        {
            // Tafels bezet
            Transaction_Service transaction_Service = new Transaction_Service();
            tableList = transaction_Service.GetTables();
            // Reservering
            _reservering_Service = new Reservering_Service();
            List<Reservering> reserverings = _reservering_Service.GetReserverings();
            tafelToBezet = new List<int>();
            tafelToGereserveerd = new List<int>();
            lstReservering.Clear();
            lstReserveringDag.Clear();
            //Load List Settings
            reserveringColummSettings();
            //Fill Status List
            reserveringStatusList(reserverings);
            // Tafel & status
            tafel_Service = new Tafel_Service();
            tafels = tafel_Service.GetTafels();
            cmbTafel.Items.Clear();
            lstTafelStatus.Clear();
            tafelColummSettings();
            //Fill Tafel/Reservering Lists
            TafelsList(tafels);
            ReserveringList(reserverings);
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
            klanten = _klant_Service.GetKlants();

            lstKlantSysteem.Clear();

            //load klant collum Settings
            klantColummSettings();

            //load klanten list
            KlantList();
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
            if (lstKlantSysteem.SelectedItems.Count == 0)
                return;
            var i = lstKlantSysteem.SelectedItems[0];
            txtNaam.Text = i.SubItems[1].Text;
            txtAchternaam.Text = i.SubItems[2].Text;
            DateTime date = DateTime.Parse(i.SubItems[3].Text);
            geboorteDatumPicker.Value = date;
            txtTellie.Text = i.SubItems[4].Text;
            _klantId = int.Parse(i.SubItems[0].Text);

            pnlKlantSysteem.Hide();
            pnlReservering.Show();
        }

        private void VoegKlantToe()
        {
            string date = geboorteDatumPicker.Value.ToString("dd-MM-yyyy");
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

        private void txtTellie_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTellie.Text, "[^0-9]"))
            {
                MessageBox.Show("Gebruik alleen nummers!");
                txtTellie.Text = txtTellie.Text.Remove(txtTellie.Text.Length - 1);
            }
        }

        private void ReserveringList(List<Reservering> reserverings)
        {
            DateTime time = dateTijd.Value;

            foreach (Reservering r in reserverings)
            {
                if (r.BeginTijd.Date == time.Date)
                {
                    ListViewItem li = new ListViewItem(r.ReserveringID.ToString());
                    li.SubItems.Add(r.Tafel.TafelNummer.ToString());
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

        private void TafelsList(List<Tafel> tafels)
        {
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
        }

        private void reserveringStatusList(List<Reservering> reserverings)
        {
            foreach (Reservering r in reserverings)
            {
                if ((r.BeginTijd.Date == DateTime.Today.Date) && (r.EindTijd.AddHours(1) > DateTime.Now)) // show only reservations with end time lower than time now (1 hour leeway)
                {
                    ListViewItem li = new ListViewItem(r.ReserveringID.ToString());
                    li.SubItems.Add(r.Tafel.TafelNummer.ToString());
                    li.SubItems.Add(r.BeginTijd.ToString());
                    li.SubItems.Add(r.EindTijd.ToString());
                    li.SubItems.Add(r.KlantNaam.ToString());
                    li.SubItems.Add(r.AantalPersonen.ToString());
                    lstReservering.Items.Add(li);
                }
                // Update Tafelstatus
                DateTime nu = dateTijd.Value;
                dateTijd.MinDate = DateTime.Today;
                if (r.BeginTijd < nu && r.EindTijd > nu || tableList.Contains(r.Tafel.TafelNummer))
                {
                    tafelToBezet.Add(r.Tafel.TafelNummer);
                }
                else if (r.BeginTijd < nu.AddHours(2) && r.EindTijd > nu)
                {
                    tafelToGereserveerd.Add(r.Tafel.TafelNummer);
                }
            }
            foreach (ColumnHeader ch in lstReservering.Columns)
            {
                ch.Width = -2;
            }
        }

        private void reserveringColummSettings()
        {
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
        }

        private void tafelColummSettings()
        {
            lstTafelStatus.Columns.Add("Tafel#", 75);
            lstTafelStatus.Columns.Add("Capaciteit", 75);
            lstTafelStatus.Columns.Add("Werknemer", 100);
            lstTafelStatus.Columns.Add("Status", 75);

            lstTafelStatus.FullRowSelect = true;
            lstTafelStatus.GridLines = true;
        }

        private void klantColummSettings()
        {
            lstKlantSysteem.Columns.Add("KlantNummer", 100);
            lstKlantSysteem.Columns.Add("Voornaam", 150);
            lstKlantSysteem.Columns.Add("Achternaam", 150);
            lstKlantSysteem.Columns.Add("GeboorteDatum", 100);
            lstKlantSysteem.Columns.Add("Mobiel", 120);

            lstKlantSysteem.FullRowSelect = true;
            lstKlantSysteem.GridLines = true;
        }

        private void KlantBestaat()
        {
            DateTime begintijd = dateTijd.Value;
            int AantalPersonen = (int)NumericAantal.Value;
            Tafel tafel = new Tafel(int.Parse(cmbTafel.Text));
            klant = new Klant(_klantId);
            if (!bestaatDeKlant())
            {
                VoegKlantToe();
                LoadKlanten();

                if (bestaatDeKlant())
                {
                    klant.KlantID = _klantId;
                    Reservering reservering = new Reservering(tafel, begintijd, begintijd.AddHours(2), klant, AantalPersonen);
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
                klant.KlantID = _klantId;
                Reservering reservering = new Reservering(tafel, begintijd, begintijd.AddHours(2), klant, AantalPersonen);
                _reservering_Service.AddReservering(reservering);
                MessageBox.Show("Reservering voor " + txtNaam.Text + " Gezet, op: " + dateTijd.Value.ToShortDateString(), "Success");
            }
        }

        private void KlantList()
        {
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

        private void UpdateResSettings()
        {
            pnlReservering.Hide();
            pnl_overzicht.Show();
            loadLists();
            txtNaam.Clear();
            txtAchternaam.Clear();
            txtTellie.Clear();
        }

        private bool NoReservationPossible(string tafelID)
        {
            bool Bezet = false;

            foreach (ListViewItem row in lstReservering.Items)
            {
                if (tafelID == row.SubItems[1].Text)
                {
                    DateTime start = DateTime.Parse(row.SubItems[2].Text);
                    DateTime end = DateTime.Parse(row.SubItems[3].Text);
                    DateTime now = dateTijd.Value;
                    if ((now > start) && (now < end))
                    {
                        foreach (ListViewItem row2 in lstTafelStatus.Items)
                        {
                            if (tafelID == row2.SubItems[0].Text)
                            {
                                if (row2.SubItems[3].Text == "Bezet")
                                {
                                    Bezet = true;
                                }
                            }
                        }
                    }
                }
            }
            if (Bezet)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DatetimepickerSettings()
        {
            geboorteDatumPicker.Format = DateTimePickerFormat.Custom;
            geboorteDatumPicker.CustomFormat = "dd-MM-yyyy";
            geboorteDatumPicker.MaxDate = DateTime.Today;

            dateTijd.Format = DateTimePickerFormat.Custom;
            dateTijd.CustomFormat = "MM/dd/yyyy HH:mm:ss";
        }

        private void ColumnSort(ColumnClickEventArgs e, ListView lv)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            lv.Sort();
        }
        private void lstReservering_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnSort(e, (ListView)sender);
        }

        private void lstTafelStatus_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnSort(e, (ListView)sender);
        }

        private void lstReserveringDag_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnSort(e, (ListView)sender);
        }

        private void lstKlantSysteem_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnSort(e, (ListView)sender);
        }
    }
}