using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppProperties : ContentPage
    {
        public AppProperties()
        {
            InitializeComponent();

            //if (Application.Current.Properties.ContainsKey("Theme"))
            //{
            //    theme.Text = Application.Current.Properties["Theme"].ToString();
            //}
            //
            //if (Application.Current.Properties.ContainsKey("Notification"))
            //{
            //    notifications.On = (bool)Application.Current.Properties["Notification"];
            //}

            var app = Application.Current as App;
            BindingContext = app;

            //theme.Text = app.Theme;
            //notifications.On = app.Notifications;
        }

        //void OnChanged(object sender, EventArgs e)
        //{
        //    var app = Application.Current as App;
        //    app.Theme = theme.Text;
        //    app.Notifications = notifications.On;
        //
        //
        //
        //    //Application.Current.Properties["Theme"] = theme.Text;
        //    //Application.Current.Properties["Notification"] = notification.On;
        //
        //    //Application.Current.SavePropertiesAsync();
        //}

        //Uygulama kapandığı anda veya başka bir sayfaya geçildiği anca çalışan metod.
        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing(); 
        //}
    }
}