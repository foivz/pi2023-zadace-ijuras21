using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Sabbatical_Manager.Models {
    public class Zahtjev {
        public int Id { get; set; }

        public string Vrsta { get; set; }
        public DateTime DatumOdlaska { get; set; }
        public DateTime DoDatuma { get; set; }
        public string Obrazloženje { get; set; }
        public string Status { get; set; }
        public string OpisZahtjeva() {
            return Vrsta + "od " + DatumOdlaska + "do " + DoDatuma;
        }
    }
}
