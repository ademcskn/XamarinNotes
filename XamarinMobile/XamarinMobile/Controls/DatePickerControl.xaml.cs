using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerControl : ContentPage
    {
        public DatePickerControl()
        {
            InitializeComponent();
        }


        void Handle_Date(object sender, DateChangedEventArgs e)
        {
            TimeSpan timespan = endDate.Date - startDate.Date;
            lblResult.Text = String.Format("{0} day{1} between date", timespan.Days, timespan.Days == 1 ? "" : "s");
        }
    }
}