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
        
        public ReviewItemViewModel()
        {
            ReviewItems = new ObservableCollection<ReviewItem>();

            ReviewItems.Add(new ReviewItem(5, "Good Food"));
            ReviewItems.Add(new ReviewItem(3, "Bad Food Really awfule. Blah blah heaadhd dwoduef  fkjejf fefj fef hfehf fiefi hfm nelfihwk fjbr.kf hw; fwufh wiu fhwf"));
            ReviewItems.Add(new ReviewItem(2, "OK Food"));
        }

        


        private int _NewReviewRatingValue;
        public int NewReviewRatingValue {
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


        public ICommand AddReviewCommand => new Command(AddReviewItem);
        void AddReviewItem()
        {
            Console.WriteLine(NewReviewInputValue);
            ReviewItems.Add(new ReviewItem(NewReviewRatingValue, NewReviewInputValue));
            OnPropertyChanged(nameof(ReviewItems));
            Console.WriteLine(ReviewItems.Count);
        }

      

    }
}
