using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DisplayYears(object sender, EventArgs e)
        {
           int year = 1990;
            for (; year <= 2030; year++)
            {
                Years.Text += year.ToString() + "\n";
            }
        }

    }
}
