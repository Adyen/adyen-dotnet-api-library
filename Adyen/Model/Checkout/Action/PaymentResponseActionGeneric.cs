using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.Model.Checkout.Action
{
    public class PaymentResponseActionGeneric : IPaymentResponseAction
    {
        public string Type { get; set; }

        public Dictionary<string, object> PaymentResponseAction { get; set; }
    }
}
