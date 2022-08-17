using Adyen.Model.MarketPay;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Account = Adyen.Service.Account;

namespace Adyen.IntegrationTest
{
    [TestClass]
    public class MarketpayAccountTest
    {
        private Client _client;
        private Account _account;

        [TestInitialize]
        public void Init()
        {
            _client = new Client(ClientConstants.CaUsername, ClientConstants.CaPassword, Model.Enum.Environment.Test);
            _account = new Account(_client);
        }

        /// <summary>
        /// Test /createAccount API call/
        /// Test /closeAccount API call/
        /// </summary>
        [TestMethod]
        public void TestCreateCloseAccountSuccess()
        {
            var createAccountRequest = new CreateAccountRequest(accountHolderCode: GenerateUniqueAccountHolder());
            var createAccountResponse = _account.CreateAccount(createAccountRequest);
            Assert.IsNotNull(createAccountResponse.PspReference);
            Assert.IsNotNull(createAccountResponse.AccountCode);
            Assert.IsNotNull(createAccountResponse.AccountHolderCode);

            var closeAccountRequest = new CloseAccountRequest(accountCode: createAccountResponse.AccountCode);
            var closeAccountResponse = _account.CloseAccount(closeAccountRequest);
            Assert.IsNotNull(closeAccountResponse);
            Assert.IsNotNull(closeAccountResponse.PspReference);
        }

        /// <summary>
        /// Test /createAccount API call/
        /// Test /closeAccount API call/
        /// </summary>
        [TestMethod]
        public void TestCreateAccountHolderSuccess()
        {
            var accountHolderResponse = GetCreateAccountHolderResponse();
            Assert.IsNotNull(accountHolderResponse.PspReference);
            Assert.IsNotNull(accountHolderResponse.AccountCode);
            Assert.IsNotNull(accountHolderResponse.AccountHolderCode);
            var closeAccountRequest =
                new CloseAccountHolderRequest(accountHolderCode: accountHolderResponse.AccountHolderCode);
            var closeAccountResponse = _account.CloseAccountHolder(closeAccountRequest);
            Assert.IsNotNull(closeAccountResponse);
            Assert.IsNotNull(closeAccountResponse.PspReference);
        }

        /// <summary>
        /// Test /createAccount API call/
        /// Test /closeAccount API call/
        /// </summary>
        [TestMethod]
        public void TestCreateAccountHolderDeleteBankAccountSuccess()
        {
            var accountHolderResponse = GetCreateAccountHolderResponse();
            Assert.IsNotNull(accountHolderResponse.PspReference);
            Assert.IsNotNull(accountHolderResponse.AccountCode);
            Assert.IsNotNull(accountHolderResponse.AccountHolderCode);

            var bankAccountUID = accountHolderResponse.AccountHolderDetails.BankAccountDetails[0].BankAccountUUID;
            var bankAccountUIDs = new List<string> {{bankAccountUID}};
            var deletePayoutMethodRequest = new DeleteBankAccountRequest(
                accountHolderCode: accountHolderResponse.AccountHolderCode, bankAccountUUIDs: bankAccountUIDs);
            var genericResponse = _account.DeleteBankAccount(deletePayoutMethodRequest);
            Assert.IsNotNull(genericResponse.PspReference);

            var closeAccountRequest =
                new CloseAccountHolderRequest(accountHolderCode: accountHolderResponse.AccountHolderCode);
            var closeAccountResponse = _account.CloseAccountHolder(closeAccountRequest);
            Assert.IsNotNull(closeAccountResponse);
            Assert.IsNotNull(closeAccountResponse.PspReference);
        }

        /// <summary>
        /// Test /getAccountHolder API call/
        /// </summary>
        [TestMethod]
        public void TestGetAccountHolders()
        {
            var getAccountHolderRequest = new GetAccountHolderRequest(accountHolderCode: "TestAccountHolder01");
            var getAccountHolderResponse = _account.GetAccountHolder(getAccountHolderRequest);
            Assert.IsNotNull(getAccountHolderResponse.PspReference);
            Assert.IsNotNull(getAccountHolderResponse.AccountHolderCode);
            Assert.IsNotNull(getAccountHolderResponse.AccountHolderDetails.Email);
        }

        /// <summary>
        /// Test /getUploadedDocuments API call/
        /// </summary>
        [TestMethod]
        public void TestGetUploadDocumentsSuccess()
        {
            var getUploadDocumentsRequest = new GetUploadedDocumentsRequest(accountHolderCode: "TestAccountHolder01");
            var getUploadDocumentsResponse = _account.GetUploadedDocuments(getUploadDocumentsRequest);
            Assert.IsNotNull(getUploadDocumentsResponse.PspReference);
        }

