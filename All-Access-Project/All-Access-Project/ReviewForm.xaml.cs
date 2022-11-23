using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace All_Access_Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReviewForm : ContentPage
    {
        public string FormBuildingTitle;
        public ReviewForm()
        {
            InitializeComponent();
            ReviewFormTitle.Text = FormBuildingTitle;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ReviewFormTitle.Text = FormBuildingTitle;
        }
    }
}