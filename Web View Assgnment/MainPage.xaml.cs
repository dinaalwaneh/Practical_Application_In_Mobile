using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DateAndTime();
        }

        private void DateAndTime()
        {
            dateLabel.Text = DateTime.Now.ToString("dd-MMM-yyyy/hh:mm:ss tt");
        }

        void webviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            labelLoading.IsVisible = true;

        }

        void webviewNavigated(object sender, WebNavigatedEventArgs e)
        {
            labelLoading.IsVisible = false;
        }

        private async void Google(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new GooglePage());

            /*Display Pages in the same page :*/
           // NajahPage.IsVisible = false;
           // GooglePage.IsVisible = true;
           // ZajelPage.IsVisible = false;
        }

        private async void Zajel(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ZajelPage());

            /*Display Pages in the same page :*/
            // NajahPage.IsVisible = false;
            // GooglePage.IsVisible = false;
            // ZajelPage.IsVisible = true;
        }
    }
}
