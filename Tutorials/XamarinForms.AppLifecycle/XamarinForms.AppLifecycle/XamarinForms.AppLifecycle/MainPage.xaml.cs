using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinForms.AppLifecycle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            entry.Text = (Application.Current as App).DisplayText;
        }

        void OnEntry_Completed(object sender, EventArgs e)
        {
            (Application.Current as App).DisplayText = entry.Text;
        }
    }
}
