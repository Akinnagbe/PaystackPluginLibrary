using Android.App;
using Java.Lang;
using Com.Olamidejames.Paystackxamarinandroidlibrary;
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

        Com.Olamidejames.Paystackxamarinandroidlibrary.PaystackLibrary paystack;
        public PaystackLibraryImplementation()
        {
             paystack = new Com.Olamidejames.Paystackxamarinandroidlibrary.PaystackLibrary();
        }
        public void StartFreshCharge(PaystackModel debitCardModel)
        {

           
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
            Com.Olamidejames.Paystackxamarinandroidlibrary.PaystackLibrary.Init(activity, publicKey);
            string packageName = activity.Application.ApplicationContext.PackageName;
            Android.Util.Log.Debug(CrossPaystackLibrary.Tag, $"Library Initialized for Package {packageName}");

        }

        public bool IsCardValid(CardModel cardModel)
        {
            var isCardValid = paystack.IsCardValid(
                new Com.Olamidejames.Paystackxamarinandroidlibrary.CardModel()
                {
                    Cvv = cardModel.Cvv,
                    ExpiryMonth = cardModel.ExpiryMonth,
                    ExpiryYear = cardModel.ExpiryYear,
                    Pan = cardModel.Pan
                });

            return isCardValid;
        }

        public bool IsPanValid(CardModel cardModel)
        {
            var card = 
               new Com.Olamidejames.Paystackxamarinandroidlibrary.CardModel()
               {
                   Cvv = cardModel.Cvv,
                   ExpiryMonth = cardModel.ExpiryMonth,
                   ExpiryYear = cardModel.ExpiryYear,
                   Pan = cardModel.Pan
               };

            return paystack.IsValidPAN(card);
        }

        public bool IsCVVValid(CardModel cardModel)
        {
            var card =
               new Com.Olamidejames.Paystackxamarinandroidlibrary.CardModel()
               {
                   Cvv = cardModel.Cvv,
                   ExpiryMonth = cardModel.ExpiryMonth,
                   ExpiryYear = cardModel.ExpiryYear,
                   Pan = cardModel.Pan
               };

            return paystack.IsValidCVV(card);
        }

        public bool IsExpiryDateValid(CardModel cardModel)
        {
            var card =
               new Com.Olamidejames.Paystackxamarinandroidlibrary.CardModel()
               {
                   Cvv = cardModel.Cvv,
                   ExpiryMonth = cardModel.ExpiryMonth,
                   ExpiryYear = cardModel.ExpiryYear,
                   Pan = cardModel.Pan
               };

            return paystack.IsValidExpiryDate(card);
        }

        public void ResumeCharge(PaystackModel debitCardModel, string accessCode)
        {
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
            Android.Util.Log.Debug(CrossPaystackLibrary.Tag, "Before ResumeCharge");
            paystack.StartFreshCharge(chargeModel, CurrentActivity, new Plugin.PaystackLibrary.PaystackTransactionCallback(PaymentNotification));
            Android.Util.Log.Debug(CrossPaystackLibrary.Tag, "After ResumeCharge");
        }
    }



}
