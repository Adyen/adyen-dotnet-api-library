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
using Adyen.Model.Checkout;
using Newtonsoft.Json.Linq;
using Adyen.Model.Checkout.Details;

namespace Adyen.Util
{
    internal class PaymentMethodDetailsConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IPaymentMethodDetails);
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
            var paymentMethodDetails = default(IPaymentMethodDetails);
            switch (jsonObject["type"].ToString())
            {
                case AchDetails.Ach:
                    paymentMethodDetails = new AchDetails();
                    break;
                case AmazonPayDetails.AmazonPay:
                    paymentMethodDetails = new AmazonPayDetails();
                    break;
                case AndroidPayDetails.AndroidPay:
                    paymentMethodDetails = new AndroidPayDetails();
                    break;
                case ApplePayDetails.ApplePay:
                    paymentMethodDetails = new ApplePayDetails();
                    break;
                case BacsDirectDebitDetails.Directdebit_GB:
                    paymentMethodDetails = new BacsDirectDebitDetails();
                    break;
                case BilldeskOnlineDetails.BilldeskOnline:
                    paymentMethodDetails = new BilldeskOnlineDetails();
                    break;
                case BilldeskWalletDetails.BilldeskWallet:
                    paymentMethodDetails = new BilldeskWalletDetails();
                    break;
                case BlikDetails.Blik:
                    paymentMethodDetails = new BlikDetails();
                    break;
                case CellulantDetails.Cellulant:
                    paymentMethodDetails = new CellulantDetails();
                    break;
                case DokuDetails.Alfamart:
                case DokuDetails.Bcava:
                case DokuDetails.Bniva:
                case DokuDetails.Briva:
                case DokuDetails.Cimbva:
                case DokuDetails.Danamonva:
                case DokuDetails.Permataliteatm:
                case DokuDetails.Permatatm:
                case DokuDetails.Sinarmasva:
                case DokuDetails.Indomaret:
                case DokuDetails.Mandiriva:
                    paymentMethodDetails = new DokuDetails();
                    break;
                case DotpayDetails.Dotpay:
                    paymentMethodDetails = new DotpayDetails();
                    break;
                case DragonpayDetails.EBanking:
                case DragonpayDetails.OTCBanking:
                case DragonpayDetails.OTCNonBanking:
                case DragonpayDetails.OTCPhilippines:
                    paymentMethodDetails = new DragonpayDetails();
                    break;
                case EcontextVoucherDetails.Stores:
                case EcontextVoucherDetails.Seveneleven:
                    paymentMethodDetails = new EcontextVoucherDetails();
                    break;
                case EntercashDetails.Entercash:
                    paymentMethodDetails = new EntercashDetails();
                    break;
                case GiropayDetails.Giropay:
                    paymentMethodDetails = new GiropayDetails();
                    break;
                case GooglePayDetails.GooglePay:
                    paymentMethodDetails = new GooglePayDetails();
                    break;
                case IdealDetails.Ideal:
                    paymentMethodDetails = new IdealDetails();
                    break;
                case KlarnaDetails.Klarna:
                case KlarnaDetails.KlarnaAccount:
                case KlarnaDetails.KlarnaB2B:
                case KlarnaDetails.KlarnaPayNow:
                case KlarnaDetails.KlarnaPayments:
                case KlarnaDetails.KlarnaPaymentsAccount:
                case KlarnaDetails.KlarnaPaymentsB2B:
                    paymentMethodDetails = new KlarnaDetails();
                    break;
                case LianLianPayDetails.EbankingCredit:
                case LianLianPayDetails.EbankingDebit:
                case LianLianPayDetails.EbankingEnterprise:
                    paymentMethodDetails = new LianLianPayDetails();
                    break;
                case MasterpassDetails.Masterpass:
                    paymentMethodDetails = new MasterpassDetails();
                    break;
                case MbwayDetails.Mbway:
                    paymentMethodDetails = new MbwayDetails();
                    break;
                case MolPayDetails.EBankingDirectMY:
                case MolPayDetails.EBankingFPXMy:
                case MolPayDetails.EBankingMY:
                case MolPayDetails.EBankingTH:
                case MolPayDetails.EBankingVN:
                case MolPayDetails.FPX:
                    paymentMethodDetails = new MolPayDetails();
                    break;
                case MobilePayDetails.Mobilepay:
                    paymentMethodDetails = new MobilePayDetails();
                    break;
                case PayPalDetails.PayPal:
                    paymentMethodDetails = new PayPalDetails();
                    break;
                case PayUUpiDetails.PayUinUPI:
                    paymentMethodDetails = new PayUUpiDetails();
                    break;
                case QiwiWalletDetails.QiwiWallet:
                    paymentMethodDetails = new QiwiWalletDetails();
                    break;
                case SamsungPayDetails.SamsungPay:
                    paymentMethodDetails = new SamsungPayDetails();
                    break;
                case SepaDirectDebitDetails.Sepadirectdebit:
                    paymentMethodDetails = new SepaDirectDebitDetails();
                    break;
                case UpiDetails.Upi:
                    paymentMethodDetails = new UpiDetails();
                    break;
                case VippsDetails.Vipps:
                    paymentMethodDetails = new VippsDetails();
                    break;
                case VisaCheckoutDetails.VisaCheckout:
                    paymentMethodDetails = new VisaCheckoutDetails();
                    break;
                case WeChatPayDetails.Wechatpay:
                    paymentMethodDetails = new WeChatPayDetails();
                    break;
                case WeChatPayMiniProgramDetails.WechatpayMiniProgram:
                    paymentMethodDetails = new WeChatPayMiniProgramDetails();
                    break;
                default:
                    paymentMethodDetails = new DefaultPaymentMethodDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), paymentMethodDetails);
            return paymentMethodDetails;
        }
    }
}
