using System.Linq;
using System.Text.RegularExpressions;

namespace Adyen.Security
{
    public static class TerminalCommonNameValidator
    {
        private static readonly string _environmentWildcard = "{environment}";
        private static readonly string _terminalApiCnRegex = "[a-zA-Z0-9]{3,}-[0-9]{9,15}\\." + _environmentWildcard + "\\.terminal\\.adyen\\.com";
        private static readonly string _terminalApiLegacy = "legacy-terminal-certificate." + _environmentWildcard + ".terminal.adyen.com";

        public static bool ValidateCertificate(string certificateSubject, Model.Environment environment)
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
