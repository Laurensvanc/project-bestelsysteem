﻿using ChapooModel;
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

            lstTafelStatus.FullRowSelect = true;
            lstTafelStatus.GridLines = true;

            foreach (ChapooModel.Tafel t in tafels)
            {
                ListViewItem li = new ListViewItem(t.TafelNummer.ToString());
                li.SubItems.Add(t.Capaciteit.ToString());
                li.SubItems.Add(t.WerknemerId.ToString());
                li.SubItems.Add(t.Status);
                lstTafelStatus.Items.Add(li);
            }

            ChapooLogic.Reservering_Service reservering_Service = new ChapooLogic.Reservering_Service();
            List<Reservering> reserverings = reservering_Service.GetReserverings();

            lstReservering.Clear();

            lstReservering.Columns.Add("Reservering Nummer", 75);
            lstReservering.Columns.Add("Tafel Nummer", 75);
            lstReservering.Columns.Add("Begin Tijd", 75);
            lstReservering.Columns.Add("Eind Tijd", 75);
            lstReservering.Columns.Add("Klant Naam", 75);

            lstReservering.FullRowSelect = true;
            lstReservering.GridLines = true;

            foreach (ChapooModel.Reservering r in reserverings) {
               ListViewItem li = new ListViewItem(r.ReserveringID.ToString());
                li.SubItems.Add(r.TafelID.ToString());
                li.SubItems.Add(r.BeginTijd.ToString());
                li.SubItems.Add(r.EindTijd.ToString());
                li.SubItems.Add(r.KlantID.ToString());

                lstReservering.Items.Add(li);
            }
        }
    }
}
