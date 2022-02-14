using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Controls;
using XamarinMobile.DataBindings;
using XamarinMobile.Lists;
using XamarinMobile.Navigations;

namespace XamarinMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

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
            MainPage = new MasterDetailPageMenu();
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
