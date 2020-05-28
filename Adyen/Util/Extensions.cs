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

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Util
{
    internal static class Extensions
    {
        public static string ToClassDefinitionString(this object o)
        {
            try
            {
                var t = o.GetType();

                var propertyString = new StringBuilder().AppendLine($"class {o.GetType().Name} {{");

                foreach (var prop in t.GetProperties())
                {
                    var propertyValue = prop.GetValue(o, null);

                    propertyString.Append("\t")
                        .AppendLine(propertyValue != null
                            ? $"{prop.Name}: {propertyValue}".ToIndentedString()
                            : $"{prop.Name}: null");
                }

                propertyString.AppendLine("}");

                return propertyString.ToString();
            }
            catch
            {
                return o.ToString();
            }
        }
        
        public static string ToIndentedString(this object o)
        {
            return o == null ? "null"
                             : o.ToString().Replace("\n", "\n\t\t\t");
        }

        /// <summary>
        /// Converts collections keyvaluepair to string
        /// </summary>
        /// <param name="dictionary">Collection convert to string</param>
        /// <returns>string</returns>
        public static string ToCollectionsString<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
        {
            return "{" + string.Join(",", dictionary.Select(kv => kv.Key + "=" + kv.Value).ToArray()) + "}";
        }

        /// <summary>
        /// Converts list of strings to string with commas
        /// </summary>
        /// <param name="list"></param>
        /// <returns>string</returns>
        public static string ToListString(this List<string> list)
        {
            if (list != null && list.Any())
            {
                return string.Join(" ", list.ToArray());
            }
            return "";
        }

        /// <summary>
        /// Converts a list of objects to string. Loops in the list and  invoke the ToString implementation of each object
        /// </summary>
        /// <typeparam name="T">Generic type of object</typeparam>
        /// <param name="itemlist">List of object</param>
        /// <returns>string</returns>
        public static string ObjectListToString<T>(this List<T> itemlist)
        {
            if (itemlist != null && itemlist.Any())
            {
               return itemlist.Aggregate("\n\t{ ", (current, item) => current + " " + item.ToString() + "\n") + " }";
            }
            return "";
        }
    }
}
