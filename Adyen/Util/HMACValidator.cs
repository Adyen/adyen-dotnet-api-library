﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Adyen.Util
{
    public class HmacValidator
    {
        // Computes the Base64 encoded signature using the HMAC algorithm with the HMACSHA256 hashing function.
        public string CalculateHmac( string signingstring,string hmacKey)
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

