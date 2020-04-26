using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class Equipo
    {
        public int Id { get; set; }
        public string Integrante { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string User { get; set; }
    }
}
