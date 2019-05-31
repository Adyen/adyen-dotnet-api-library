using System;

namespace Adyen.EcommLibrary.Util
{
    public class Util
    {
        public static string CalculateSessionValidity()
        {
            //+1day
            var dateTime = DateTime.Now.AddDays(1);
            return string.Format("{0:s}", dateTime);
        }
    }
}