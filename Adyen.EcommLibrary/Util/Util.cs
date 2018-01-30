using System;
using System.IO;

namespace Adyen.EcommLibrary.Util
{
    public  class Util
    {
        public static string ToIndentedString(object obj)
        {
            if (obj == null)
            {
                return "null";
            }
            return obj.ToString().Replace("\n", "\n    ");
        }

        public static string CalculateSessionValidity()
        {
            //+1day
           var dateTime=DateTime.Now.AddDays(1);
           return String.Format("{0:s}", dateTime);
           
        }
    }
}
