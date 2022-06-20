using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektniZadatak.Models
{
    public class Radnik
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Ime { get; set; }
        [StringLength(50)]
        public string Prezime { get; set; }
        [StringLength(100)]
        public string Adresa { get; set; }
        [Range(0, double.MaxValue)]
        public double NetoPlata { get; set; }
        [Range(0, double.MaxValue)]
        public double BrutoPlata { get; set; }

        public double StopaPoreza { get; set; }

        public double RPIO { get; set; }
        public double RZDR { get; set; }
        public double RNZP { get; set; }

        public double PPIO { get; set; }
        public double PZDR { get; set; }
        public double PNZP { get; set; }
    }
}
