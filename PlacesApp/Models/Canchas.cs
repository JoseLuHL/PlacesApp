using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PlacesApp.Models
{
    public partial class Canchas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public string Estado { get; set; }
        public string Lat { get; set; }
        public string Longi { get; set; }
        public string Celular { get; set; }
        public string User { get; set; }
        public string Creada { get; set; }
        public string Direccion { get; set; }
        public ObservableCollection<Horarios> Horario { get; set; }

    }
}
