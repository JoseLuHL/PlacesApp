using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class Retos
    {
        public int Id { get; set; }
        public string Equiporetar { get; set; }
        public string Equipouser { get; set; }
        public string Categoria { get; set; }
        public string FechaReto { get; set; }
        public string Observaciones { get; set; }
        public string User { get; set; }
        public string Estado { get; set; }
    }
}
