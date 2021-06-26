using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected void Pay(object sender, EventArgs e)
        {
            try
            {
                var card = new Plugin.PaystackLibrary.DebitCardModel
                {
                    Amount = 31000,
                    Currency = "ngn",
                    Cvv = "408",
                    Email = "olamide.akinnagbe@sterling.ng",
                    ExpiryMonth = 4,
                    ExpiryYear = 22,
                    Pan = "4084084084084081",
                    Reference = Guid.NewGuid().ToString("n"),

                };
                Plugin.PaystackLibrary.CrossPaystackLibrary.Current.PaymentNotification += Current_PaymentNotification;
                Plugin.PaystackLibrary.CrossPaystackLibrary.Current.StartFreshCharge(card);

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void Current_PaymentNotification(object sender, string e)
        {
            DisplayAlert("Payment Reference", e, "Okay");
        }
    }
}
