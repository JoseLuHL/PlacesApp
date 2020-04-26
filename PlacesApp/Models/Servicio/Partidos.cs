using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class Partidos
    {
        public int Id { get; set; }
        public string Equipoa { get; set; }
        public string Resultadoa { get; set; }
        public string Equipob { get; set; }
        public string Resultadob { get; set; }
        public string Foto1 { get; set; }
        public string Foto2 { get; set; }
        public string Foto3 { get; set; }
        public string Ganador { get; set; }
        public string Jugadora { get; set; }
        public string Jugadorb { get; set; }
    }
}
