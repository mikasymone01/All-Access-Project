using All_Access_Project.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace All_Access_Project.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}