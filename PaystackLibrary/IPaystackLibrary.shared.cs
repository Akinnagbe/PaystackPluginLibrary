using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.PaystackLibrary
{
    public interface IPaystackLibrary
    {
        event EventHandler<string> PaymentNotification;
        void StartFreshCharge(DebitCardModel debitCardModel);
        
    }

}
