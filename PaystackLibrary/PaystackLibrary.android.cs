using Android.App;
using Java.Lang;
using NG.Sterling.Paystackbindinglibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.PaystackLibrary
{
    /// <summary>
    /// Interface for PaystackLibrary
    /// </summary>
    public class PaystackLibraryImplementation : IPaystackLibrary
    {
        public event EventHandler<string> PaymentNotification;
        private static Activity CurrentActivity { get; set; }

        public void StartFreshCharge(DebitCardModel debitCardModel)
        {

            var paystack = new NG.Sterling.Paystackbindinglibrary.PaystackLibrary();
            var chargeModel = new ChargeCardModel
            {
                Pan = debitCardModel.Pan,
                ExpiryMonth = debitCardModel.ExpiryMonth,
                ExpiryYear = debitCardModel.ExpiryYear,
                Cvv = debitCardModel.Cvv,
                Amount = debitCardModel.Amount,
                Currency = debitCardModel.Currency,
                Email = debitCardModel.Email,
                Reference = debitCardModel.Reference,
                TransactionCharge = debitCardModel.TransactionCharge,
                CustomFields = debitCardModel.CustomFields,
                Plan = debitCardModel.Plan,
                SplitCode = debitCardModel.SplitCode,
                Subaccount = debitCardModel.Subaccount
            };
            Android.Util.Log.Debug(CrossPaystackLibrary.Tag, "Before StartFreshCharge");
            paystack.StartFreshCharge(chargeModel, CurrentActivity, new Plugin.PaystackLibrary.PaystackTransactionCallback(PaymentNotification));
            Android.Util.Log.Debug(CrossPaystackLibrary.Tag, "After StartFreshCharge");
        }


        public static void Initialize(Activity activity, string publicKey)
        {
            CurrentActivity = activity;
            NG.Sterling.Paystackbindinglibrary.PaystackLibrary.Init(activity, publicKey);
            string packageName = activity.Application.ApplicationContext.PackageName;
            Android.Util.Log.Debug(CrossPaystackLibrary.Tag, $"Library Initialized for Package {packageName}");
            
        }

    }



}
