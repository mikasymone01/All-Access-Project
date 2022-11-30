using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.WriteLine(building.currentBuildingName);
            var revCount = ReviewItemViewModel._reviewItems.Count;

            for (int i = 0; i < revCount; i++)
            {
                Console.WriteLine("For loop accessed");
                Console.WriteLine(ReviewItemViewModel._reviewItems[i].ReviewBuildingName);
                if (ReviewItemViewModel._reviewItems[i].ReviewBuildingName == building.currentBuildingName)
                {
                    Console.WriteLine("If loop accessed");
                    ReviewItemViewModel._sortedReviewItems.Add(ReviewItemViewModel._reviewItems[i]);
                }
            }
            Console.WriteLine(ReviewItemViewModel._sortedReviewItems.Count);
            await Application.Current.MainPage.Navigation.PushAsync(building);


        }


    }



}
    
