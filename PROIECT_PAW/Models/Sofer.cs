using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW.Models
{
    public class Sofer
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public double Salariul { get; set; }
        public DateTime DataAngajarii { get; set; }
        public string NumeComplet => $"{Nume} {Prenume}";
    }
}
