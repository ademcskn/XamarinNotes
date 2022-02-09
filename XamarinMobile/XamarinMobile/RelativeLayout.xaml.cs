using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayout : ContentPage
    {
        public RelativeLayout()
        {
            InitializeComponent();



            var layout = new RelativeLayout();
            var box = new BoxView { Color = Color.Aqua };
            layout.OnChildAdded(box);

            //layout.
            //    .Add(box, widthConstraint: Constraint.RelativeToParent)

        }
    }
}