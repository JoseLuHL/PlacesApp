using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using PlacesApp.Models;
using PlacesApp.Utils;
using PlacesApp.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace PlacesApp.ViewModels
{
    public class PlacesPageViewModel : ViewModelBase
    {
        public ObservableCollection<Place> Items { get; set; }
        public ObservableCollection<Models.Tab> TabItems { get; set; }
        public Models.Tab Item { get; set; }
        public string SelectedItemId { get; set; }
        public ListLayoutOptions ListLayout { get; set; }
        public string Section { get; set; }
        public DelegateCommand<Place> GoToDetailCommand { get; set; }
        public DelegateCommand<object> ChangeLayoutCommand { get; set; }

        public ICommand ReservaComando
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new PgReserva()
                    { BindingContext = this }
                        );
                });
            }
        }
        //public DelegateCommand<Place> ResumenComando { get; set; }
        //public DelegateCommand ResumenComando
        //{
        //    get
        //    {
        //        return new DelegateCommand(() =>
        //        {
        //            Application.Current.MainPage.Navigation.PushAsync(new PgReserva()
        //            { BindingContext = this }
        //                );
        //        });
        //    }
        //}

        public PlacesPageViewModel(INavigationService  navigationPage) : base(navigationPage)
        {
            GoToDetailCommand = new DelegateCommand<Place>(GoToDetail);
            Items = new ObservableCollection<Place>();
            Item = new Models.Tab();
            ListLayout = ListLayoutOptions.Big;
            ChangeLayoutCommand = new DelegateCommand<object>(ChangeLayout);
        }
        void ChangeLayout(object listLayout)
        {
            ListLayout = (ListLayoutOptions)listLayout;
        }
        async void GoToDetail(Place place)
        {
            SelectedItemId = place.IdAnimation;
            var navParam = new NavigationParameters { { nameof(place), place } };
            await NavigationService.NavigateAsync($"{nameof(PlaceDetailPage)}", navParam);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.GetNavigationMode() != NavigationMode.Back)
            {
                LoadData();
            }
            else
            {
                SelectedItemId = null;
            }
        }
         async void LoadData ()
        {
            var all = new List<Place>();
            var trending = new List<Place>();
            var featured = new List<Place>();
            var popular = new List<Place>();
            //var rivales = new List<Place>();
            var data = await Data.GetCanchasAsync();
            foreach (Canchas item in data)
            {
                all.Add(new Place
                {
                    Id = item.Id.ToString(),
                    Description = item.Descripcion,
                    Nombre = item.Nombre,
                    Title = item.Nombre,
                    SubTitle = item.Direccion,
                    Image = "https://http2.mlstatic.com/mallas-para-canchas-sinteticas-D_NQ_NP_913115-MCO25210370942_122016-F.jpg",
                    IdAnimation = $"All{Guid.NewGuid()}",
                    Celular = item.Celular,
                    Direccion = item.Direccion,
                    Estado = item.Estado,
                    Foto = item.Foto,
                    Images = new List<string>
                    {
                        "https://media.cntraveler.com/photos/5d921b84d19ce4000851d902/master/w_1200,c_limit/Tongabezi-&-Sindabezi_2019_IMG_5206-1.jpg",
                        "https://media.cntraveler.com/photos/5d921b846168d9000af15c45/master/w_1200,c_limit/Tongabezi-&-Sindabezi_2019_IMG_5408-1.jpg",
                        "https://media.cntraveler.com/photos/5d921b8537c3f70009b84f9d/master/w_1200,c_limit/Tongabezi-&-Sindabezi_2019_Tongabezi_March18-62.jpg"
                    },
                    Horario=item.Horario
                    
                }) ;
            }

            //for (int i = 0; i < Data.places.Count; i++)
            //{
            //    var element = Data.places[i];
            //    all.Add(new Place
            //    {
            //        Id = element.Id,
            //        Description = element.Description,
            //        Title = element.Title,
            //        SubTitle = element.SubTitle,
            //        Images = element.Images,
            //        Image = element.Image,
            //        IdAnimation = $"All{Guid.NewGuid()}"
            //    });

            //    if (element.IsTrending)
            //        trending.Add(new Place
            //        {
            //            Id = element.Id,
            //            Description = element.Description,
            //            Title = element.Title,
            //            SubTitle = element.SubTitle,
            //            Images = element.Images,
            //            Image = element.Image,
            //            IdAnimation = $"Trending{Guid.NewGuid()}"
            //        });

            //    if (element.IsFeatured)
            //        featured.Add(new Place
            //        {
            //            Id = element.Id,
            //            Description = element.Description,
            //            Title = element.Title,
            //            SubTitle = element.SubTitle,
            //            Images = element.Images,
            //            Image = element.Image,
            //            IdAnimation = $"Featured${Guid.NewGuid()}"
            //        });

            //    if (element.IsPopular)
            //        popular.Add(new Place
            //        {
            //            Id = element.Id,
            //            Description = element.Description,
            //            Title = element.Title,
            //            SubTitle = element.SubTitle,
            //            Images = element.Images,
            //            Image = element.Image,
            //            IdAnimation = $"Popular{Guid.NewGuid()}"
            //        });
            //}

            TabItems = new ObservableCollection<Models.Tab>
            {
                new Models.Tab
                {
                    Title="Canchas",
                    Selected = true,
                    Id = "A",
                    Items = all
                },
                 new Models.Tab
                {
                    Title="Noticia",
                    Id = "F",
                    Items = featured

                },
                new Models.Tab
                {
                    Title="Publicaciones",
                    Id = "P",
                    Items = popular
                }
            };
        }
        
    }
}
