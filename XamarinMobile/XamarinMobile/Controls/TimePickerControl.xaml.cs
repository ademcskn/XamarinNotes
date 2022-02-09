using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePickerControl : ContentPage
    {
        DateTime _triggerTime;
        public TimePickerControl()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimesTick);
        }
        bool OnTimesTick()
        {
            if (_switch.IsToggled && DateTime.Now >= _triggerTime)
            {
                _switch.IsToggled = false;
                DisplayAlert("Timer alert", "" + _entry.Text, "OK");
            }

            return true;
        }
        void SetTriggerTime()
        {
            if (_switch.IsToggled)
            {
                _triggerTime = DateTime.Today + timePicker.Time;

                if (_triggerTime < DateTime.Now)
                {
                    _triggerTime += TimeSpan.FromDays(1);
                }
            }
        }
        void Handle_Switch(object sender, ToggledEventArgs e)
        {
            SetTriggerTime();
        }
        void Handle_Changed(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                SetTriggerTime();
            }
        }
    }
}