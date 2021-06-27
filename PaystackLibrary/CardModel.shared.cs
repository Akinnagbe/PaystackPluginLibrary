using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.PaystackLibrary
{
   public class CardModel
    {
        public string Cvv { get; set; }

        public int ExpiryMonth { get; set; }

        public int ExpiryYear { get; set; }

        public string Pan { get; set; }
    }
}
