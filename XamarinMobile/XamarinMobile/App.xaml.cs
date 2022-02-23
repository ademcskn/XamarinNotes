using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.CollectionViews;
using XamarinMobile.Controls;
using XamarinMobile.Databases;
using XamarinMobile.DataBindings;
using XamarinMobile.Lists;
using XamarinMobile.Navigations;
using XamarinMobile.Views;

namespace XamarinMobile
{
    public partial class App : Application
    {
        private const string ThemeKey = "Theme";
        private const string NotificationsKey = "Notifications";
        public static string FolderPath { get; private set; }
        private static NoteDatabase database;

        //Singleton Desing Pattern
        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteDatabase(Path.Combine(App.FolderPath, "NotesDb.db3"));
                }
                return database;
            }
        }
        //Singleton Desing Pattern

        public string Theme
        {
            get
            {
                if (this.Properties.ContainsKey(ThemeKey))
                {
                    return Properties[ThemeKey].ToString();
                }
                return "";
            }
            set
            {
                Properties[ThemeKey] = value;
            }
        }

        public bool Notifications
        {
            get
            {
                if (this.Properties.ContainsKey(NotificationsKey))
                {
                    return (bool)Properties[NotificationsKey];
                }
                return false;
            }
            set
            {
                Properties[NotificationsKey] = value;
            }
        }
        public App()
        {
            InitializeComponent();

            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

            //MainPage = new AbsoluteDemo();
            //MainPage = new AbsoluteDemo2();
            //MainPage = new StackLayoutDemo();
            //MainPage = new StackLayoutDemo2();
            //MainPage = new StackLayoutDemo3();
            //MainPage = new RelativeLayout();
            //MainPage = new RelativeLayout2();
            //MainPage = new FlexLayout();
            //MainPage = new StylingPage();
            //MainPage = new CssPage();
            //MainPage = new LabelControl();
            //MainPage = new EntryControl();
            //MainPage = new CheckBoxControl();
            //MainPage = new SwitchControl();
            //MainPage = new SliderControl();
            //MainPage = new StepperControl();
            //MainPage = new PickerControl();
            //MainPage = new DatePickerControl();
            //MainPage = new TimePickerControl();
            //MainPage = new PopupsControl();
            //MainPage = new TableViewControl();
            //MainPage = new ImageControl();
            //MainPage = new FontIconsControl();
            //MainPage = new ActivityIndicatorControl();
            //MainPage = new BasicBindings();
            //MainPage = new NotifyProperyChangedDemo();
            //MainPage = new AddContactsPage();
            //MainPage = new SimpleListView();
            //MainPage = new ModelBinding();
            //MainPage = new ViewCells();
            //MainPage = new ObservableData();
            //MainPage = new GroupingItems();
            //MainPage = new ListViewEvents();
            //MainPage = new ListViewEvents();
            //MainPage = new AddingButtons();
            //MainPage = new ContextActions();
            //MainPage = new NavigationPage(new FirstPage());
            //MainPage = new NavigationPage(new MasterPage());
            //MainPage = new NavigationPage(new ListViewMenu());
            //MainPage = new NavigationPage(new TableViewMenu());
            //MainPage = new MasterDetailPageMenu(); 
            //MainPage = new TabbedPageMenu();
            //MainPage = new CarouselPageSample();
            //MainPage = new SimpleCollectionView();
            //MainPage = new DataBindingCollectionView();
            //MainPage = new MovieList();
            //MainPage = new NavigationPage(new Views.MainPage());
            //MainPage = new AppShell();
            //MainPage = new AppProperties();
            //MainPage = new FileSystem();
            //MainPage = new NavigationPage(new NotePages());
            MainPage = new RestApi();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
