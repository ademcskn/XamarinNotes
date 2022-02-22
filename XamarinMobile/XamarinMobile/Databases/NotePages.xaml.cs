using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;

namespace XamarinMobile.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotePages : ContentPage
    {
        public NotePages()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listview.ItemsSource = await App.Database.GetNotesAsync();

            //var notes = new List<Note>();

            //var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");
            //foreach (var file in files)
            //{
            //    notes.Add(new Note { FileName = file, Text = File.ReadAllText(file), Date = File.GetCreationTime(file) });
            //}

            //listview.ItemsSource = notes.OrderBy(d => d.Date).ToList();
        }

        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NoteEntryPage { BindingContext = new Note() });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NoteEntryPage()
                {
                    BindingContext = e.SelectedItem as Note
                });
            }
        }
    }
}