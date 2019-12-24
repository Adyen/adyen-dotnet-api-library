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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System.Linq;
using System.Text.RegularExpressions;

namespace Adyen.Security
{
    public static class TerminalCommonNameValidator
    {
        private static readonly string _environmentWildcard = "{environment}";
        private static string _terminalApiCnRegex = "[a-zA-Z0-9]{4,}-[0-9]{9}\\." + _environmentWildcard + "\\.terminal\\.adyen\\.com";
        private static string _terminalApiLegacy = "legacy-terminal-certificate." + _environmentWildcard + ".terminal.adyen.com";

        public static bool ValidateCertificate(string certificateSubject, Model.Enum.Environment environment)
        {
            var environmentName = environment.ToString().ToLower();
            var regexPatternTerminalSpecificCert = _terminalApiCnRegex.Replace(_environmentWildcard, environmentName);
            var regexPatternLegacyCert = _terminalApiLegacy.Replace(_environmentWildcard, environmentName);
            var subject = certificateSubject.Split(',')
                     .Select(x => x.Split('='))
                     .ToDictionary(x => x[0].Trim(' '), x => x[1]);
            if (subject.ContainsKey("CN"))
            {
                string commonNameValue = subject["CN"];
                if (Regex.Match(commonNameValue, regexPatternTerminalSpecificCert).Success || string.Equals(commonNameValue, regexPatternLegacyCert))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
