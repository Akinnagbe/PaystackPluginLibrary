using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.PaystackLibrary
{
   public class DebitCardModel
    {
        public DebitCardModel()
        {
            CustomFields = new Dictionary<string, string>();
        }
        public Dictionary<string,string> CustomFields { get; set; }

        public string Cvv { get; set; }

        public int ExpiryMonth { get; set; }

        public int ExpiryYear { get; set; }

        public string Pan { get; set; }

        /// <summary>
        /// Amount must be in Kobo e.g. N100 is 10000
        /// </summary>
        public int Amount { get; set; }
       
        public string Currency { get; set; }
       
        public string Email { get; set; }
       
        public string Plan { get; set; }
       
        public string Reference { get; set; }
       
        public string SplitCode { get; set; }
       
        public string Subaccount { get; set; }
       
        public int TransactionCharge { get; set; }
    }
}
