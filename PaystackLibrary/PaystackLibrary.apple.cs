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

        public void Init(string publicKey)
        {
            throw new NotImplementedException();
        }

        public bool IsCardValid(CardModel cardModel)
        {
            throw new NotImplementedException();
        }

        public bool IsCVVValid(CardModel cardModel)
        {
            throw new NotImplementedException();
        }

        public bool IsExpiryDateValid(CardModel cardModel)
        {
            throw new NotImplementedException();
        }

        public bool IsPanValid(CardModel cardModel)
        {
            throw new NotImplementedException();
        }

        public void ResumeCharge(PaystackModel paystackModel, string accessCode)
        {
            throw new NotImplementedException();
        }

        public void StartFreshCharge(PaystackModel debitCardModel)
        {
            throw new NotImplementedException();
        }
    }
}
