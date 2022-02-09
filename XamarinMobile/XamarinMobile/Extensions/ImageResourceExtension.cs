using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Extensions
{
    [ContentProperty("Source")]
    internal class ImageResourceExtension : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ResourceId == null)
                return null;
            return ImageSource.FromResource(ResourceId);
        }
    }
}
