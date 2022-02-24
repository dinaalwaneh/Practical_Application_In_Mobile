using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buttons : ContentPage
    {

        public Buttons()
        {
            InitializeComponent();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("My Inforamtion", "Name : Dina Bader Alwaneh . \nBirthDate : 14-1-2002 . \nGender : Female . \nSpecialization : CAP .", "Close");
        }
    }
}