#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion
using Newtonsoft.Json;
using System;
using Adyen.Model.Checkout.Action;
using Newtonsoft.Json.Linq;

namespace Adyen.Util
{
    internal class PaymentResponseActionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IPaymentResponseAction);
        }
        public override void WriteJson(JsonWriter writer,
            object value, JsonSerializer serializer)
        {
            throw new InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader,
            Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var paymentResponseAction = default(IPaymentResponseAction);
            switch (jsonObject["type"].ToString())
            {
                case "donation":
                    paymentResponseAction = new CheckoutDonationAction();
                    break;
                case "qrCode":
                    paymentResponseAction = new CheckoutQrCodeAction();
                    break;
                case "redirect":
                    paymentResponseAction = new CheckoutRedirectAction();
                    break;
                case "sdk":
                    paymentResponseAction = new CheckoutSDKAction();
                    break;
                case "threeDS2Challenge":
                    paymentResponseAction = new CheckoutThreeDS2ChallengeAction();
                    break;
                case "threeDS2Fingerprint":
                    paymentResponseAction = new CheckoutThreeDS2FingerPrintAction();
                    break;
                case "threeDS2Action":
                    paymentResponseAction = new CheckoutThreeDS2Action();
                    break;
                case "await":
                    paymentResponseAction = new CheckoutAwaitAction();
                    break;
                case "voucher":
                    paymentResponseAction = new CheckoutVoucherAction();
                    break;
                case "oneTimePasscode":
                    paymentResponseAction = new CheckoutOneTimePasscodeAction();
                    break;
            }

            serializer.Populate(jsonObject.CreateReader(), paymentResponseAction);
            return paymentResponseAction;
        }
    }
}
