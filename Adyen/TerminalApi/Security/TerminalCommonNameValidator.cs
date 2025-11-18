using System.Linq;
using System.Text.RegularExpressions;

namespace Adyen.Security
{
    public static class TerminalCommonNameValidator
    {
        private static readonly string EnvironmentWildcard = "{environment}";
        private static readonly string TerminalApiCnRegex = "[a-zA-Z0-9]{3,}-[0-9]{9,15}\\." + EnvironmentWildcard + "\\.terminal\\.adyen\\.com";
        private static readonly string TerminalApiLegacy = "legacy-terminal-certificate." + EnvironmentWildcard + ".terminal.adyen.com";

        public static bool ValidateCertificate(string certificateSubject, Model.Environment environment)
        {
            var environmentName = environment.ToString().ToLower();
            var regexPatternTerminalSpecificCert = TerminalApiCnRegex.Replace(EnvironmentWildcard, environmentName);
            var regexPatternLegacyCert = TerminalApiLegacy.Replace(EnvironmentWildcard, environmentName);
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
