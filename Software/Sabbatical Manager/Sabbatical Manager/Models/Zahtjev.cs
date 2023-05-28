using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabbatical_Manager.Models {
    public class Zahtjev {
        public string Vrsta { get; set; }
        public DateTime Datum { get; set; }
        public string Obrazloženje { get; set; }
    }
}
