using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class Team
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Categoria { get; set; }
        public string User { get; set; }
        public string Lat { get; set; }
        public string Longi { get; set; }
        public string Creado { get; set; }
    }
}
