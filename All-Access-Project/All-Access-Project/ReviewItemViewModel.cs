using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using Xamarin.Forms;

namespace All_Access_Project
{
     class ReviewItemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public static ObservableCollection<ReviewItem> _reviewItems;
        public ObservableCollection<ReviewItem> ReviewItems
        {
            get => _reviewItems; 
            set
            {
                _reviewItems = value;
                OnPropertyChanged(nameof(_reviewItems));
            }
            
        }

        //An observable collectiom to hold the filtered review items
        public static ObservableCollection<ReviewItem> _sortedReviewItems;
        public ObservableCollection<ReviewItem> SortedReviewItems
        {
            get => _sortedReviewItems;
            set
            {
                _sortedReviewItems = value;
                OnPropertyChanged(nameof(_sortedReviewItems));
            }

        }

        private int _NewReviewRatingValue;
        public int NewReviewRatingValue
        {
            set
            {
                _NewReviewRatingValue = value;
                OnPropertyChanged(nameof(_NewReviewRatingValue));
            }
            get => _NewReviewRatingValue;
        }

        private string _NewReviewInputValue;
        public string NewReviewInputValue
        {
            set
            {
                _NewReviewInputValue = value;
                OnPropertyChanged(nameof(_NewReviewInputValue));
            }
            get => _NewReviewInputValue;

        }

        private string _reviewBuildingName;
        public string BuildingName
        {
            set
            {
                _reviewBuildingName = value;
                OnPropertyChanged(nameof(_reviewBuildingName));
            }
            get => _reviewBuildingName;
        }

        


        public ICommand AddReviewCommand => new Command(AddReviewItem);
        async void AddReviewItem()
        {
            Console.WriteLine(NewReviewInputValue);
            Console.WriteLine(BuildingName);
            ReviewItems.Add(new ReviewItem(NewReviewRatingValue, NewReviewInputValue, BuildingName));
            OnPropertyChanged(nameof(ReviewItems));
            Console.WriteLine(ReviewItems.Count);
            await Application.Current.MainPage.Navigation.PopAsync();

            
        }
        public ICommand ReviewFormCommand
        {
            get
            {
                return new Command<string>((BuildingName) => {

                    PushNewReviewForm(BuildingName);
                    });
            }

        }
        public string currentName;
        async void  PushNewReviewForm(string BuildingName)
        {
            ReviewForm reviewForm = new ReviewForm();
            reviewForm.FormBuildingTitle = BuildingName;
            currentName = BuildingName;
            await Application.Current.MainPage.Navigation.PushAsync(reviewForm);
            
        }

        public ReviewItemViewModel()
        {
            SortedReviewItems = new ObservableCollection<ReviewItem>();
            if (ReviewItems == null)
            {
                Console.WriteLine("Making a new OC");
                ReviewItems = new ObservableCollection<ReviewItem>();
                ReviewItems.Add(new ReviewItem(3, "A very nice freshman dorm.There are only stairs to go in through the front entrance." +
                    "A wheelcahir user would have to enter through the back ramp which needs to be unlocked by faculty. There is an elevator inside, " +
                    "but it would constantly break throughout the year.", "Langston"));
                ReviewItems.Add(new ReviewItem(3, "Its a big building so navigation was difficult and The elevators are extremely slow. Other than that, I loved having classes in this building.", "Hunter McDaniel"));
                ReviewItems.Add(new ReviewItem(2, "Having to wait 20 minutes for an elevator is awful. The classroom are spacious though", "Hunter McDaniel"));
            }
            

        }



    }
}
