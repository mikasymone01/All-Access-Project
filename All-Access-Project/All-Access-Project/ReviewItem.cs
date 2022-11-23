namespace All_Access_Project
{
    class ReviewItem
    {
        public int ReviewRating { get; set; }
        public string ReviewText { get; set; }

        public string ReviewBuildingName { get; set; }

        public ReviewItem(int ReviewRating, string ReviewText, string ReviewBuildingName)
        {
            this.ReviewRating = ReviewRating;
            this.ReviewText = ReviewText;
            this.ReviewBuildingName = ReviewBuildingName;
        }

    }
}
