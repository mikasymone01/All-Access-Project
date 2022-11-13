using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace All_Access_Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserAccountDetails : ContentPage
    {
        public UserAccountDetails()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameEntry.Text) || string.IsNullOrWhiteSpace(LastName.Text) || string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(Email.Text))
            {
                await DisplayAlert("Invalid", "Blank or Whitespace value is Invalid!", "OK");
            }
            else
                AddNewAccount();
        }

        async void AddNewAccount()
        {
            await App.All_Access_Database.CreateAccount(new UserAccounts
            {
                firstName = nameEntry.Text,
                lastName = LastName.Text,
                password = Password.Text,
                email = Email.Text
            });
            await Navigation.PopAsync();
        }
    }
}