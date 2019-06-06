using System;
using System.IO;

namespace Adyen.Util
{
    public  class Util
    {
        public static string CalculateSessionValidity()
        {
            //+1day
           var dateTime=DateTime.Now.AddDays(1);
           return String.Format("{0:s}", dateTime);
           
        }
    }
}
