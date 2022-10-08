using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace All_Access_Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string srvrdbname = "AllAccessDatabase";
                string srvrname = "10.0.0.31";
                string srvrusername = "AllAccessGroup";
                string srvrpassword = "MDDSDW";
                string sqlconn = $"Data Source={srvrname};Initial Catalog={srvrdbname}; User Id={srvrusername};Password={srvrpassword};Trusted_Connection=true";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}
