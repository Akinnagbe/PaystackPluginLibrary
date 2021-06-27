using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.PaystackLibrary
{
    public interface IPaystackLibrary
    {
        event EventHandler<string> PaymentNotification;
        void StartFreshCharge(PaystackModel paystackModel);
        bool IsCardValid(CardModel cardModel);
        bool IsPanValid(CardModel cardModel);
        bool IsCVVValid(CardModel cardModel);
        bool IsExpiryDateValid(CardModel cardModel);
        void ResumeCharge(PaystackModel paystackModel,string accessCode);
    }

}
