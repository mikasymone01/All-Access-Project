using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace All_Access_Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingList : ContentPage
    {

        public BuildingList()
        {
            InitializeComponent();
            BindingContext = new BuildingItemViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Console.WriteLine("Changin View");
            
        }

        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            Console.WriteLine("Itemselected");
            BuildingsPage building = new BuildingsPage();
            building.BindingContext = e.Item;
            Console.WriteLine(e.Item);
            await Application.Current.MainPage.Navigation.PushAsync(building);
            
        }


    }



}
    
