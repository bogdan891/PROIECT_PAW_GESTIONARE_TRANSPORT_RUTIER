using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW.Models
{
    public class Masina
    {
        public Guid Id { get; set; }
        public string NrInmatriculare { get; set; }
        public string Marca { get; set; }
        public int AnFabricatie { get; set; }
        public int Capacitate { get; set; }
        public string DetaliiMasina => $"{NrInmatriculare} - {Marca}";
    }
}
