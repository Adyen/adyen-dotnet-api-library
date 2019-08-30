#region Licence
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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System.Text.RegularExpressions;

namespace Adyen.Security
{
    public static class TerminalCommonNameValidator
    {
        private static readonly string _enviromentWildcard = "{enviroment}";
        private static string _terminalApiCnRegex = "[a-zA-Z0-9]{4,}-[0-9]{9}\\." + _enviromentWildcard + "\\.terminal\\.adyen\\.com";
        private static string _terminalApiLegacy = "legacy-terminal-certificate." + _enviromentWildcard + ".terminal.adyen.com";

        public static bool ValidateCertificate(string certificateCommonName, Model.Enum.Environment environment)
        {
            var enviromentName = environment.ToString().ToLower();
            var patternRegex = "(?:^|,\\s?)(?:(?<name>[A-Z]+)=(?<val>\"(?:[^\"]|\"\")+\"|[^,]+))+";
            var regex = new Regex(patternRegex);
            var groupsName = regex.GetGroupNames();
            var matches = regex.Matches(certificateCommonName);

            foreach (Match match in matches)
            {
                string groupName = match.Groups["name"].Value;
                if ("CN".Equals(groupName))
                {
                    var commonNameValue = match.Groups["val"].Value;
                    var regexPattern = _terminalApiCnRegex.Replace(_enviromentWildcard, environment.ToString().ToLower());
                    var legacyCert = _terminalApiLegacy.Replace(_enviromentWildcard, environment.ToString().ToLower());
                    if (Regex.Match(commonNameValue, regexPattern).Success || string.Equals(commonNameValue, legacyCert))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