        /// <summary>
        /// Test /updateAccountHolder API call
        /// </summary>
        [TestMethod]
        public void TestUpdateAccountHolderSuccess()
        {
            var createAccountHolderResponse = GetCreateAccountHolderResponse();
            Thread.Sleep(3000);
            var accountHolderDetails = createAccountHolderResponse.AccountHolderDetails;
            var updateAccountHolderRequest = new UpdateAccountHolderRequest(
                accountHolderCode: createAccountHolderResponse.AccountHolderCode,
                accountHolderDetails: accountHolderDetails);
            updateAccountHolderRequest.LegalEntity = UpdateAccountHolderRequest.LegalEntityEnum.Business;
            var updateAccountHolderResponse = _account.UpdateAccountHolder(updateAccountHolderRequest);
            Assert.IsNotNull(updateAccountHolderResponse.PspReference);
            Thread.Sleep(3000);
            var closeAccountRequest =
                new CloseAccountHolderRequest(accountHolderCode: createAccountHolderResponse.AccountHolderCode);
            var closeAccountResponse = _account.CloseAccountHolder(closeAccountRequest);
        }


        /// <summary>
        /// Test /updateAccountHolderState API call
        /// </summary>
        [TestMethod]
        public void TestUpdateAccountHolderStateSuccess()
        {
            var createAccountHolderResponse = GetCreateAccountHolderResponse();
            Thread.Sleep(3000);
            var updateAccountHolderStateRequest = new UpdateAccountHolderStateRequest(
                accountHolderCode: createAccountHolderResponse.AccountHolderCode, reason: "test reason payout",
                stateType: UpdateAccountHolderStateRequest.StateTypeEnum.Payout, disable: false);
            var updateAccountHolderStateResponse = _account.UpdateAccountHolderState(updateAccountHolderStateRequest);
            Assert.IsNotNull(updateAccountHolderStateResponse.PspReference);
            Assert.IsNotNull(updateAccountHolderStateResponse.AccountHolderCode);
            Thread.Sleep(3000);
            var closeAccountRequest =
                new CloseAccountHolderRequest(accountHolderCode: createAccountHolderResponse.AccountHolderCode);
            var closeAccountResponse = _account.CloseAccountHolder(closeAccountRequest);
        }

        /// <summary>
        /// Test /deletePayoutMethods API call
        /// </summary>
        [TestMethod]
        public void TestDeletePayoutMethodsSuccess()
        {
            var createAccountHolderResponse = GetCreateAccountHolderResponse();
            Thread.Sleep(3000);
            var deletePayoutMethodRequest = new DeletePayoutMethodRequest(
                accountHolderCode: createAccountHolderResponse.AccountHolderCode,
                payoutMethodCodes: new List<string>() {"6026a526-7863-f943-d8ca-f8fadc47473e"});
            var genericResponse = _account.DeletePayoutMethods(deletePayoutMethodRequest);
            Assert.IsNotNull(genericResponse.PspReference);
            Thread.Sleep(3000);
            var closeAccountRequest =
                new CloseAccountHolderRequest(accountHolderCode: createAccountHolderResponse.AccountHolderCode);
            var closeAccountResponse = _account.CloseAccountHolder(closeAccountRequest);
        }

        /// <summary>
        /// Test /deletePayoutMethods API call
        /// </summary>
        [TestMethod]
        public void TestDeleteShareHolderListsSuccess()
        {
            var createAccountHolderResponse = GetCreateAccountHolderResponse();
            var shareHolderCode = createAccountHolderResponse.Verification.Shareholders[0].ShareholderCode;
            var deleteShareholderRequest = new DeleteShareholderRequest(
                accountHolderCode: createAccountHolderResponse.AccountHolderCode,
                shareholderCodes: new List<string> {{shareHolderCode}});
            var genericResponse = _account.DeleteShareHolder(deleteShareholderRequest);
            Assert.IsNotNull(genericResponse.PspReference);
            var closeAccountRequest =
                new CloseAccountHolderRequest(accountHolderCode: createAccountHolderResponse.AccountHolderCode);
            var closeAccountResponse = _account.CloseAccountHolder(closeAccountRequest);
        }

