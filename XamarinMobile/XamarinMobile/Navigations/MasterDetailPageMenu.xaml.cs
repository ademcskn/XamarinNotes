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
    public partial class MasterDetailPageMenu : MasterDetailPage
    {
        List<MasterDetailItem> menulist;
        public MasterDetailPageMenu()
        {
            InitializeComponent();
            menulist = new List<MasterDetailItem>();

            menulist.Add(new MasterDetailItem() { Title = "First Page", Icon = "first.png", PageType = typeof(FirstPage) });
            menulist.Add(new MasterDetailItem() { Title = "Second Page", Icon = "first.png", PageType = typeof(SecondPage) });
            menulist.Add(new MasterDetailItem() { Title = "Third Page", Icon = "first.png", PageType = typeof(ThirdPage) });

            listview.ItemsSource = menulist;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(FirstPage)));
        }

        void Handle_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailItem;
            Type page = item.PageType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}