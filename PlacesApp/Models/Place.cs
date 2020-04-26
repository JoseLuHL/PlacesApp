using PlacesApp.Views;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlacesApp.Models
{
    public class Place : MvvmHelpers.BaseViewModel, INotifyPropertyChanged
    {
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                SetProperty(ref nombre, value);
                SetProperty(ref concepto, value);
            }
        }

        private string hora;

        public string Hora
        {
            get { return hora; }
            set
            {
                SetProperty(ref hora, value);
                SetProperty(ref concepto, value);
            }
        }
        private string precio;

        public string Precio
        {
            get { return precio; }
            set
            {
                SetProperty(ref precio, value);
                SetProperty(ref concepto, value);
            }
        }


        private string fecha = DateTime.Now.Date.ToShortDateString();

        public string Fecha
        {
            get => fecha;
            set
            {
                SetProperty(ref fecha, value.Substring(0, 10));
                SetProperty(ref concepto, value);
            }
        }
        public DelegateCommand ResumenComando
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    Application.Current.MainPage.Navigation.PushAsync(new PgReserva()
                    {
                        BindingContext = this
                    }
                         );
                });
            }
        }

       
        //public DelegateCommand ContinuarComando
        //{
        //    get
        //    {
        //        return new DelegateCommand(async (string h) =>
        //        {
        //            hora = h;
        //            await Application.Current.MainPage.DisplayAlert("", "Pueba fcha " + fecha, "OK");
        //        });
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;
        //public string Nombre { get; set; }
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public bool IsPopular { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsTrending { get; set; }
        public string IdAnimation { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Foto { get; set; }
        public string Estado { get; set; }
        public string Lat { get; set; }
        public string Longi { get; set; }
        private string celular;
        public string Celular
        {
            get => $"{"Celular: "} {celular}";
            set => SetProperty(ref celular, value);
        }

        public string User { get; set; }
        public string Creada { get; set; }
        //public string Direccion { get; set; }
        private string direccion;
        public string Direccion
        {
            get => $"{"Dirección:"} {direccion}";
            set => SetProperty(ref direccion, value);
        }
        public List<string> Images { get; set; }


        private string concepto = $"{"Reserva de cancha"}  {"para la fecha "}";

        public string Concepto
        {
            get { return $"Reserva de cancha {nombre} para la fecha {fecha} hora {hora} por el valor de {precio}"; }
            set { SetProperty(ref concepto, value); }
        }

        public ObservableCollection<Horarios> Horario { get; set; }
    }

    public enum ListLayoutOptions
    {
        Big,
        Small
    }
}
