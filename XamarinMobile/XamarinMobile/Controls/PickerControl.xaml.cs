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
    public partial class PickerControl : ContentPage
    {
        public PickerControl()
        {
            InitializeComponent();

            LoadModels();
        }

        void LoadModels()
        {
            var models = new List<string>
            {
                "Opel","Mazda","Mercedes","Bmw"
            };

            foreach (var model in models)
            {
                modelsPicker.Items.Add(model);
            }
        }

        void Handle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = modelsPicker.SelectedIndex;

            if (selectedIndex != -1)
            {
                lblResult.Text = modelsPicker.Items[selectedIndex];
            }
        }
    }
}