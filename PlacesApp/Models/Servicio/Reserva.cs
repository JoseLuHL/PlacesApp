using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class Reserva
    {
        public int IdReserva { get; set; }
        public string NombreCancha { get; set; }
        public string Fecha { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFinal { get; set; }
        public string Usuario { get; set; }
        public string Estado { get; set; }
        public string Reto { get; set; }
        public string Reserva1 { get; set; }
    }
}
