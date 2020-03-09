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

using Adyen.Model.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Adyen.Util
{
    public class HmacValidator
    {
        // Computes the Base64 encoded signature using the HMAC algorithm with the HMACSHA256 hashing function.
        public string CalculateHmac(string signingstring, string hmacKey)
        {
            byte[] key = PackH(hmacKey);
            byte[] data = Encoding.UTF8.GetBytes(signingstring);

            try
            {
                using (HMACSHA256 hmac = new HMACSHA256(key))
                {
                    // Compute the hmac on input data bytes
                    byte[] rawHmac = hmac.ComputeHash(data);

                    // Base64-encode the hmac
                    return Convert.ToBase64String(rawHmac);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Failed to generate HMAC : " + e.Message);
            }
        }

        public string CalculateHmac(NotificationRequestItem notificationRequestItem, string key)
        {
            var notificationRequestItemData = GetDataToSign(notificationRequestItem);
            return CalculateHmac(notificationRequestItemData, key);
        }

        private byte[] PackH(string hex)
        {
            if ((hex.Length % 2) == 1)
            {
                hex += '0';
            }

            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            return bytes;
        }


        public string BuildSigningString(IDictionary<string, string> dict)
        {
            var signDict = dict.OrderBy(d => d.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            string keystring = string.Join(":", signDict.Keys);
            string valuestring = string.Join(":", signDict.Values.Select(EscapeVal));

            return string.Format("{0}:{1}", keystring, valuestring);
        }


        public string GetDataToSign(Dictionary<String, String> postParameters)
        {
            var parts = new List<string>();

            foreach (var postParameter in postParameters)
            {
                parts.Add(EscapeVal(postParameter.Key));
            }

            foreach (var postParameter in postParameters)
            {
                parts.Add(EscapeVal(postParameter.Value));
            }

            return String.Join("", parts);
        }
        
        public string GetDataToSign(NotificationRequestItem notificationRequestItem)
        {
            var amount = notificationRequestItem.Amount;
            var signedDataList = new List<string>
            {
                notificationRequestItem.PspReference,
                notificationRequestItem.OriginalReference,
                notificationRequestItem.MerchantAccountCode,
                notificationRequestItem.MerchantReference,
                Convert.ToString(amount.Value),
                amount.Currency,
                notificationRequestItem.EventCode,
                notificationRequestItem.Success.ToString().ToLower()
            };
            return String.Join(":", signedDataList);
        }

        public bool IsValidHmac(NotificationRequestItem notificationRequestItem, string key)
        {
            string expectedSign = CalculateHmac(notificationRequestItem, key);
            string merchantSign = notificationRequestItem.AdditionalData[Constants.AdditionalData.HmacSignature];
            return string.Equals(expectedSign, merchantSign);
        }

        private string EscapeVal(string val)
        {
            if (val == null)
            {
                return string.Empty;
            }

            val = val.Replace(@"\", @"\\");
            val = val.Replace(":", @"\:");
            return val;
        }
    }
}

