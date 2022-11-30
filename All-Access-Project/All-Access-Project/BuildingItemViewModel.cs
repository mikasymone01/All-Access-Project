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
                BuildingItems.Add(new BuildingItem("Langston","A freshman dorm with a STEM Living Learning Community"
                    , "Residence Hall","Mr.Johnson", "(804) 524-1066"));
                BuildingItems.Add(new BuildingItem("Hunter McDaniel", "An education building that hosts classes for Psychology, Nursing, Chemistry, and Computer Science Majors",
                    "College of Natural and Health Sciences", "Dean Dawit Haile", "804-524-5969"));
                BuildingItems.Add(new BuildingItem("Jones Dining Hall", "Dining Hall for students and faculty to eat at","Dining Hall", null, null));
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
            //App.All_Access_Database.CreateBuilding(newBuilding);
            //Console.WriteLine(App.All_Access_Database.ReadBuildings());
            await Application.Current.MainPage.Navigation.PopAsync();


        }
      


    }
}
