using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW.Models
{
    public class Ruta
    {
        public Guid Id { get; set; }
        public string CodTraseu {  get; set; }
        public string Plecare { get; set; }
        public string Destinatie { get; set; }
        public double Distanta { get; set; }
        public Guid IdMasina { get; set; }
        public Guid IdSofer { get; set; }
    }
}
