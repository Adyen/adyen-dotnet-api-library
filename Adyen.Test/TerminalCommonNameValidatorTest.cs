using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class TerminalCommonNameValidatorTest
    {
        [TestMethod]
        public void TerminalCertificateCommonNameTest()
        {
            foreach (var terminalCNValidationParameter in GetTerminalCNValidationParameters())
            {
                bool result = Security.TerminalCommonNameValidator.ValidateCertificate(terminalCNValidationParameter.CommonName, terminalCNValidationParameter.Environment);
                Assert.AreEqual(result, terminalCNValidationParameter.TestSuccess);
            }
        }

        private List<TerminalCNValidationParameters> GetTerminalCNValidationParameters()
        {
            return new List<TerminalCNValidationParameters>
            {
                        // Valid CNs and environment
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=legacy-terminal-certificate.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, true ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=legacy-terminal-certificate.live.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Live, true ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=P400-123456789.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, true ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=P400-123456789.live.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Live, true ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=S1E-000150123456789.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, true ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=S1E-000150123456789.live.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Live, true ),
                       // Wrong environment
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=legacy-terminal-certificate.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Live, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=P400-123456789.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Live, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=legacy-terminal-certificate.live.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=P400-123456789.live.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=S1E-000150123456789.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Live, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=S1E-000150123456789.live.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                       
                        // Invalid CN
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=wrong-terminal-certificate.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=legacyy-terminal-certificate.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=legacy-terminaal-certificate.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=legacy-terminal-certificatee.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=P400.123456789.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=P400123456789.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=P4-123456789.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=P400-ABC.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=P400-123.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=P400-.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=-123.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=www.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=ANY, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=S1E-0001501234567891.test.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false ),
                        new TerminalCNValidationParameters  ( "EMAILADDRESS=mock@adyen.com, CN=S1E-0001501234567891.live.terminal.adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Live, false ),
                     
                        // Missing CN
                        new TerminalCNValidationParameters( "EMAILADDRESS=mock@adyen.com, OU=Mock, O=Mock, L=Mock, ST=MO, C=MO", Model.Environment.Test, false )
            };
        }
    }

    internal class TerminalCNValidationParameters
    {
        public string CommonName { get; set; }
        public bool TestSuccess { get; set; }
        public Model.Environment Environment { get; set; }

        public TerminalCNValidationParameters(string commonName, Model.Environment environment, bool testSuccess)
        {
            CommonName = commonName;
            TestSuccess = testSuccess;
            Environment = environment;
        }
    }
}
