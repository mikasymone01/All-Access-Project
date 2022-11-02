namespace All_Access_Project
{
    class ReviewItem
    {
        public int ReviewRating { get; set; }
        public string ReviewText { get; set; }

        public ReviewItem(int ReviewRating, string ReviewText)
        {
            this.ReviewRating = ReviewRating;
            this.ReviewText = ReviewText;
            
        }

    }
}
