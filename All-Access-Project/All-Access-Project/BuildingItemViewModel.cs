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

        private string _BuildingDesc;
        public string BuildingDesc
        {
            set
            {
                _BuildingDesc= value;
                OnPropertyChanged(nameof(_BuildingDesc));
            }
            get => _BuildingDesc;
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
            }
            
        }

        public ICommand AddBuildingCommand => new Command(AddBuildingItem);
        async void AddBuildingItem()
        {
            BuildingItems.Add(new BuildingItem(BuildingName, BuildingDesc, DepartmentName, DepartmentHead, DepartmentContact));
            OnPropertyChanged(nameof(BuildingItems));
            await Application.Current.MainPage.Navigation.PopAsync();


        }
        public ICommand NewBuildingForm => new Command(async () =>
        {
            await Application.Current.MainPage.Navigation.PushAsync(new BuildingForm());
        });

    }
}
