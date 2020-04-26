using System;
using System.Collections.Generic;
using System.Text;

namespace PlacesApp.Models
{
   public class Horarios
    {
        public int Id { get; set; }
        public string ProNombre { get; set; }
        public string ProPrecio { get; set; }
        public int? IdCancha { get; set; }
    }
}
