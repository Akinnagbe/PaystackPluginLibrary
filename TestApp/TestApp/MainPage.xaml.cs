using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected void MakePayment(object sender,EventArgs e)
        {
            Plugin.PaystackLibrary.CrossPaystackLibrary.Current.MakePayment();
        }
    }
}
