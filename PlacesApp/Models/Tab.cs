using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace PlacesApp.Models
{
    public class Tab : MvvmHelpers.BaseViewModel, INotifyPropertyChanged
    {
        public string Nombre { get; set; }
        public string Id { get; set; }
        public bool Selected { get; set; }
        public string Title { get; set; }
        public List<Place> Items { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
