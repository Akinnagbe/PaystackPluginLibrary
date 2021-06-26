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


        public void StartFreshCharge(DebitCardModel debitCardModel)
        {
            throw new NotImplementedException();
        }
    }
}
