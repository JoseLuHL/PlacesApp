using PlacesApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlacesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PgReserva : ContentPage
    {
        Place Place => ((Place)BindingContext);
        public PgReserva()
        {
            NavigationPage.SetHasBackButton(this, false);
            //BindingContext = context;
            InitializeComponent();
            descriptionContainer.FadeTo(1, 350, Easing.CubicInOut);
            descriptionContainer.TranslateTo(0, 0, 350, Easing.CubicInOut);
            
        }

    protected override void OnAppearing()
    {
            DisplayAlert("", Place.Nombre, "OK");
        //base.OnAppearing();
        //detailContainer.FadeTo(1, 200, Easing.CubicInOut);
        //detailContainer.TranslateTo(0, 0, 200, Easing.CubicInOut);

        //descriptionContainer.FadeTo(1, 350, Easing.CubicInOut);
        //descriptionContainer.TranslateTo(0, 0, 350, Easing.CubicInOut);
        //ViewModelsReservas view = new ViewModelsReservas();
        //BindingContext = view;
    }

    private void listViewEjemplo1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Horarios;
            if (item == null)
                return;
            Place.Hora = item.ProNombre;
            Place.Precio = item.ProPrecio;
            //var vn = new Place();
            //Place.ContinuarComando.Execute();
            //DisplayAlert("", Place.Fecha, "OK");

        }
    }
}

