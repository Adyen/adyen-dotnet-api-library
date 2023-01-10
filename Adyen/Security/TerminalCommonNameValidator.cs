#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion

using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Adyen.Security
{
    public static class TerminalCommonNameValidator
    {
        private static readonly string _environmentWildcard = "{environment}";
        private static string _terminalApiCnRegex = "[a-zA-Z0-9]{3,}-[0-9]{9,15}\\." + _environmentWildcard + "\\.terminal\\.adyen\\.com";
        private static string _terminalApiLegacy = "legacy-terminal-certificate." + _environmentWildcard + ".terminal.adyen.com";

        public static bool ValidateCertificate(string certificateSubject, Model.Enum.Environment environment)
        {
            string environmentName = environment.ToString().ToLower();
            string regexPatternTerminalSpecificCert = _terminalApiCnRegex.Replace(_environmentWildcard, environmentName);
            string regexPatternLegacyCert = _terminalApiLegacy.Replace(_environmentWildcard, environmentName);
            Dictionary<string, string> subject = certificateSubject.Split(',')
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
