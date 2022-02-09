using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StylingPage : ContentPage
    {
        public StylingPage()
        {
            InitializeComponent();
            subject.Text = (string)Application.Current.Resources["SubjectPlaceHolder"];
            subject.TextColor = (Color)Application.Current.Resources["InputPlaceHolderColor"];


            Application.Current.Resources["BtnSubmitBgColor"] = Resources["GrayBgColor"];
            Application.Current.Resources["BtnCancelBgColor"] = Resources["GrayBgColor"];
        }

        void HandleSubject(object sender, FocusEventArgs e)
        {
            var placeholdertext = (string)Application.Current.Resources["SubjectPlaceHolder"];
            if (subject.Text == placeholdertext)
            {
                subject.Text = string.Empty;
                subject.TextColor = (Color)Application.Current.Resources["InputTextColor"];
                return;
            }

            if (subject.Text == string.Empty)
            {
                subject.Text = placeholdertext;
                subject.TextColor = (Color)Application.Current.Resources["InputPlaceHolderColor"];
                Application.Current.Resources["BtnSubmitBgColor"] = Resources["GrayBgColor"];
                Application.Current.Resources["BtnCancelBgColor"] = Resources["GrayBgColor"];
                //return;
            }
            else
            {
                Application.Current.Resources["BtnSubmitBgColor"] = Resources["GreenBgColor"];
                Application.Current.Resources["BtnCancelBgColor"] = Resources["RedBgColor"];
            }
        }
    }
}