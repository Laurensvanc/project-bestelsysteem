﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Transactie
    {
        public List<int> BestellingIDs { get; set; }
        public int TransactieID { get; set; }
        public DateTime BetaalTijd = DateTime.Now;
        public bool BonGeprint { get; set; }
        public int WerknemerID { get; set; }
        public string Opmerking { get; set; }
        public float BedragBetaald { get; set; }
        public float Fooi { get; set; }
        public string Betaalwijze { get; set; }
        public Transactie(List<int> BestellingIDs, int TransactieID, bool BonGeprint, int WerknemerID, string Opmerking, float BedragBetaald, float Fooi, string Betaalwijze)
        {
            this.BestellingIDs = BestellingIDs;
            this.TransactieID = TransactieID;
            this.BonGeprint = BonGeprint;
            this.WerknemerID = WerknemerID;
            this.Opmerking = Opmerking;
            this.BedragBetaald = BedragBetaald;
            this.Fooi = Fooi;
            this.Betaalwijze = Betaalwijze;
        }
    }
}
