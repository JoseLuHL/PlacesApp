using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class Habilidades
    {
        public int Id { get; set; }
        public string Habilidad { get; set; }
        public string Posicion { get; set; }
        public string User { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Foto { get; set; }
        public string Creado { get; set; }
        public string Equipo { get; set; }
        public string Estado { get; set; }
    }
}
