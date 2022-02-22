using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FileSystem : ContentPage
    {
        string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");
        public FileSystem()
        {
            InitializeComponent();
            if (File.Exists(_filename))
            {
                editor.Text = File.ReadAllText(_filename);
            }
        }

        void Handle_Save(object sender, EventArgs e)
        {
            File.WriteAllText(_filename, editor.Text);
        }

        void Handle_Delete(object sender, EventArgs e)
        {
            if (File.Exists(_filename))
            {
                File.Delete(_filename);
                editor.Text = String.Empty;
            }
        }
    }
}