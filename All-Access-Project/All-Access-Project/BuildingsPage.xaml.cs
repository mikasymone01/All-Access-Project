﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace All_Access_Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingsPage : ContentPage
    {
        public static string _currentBuildingName;
        public string currentBuildingName
        {
            get => BuildingNameTitle.Text;
            set => _currentBuildingName = value;
        }

        public BuildingsPage()
        {
            InitializeComponent();
            
        }


    }
}