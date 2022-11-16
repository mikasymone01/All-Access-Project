using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using Xamarin.Forms;

namespace All_Access_Project
{
    class BuildingItemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static ObservableCollection<BuildingItem> _BuildingItems;
        public ObservableCollection<BuildingItem> BuildingItems
        {
            get => _BuildingItems;
            set
            {
                _BuildingItems = value;
                OnPropertyChanged(nameof(_BuildingItems));
            }

        }

        private string _BuildingName;
        public string BuildingName
        {
            set
            {
                _BuildingName= value;
                OnPropertyChanged(nameof(_BuildingName));
            }
            get => _BuildingName;
        }

        private string _BuildingDescription;
        public string BuildingDescription
        {
            set
            {
                _BuildingDescription= value;
                OnPropertyChanged(nameof(_BuildingDescription));
            }
            get => _BuildingDescription;
        }

        private string _DepartmenName;
        public string DepartmentName
        {
            set
            {
                _DepartmenName = value;
                OnPropertyChanged(nameof(_DepartmenName));
            }
            get => _DepartmenName;
        }

        private string _DepartmenHead;
        public string DepartmentHead
        {
            set
            {
                _DepartmenHead = value;
                OnPropertyChanged(nameof(_DepartmenHead));
            }
            get => _DepartmenHead;
        }

        private string _DepartmentContact;
        public string DepartmentContact
        {
            set
            {
                _DepartmentContact = value;
                OnPropertyChanged(nameof(_DepartmentContact));
            }
            get => _DepartmentContact;
        }

        public BuildingItemViewModel()
        {
            if(BuildingItems == null)
            {
                BuildingItems = new ObservableCollection<BuildingItem>();
                BuildingItems.Add(new BuildingItem("Langston","Youeefihefkhngghc yt diyt d uf ytdyhgc t y tdkhgkhy k uyfkuyfj " +
                    "y ku6u65d kuyvuktf i6  uygkufi6tfd ,ufluflufkuyfy fuyjfku fo6 yljglj gljhg", null,null,null));
                BuildingItems.Add(new BuildingItem("Hunter", "Blahhhh", null, null, null));

            }
            
        }

        public ICommand NewBuildingForm => new Command(async () =>
        {
            await Application.Current.MainPage.Navigation.PushAsync(new BuildingForm());
        });


        public ICommand AddBuildingCommand => new Command(AddBuildingItem);
        async void AddBuildingItem()
        {
            var newBuilding= new BuildingItem(BuildingName, BuildingDescription, DepartmentName, DepartmentHead, DepartmentContact);
            BuildingItems.Add(newBuilding);
            OnPropertyChanged(nameof(BuildingItems));
            Console.WriteLine(App.All_Access_Database.ReadBuildings());
            await Application.Current.MainPage.Navigation.PopAsync();


        }
       

        /*public ICommand OnItemSelected => new Command(async () =>
        {
            Console.WriteLine("Itemselected");
            BuildingsPage buildings = this.OnItemSelected as BuildingsPage;
            await Application.Current.MainPage.Navigation.PushAsync(buildings);
        });*/



    }
}