        /// <summary>
        /// Test /checkoutAccountHolder API call
        /// </summary>
        [TestMethod]
        public void TestCheckAccountHolderSuccess()
        {
            var createAccountHolderResponse = GetCreateAccountHolderResponse();
            Thread.Sleep(5000);
            Assert.IsNotNull(createAccountHolderResponse.PspReference);
            Assert.IsNotNull(createAccountHolderResponse.AccountCode);
            Assert.IsNotNull(createAccountHolderResponse.AccountHolderCode);
            var performVerificationRequest = new PerformVerificationRequest(
                accountHolderCode: createAccountHolderResponse.AccountHolderCode,
                accountStateType: PerformVerificationRequest.AccountStateTypeEnum.Processing, tier: 1);
            var genericResponse = _account.CheckAccountholder(performVerificationRequest);
            Assert.IsNotNull(genericResponse.PspReference);
            var closeAccountRequest =
                new CloseAccountHolderRequest(accountHolderCode: createAccountHolderResponse.AccountHolderCode);
            var closeAccountResponse = _account.CloseAccountHolder(closeAccountRequest);
            Assert.IsNotNull(closeAccountResponse);
            Assert.IsNotNull(closeAccountResponse.PspReference);
        }

        /// <summary>
        /// Test /suspendAccountHolder API call/
        /// </summary>
        [TestMethod]
        public void TestSuspendAccountHolderSuccess()
        {
            var createAccountHolderResponse = GetCreateAccountHolderResponse();
            Thread.Sleep(5000);
            var suspendAccountHolderRequest =
                new SuspendAccountHolderRequest(accountHolderCode: createAccountHolderResponse.AccountHolderCode);
            var suspendAccountHolderResponse = _account.SuspendAccountHolder(suspendAccountHolderRequest);
            Assert.IsNotNull(suspendAccountHolderResponse.PspReference);
            Thread.Sleep(3000);
            var closeAccountRequest =
                new CloseAccountHolderRequest(accountHolderCode: createAccountHolderResponse.AccountHolderCode);
            var closeAccountResponse = _account.CloseAccountHolder(closeAccountRequest);
        }

        private CreateAccountHolderResponse GetCreateAccountHolderResponse()
        {
            var accountHolderCode = GenerateUniqueAccountHolder();
            var viasAddress = new ViasAddress(country: "NL");
            var bankAccountsDetails = new List<BankAccountDetail>
            {
                {
                    new BankAccountDetail(bankName: "testBank", iban: "NL64INGB0004053953", countryCode: "NL",
                        currencyCode: "EUR", ownerCountryCode: "NL", ownerCity: "Amsterdam",
                        ownerDateOfBirth: "1990-1-1",
                        ownerHouseNumberOrName: "9", ownerName: "John Smoith", ownerNationality: "NL",
                        ownerPostalCode: "1010js", ownerStreet: "Delfandplein", primaryAccount: true)
                }
            };
            var name = new ViasName(firstName: "John", lastName: "Smith", gender: ViasName.GenderEnum.MALE);
            var phone = "+31061111111112";
            var personalData = new ViasPersonalData(nationality: "NL", dateOfBirth: "1980-01-01");
            var shareholderContract = new List<ShareholderContact>
            {
                {
                    new ShareholderContact(address: viasAddress, email: "test@test.com", name: name,
                        fullPhoneNumber: phone,
                        personalData: personalData)
                },
                {
                    new ShareholderContact(address: viasAddress, email: "test1@test1.com", name: name,
                        fullPhoneNumber: phone, personalData: personalData)
                }
            };
            var businessDetails = new BusinessDetails(doingBusinessAs: "TestBusiness05",
                legalBusinessName: "TestBusiness05", shareholders: shareholderContract, taxId: "NL853416084");
            var accountHolderDetails = new AccountHolderDetails(address: viasAddress,
                bankAccountDetails: bankAccountsDetails, businessDetails: businessDetails, email: "test@test.com",
                webAddress: "http://test.com");
            var createAccountRequest = new CreateAccountHolderRequest(accountHolderCode: accountHolderCode,
                accountHolderDetails: accountHolderDetails);
            createAccountRequest.CreateDefaultAccount = true;

            createAccountRequest.LegalEntity = CreateAccountHolderRequest.LegalEntityEnum.Business;
            return _account.CreateAccountHolder(createAccountRequest);
        }

        private string GenerateUniqueAccountHolder()
        {
            return string.Format("TestAccountHolder" + Guid.NewGuid().ToString().Substring(0, 6));
        }
    }
}