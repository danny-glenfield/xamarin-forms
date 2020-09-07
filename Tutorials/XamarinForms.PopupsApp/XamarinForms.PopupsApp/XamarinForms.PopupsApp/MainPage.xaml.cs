using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinForms.PopupsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnDisplayAlertButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "This is an alert.", "OK");
        }

        async void OnDisplayAlertQuestionButton_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert("Save?", "Would you like to save your data?", "Yes", "No");
            Console.WriteLine($"Save data: {response}");
        }

        async void OnDisplayActionSheetButton_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
            Console.WriteLine($"Action: {action}");
        }
    }
}
