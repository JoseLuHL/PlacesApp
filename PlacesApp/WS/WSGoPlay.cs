using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PlacesApp.WS
{
    public class WSGoPlay
    {
        string url = "";
        HttpClient http;
        public string Error { get; set; }
        public WSGoPlay()
        {
            if (http == null)
            {
                http = new HttpClient();
            }
        }
        public async Task<ObservableCollection<T>> GetDatos<T>()
        {
            var retornar = new ObservableCollection<T>();
            var conte = await http.GetAsync(url);
            try
            {
                if (conte.IsSuccessStatusCode)
                {
                    var resp = await conte.Content.ReadAsStringAsync();
                    retornar = JsonConvert.DeserializeObject<ObservableCollection<T>>(resp);
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            return retornar;
        }
    }
}
