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
    public partial class Reviews : ContentPage
    {


        public Reviews()
        {
            InitializeComponent();

            this.BindingContext = new ReviewItemViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var temp = this.BindingContext;
            this.BindingContext = null;
            this.BindingContext = temp;
        }
    }
    

       
    }
    
