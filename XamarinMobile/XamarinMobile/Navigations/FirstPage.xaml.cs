using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;

namespace XamarinMobile.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        async void Next_Click(Object sender, EventArgs e)
        {
            string name = "Adem Coşkun";
            var movie = new Movie
            {
                Name = "Film Adı",
                Description = "Açıklaması",
                Director = "Yöneticisi"
            };
            await Navigation.PushAsync(new SecondPage(name, movie));
            //await Navigation.PushModalAsync(new SecondPage(name, movie));

            //kullanıcıyla etkileşime girebilecek bir sayfa açmak istediğimizde Modal eklentisini koyabiliriz...
            //await Navigation.PushAsync(new SecondModelPage(name, movie));
        }
    }
}