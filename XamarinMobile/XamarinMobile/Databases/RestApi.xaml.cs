using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;

namespace XamarinMobile.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestApi : ContentPage
    {
        const string ApiUrl = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        public RestApi()
        {
            InitializeComponent();
        }

        //Sayfa yüklendiği zaman çalışan metod. Override ediyoruz...
        protected override async void OnAppearing()
        {
            var result = await _client.GetStringAsync(ApiUrl); //adrese sorgu gönderiyoruz. await komutuyla async olan metodtan gelen sonucu bekliyoruz.
            //result verisi string yapıda ve bunu post listesine dönüştürmek için nugetten newtonsoft.json ı dahil ettik.

            listview.ItemsSource = JsonConvert.DeserializeObject<List<Post>>(result);
            base.OnAppearing();
        }
    }
}