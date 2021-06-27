using Java.Lang;
using Com.Olamidejames.Paystackxamarinandroidlibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.PaystackLibrary
{
    public class PaystackTransactionCallback : Java.Lang.Object, IPaystackTransactionCallback
    {
        private readonly EventHandler<string> paymentNotification;

        public PaystackTransactionCallback(EventHandler<string> paymentNotification)
        {
            this.paymentNotification = paymentNotification;
        }
        public void OnError(Throwable error, string referenceId)
        {

        }

        public void OnSuccess(string referenceId)
        {
            Console.WriteLine(referenceId);
            Android.Util.Log.Debug("paystack_plugin", $"Payment Reference: {referenceId}");
            if(paymentNotification == null)
            {
                Android.Util.Log.Debug("paystack_plugin", "paymentNotification event is NULL");
            }
            else
            {
                Android.Util.Log.Debug("paystack_plugin", "paymentNotification event is NOT NULL");
            }
            paymentNotification?.Invoke(this, referenceId);
           
        }
    }
}
