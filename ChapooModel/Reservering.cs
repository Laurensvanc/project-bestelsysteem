using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooModel
{
    public class Reservering
    {
        public int ReserveringID { get; set; }
        public int TafelID { get; set; }
        public DateTime BeginTijd { get; set; }
        public DateTime EindTijd { get; set; }
        public int KlantID { get; set; }

    }
}
