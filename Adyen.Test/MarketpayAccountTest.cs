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
using Adyen.Model.MarketPay;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Account = Adyen.Service.Account;

namespace Adyen.Test
{
    [TestClass]
    public class MarketpayAccountTest : BaseTest
    {
        // <summary>
        // Test /closeAccount
        // </summary>
        [TestMethod]
        public void TestCloseAccountSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/close-account-success.json");
            var account = new Account(client);
            var closeAccountRequest = new CloseAccountRequest(accountCode: "123456");
            var closeAccountResponse = account.CloseAccount(closeAccountRequest);
            Assert.IsNotNull(closeAccountResponse);
            Assert.AreEqual(closeAccountResponse.PspReference, "8515810799236011");
            Assert.AreEqual(closeAccountResponse.Status,CloseAccountResponse.StatusEnum.Closed);
        }

        /// <summary>
        /// Test /closeAccountHolder API call/
        /// </summary>
        [TestMethod]
        public void TestCloseAccountHolderSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/close-account-holder-success.json");
            var account = new Account(client);
            var closeAccountHolderRequest = new CloseAccountHolderRequest(accountHolderCode: "123456");
            var closeAccountHolderResponse = account.CloseAccountHolder(closeAccountHolderRequest);
            Assert.IsNotNull(closeAccountHolderResponse);
            Assert.AreEqual(closeAccountHolderResponse.PspReference, "8515810799236011");
            Assert.IsNotNull(closeAccountHolderResponse);
            Assert.AreEqual(closeAccountHolderResponse.AccountHolderStatus.Status, AccountHolderStatus.StatusEnum.Closed);
            Assert.AreEqual(closeAccountHolderResponse.AccountHolderStatus.ProcessingState.ProcessedFrom, new Amount("USD", 0));
            Assert.AreEqual(closeAccountHolderResponse.AccountHolderStatus.ProcessingState.ProcessedTo, new Amount("USD", 0));
            Assert.AreEqual(closeAccountHolderResponse.AccountHolderStatus.PayoutState.AllowPayout, true);
            Assert.AreEqual(closeAccountHolderResponse.AccountHolderStatus.PayoutState.Disabled, false);
            Assert.AreEqual(closeAccountHolderResponse.AccountHolderStatus.ProcessingState.TierNumber, 0);
            Assert.AreEqual(closeAccountHolderResponse.AccountHolderStatus.PayoutState.TierNumber, 0);
        }

        /// <summary>
        /// Test /createAccount API call/
        /// </summary>
        [TestMethod]
        public void TestCreateAccountSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/create-account-success.json");
            var account = new Account(client);
            var createAccountRequest = new CreateAccountRequest(accountHolderCode: "123456");
            var createAccountResponse = account.CreateAccount(createAccountRequest);
            Assert.AreEqual(createAccountResponse.PspReference, "9914913130220156");
            Assert.AreEqual(createAccountResponse.Status, CreateAccountResponse.StatusEnum.Active);
            Assert.AreEqual(createAccountResponse.AccountHolderCode, "TestAccountHolder5691");
            Assert.AreEqual(createAccountResponse.AccountCode, "195920946");
        }

        /// <summary>
        /// Test /createAccountHolder API call/
        /// </summary>
        [TestMethod]
        public void TestCreateAccountHolderSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/create-account-holder-success.json");
            var account = new Account(client);
            var createAccountHolderRequest = new CreateAccountHolderRequest(accountHolderCode: "123456", accountHolderDetails: new AccountHolderDetails(email: "test@test.com", fullPhoneNumber: "123456789", webAddress: "webaddress"));
            var createAccountHolderResponse = account.CreateAccountHolder(createAccountHolderRequest);
            Assert.AreEqual(createAccountHolderResponse.PspReference, "8815810875863517");
            Assert.AreEqual(createAccountHolderResponse.AccountCode, "8815810875863525");
            Assert.AreEqual(createAccountHolderResponse.AccountHolderCode, "97112729718522222");
            Assert.AreEqual(createAccountHolderResponse.AccountHolderDetails.Address.Country, "US");
            Assert.AreEqual(createAccountHolderResponse.AccountHolderDetails.IndividualDetails.Name.FirstName, "John");
            Assert.AreEqual(createAccountHolderResponse.AccountHolderDetails.IndividualDetails.Name.Gender, ViasName.GenderEnum.MALE);
            Assert.AreEqual(createAccountHolderResponse.AccountHolderDetails.IndividualDetails.Name.LastName, "Smith");
            Assert.AreEqual(createAccountHolderResponse.AccountHolderStatus.Status,
                AccountHolderStatus.StatusEnum.Active);
            Assert.AreEqual(createAccountHolderResponse.LegalEntity, CreateAccountHolderResponse.LegalEntityEnum.Individual);
            Assert.AreEqual(createAccountHolderResponse.AccountHolderStatus.Status,
                AccountHolderStatus.StatusEnum.Active);
            Assert.AreEqual(createAccountHolderResponse.AccountHolderStatus.PayoutState.AllowPayout, false);
            Assert.AreEqual(createAccountHolderResponse.AccountHolderStatus.PayoutState.Disabled, false);
            Assert.AreEqual(createAccountHolderResponse.AccountHolderStatus.PayoutState.Disabled, false);
            Assert.IsNotNull(createAccountHolderResponse.Verification.AccountHolder.Checks);
        }

        /// <summary>
        /// Test /createAccountHolder API call/
        /// </summary>
        [TestMethod]
        public void TestCreateAccountHolderError()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/create-account-holder-error-invalid-fields.json");
            var account = new Account(client);
            var createAccountHolderRequest = new CreateAccountHolderRequest(accountHolderCode: "123456", accountHolderDetails: new AccountHolderDetails(email: "test@test.com", fullPhoneNumber: "123456789", webAddress: "webaddress"));
            var createAccountHolderResponse = account.CreateAccountHolder(createAccountHolderRequest);
            Assert.AreEqual(createAccountHolderResponse.PspReference, "8815813233102537");
            Assert.IsNotNull(createAccountHolderResponse.InvalidFields);
            Assert.AreEqual(createAccountHolderResponse.InvalidFields[0].ErrorCode, 28);
            Assert.AreEqual(createAccountHolderResponse.InvalidFields[0].FieldType.Field, "accountHolderCode");
            Assert.AreEqual(createAccountHolderResponse.InvalidFields[0].FieldType.FieldName, FieldType.FieldNameEnum.AccountHolderCode);
        }

        /// <summary>
        /// Test /deleteBankAccounts API call/
        /// </summary>
        [TestMethod]
        public void TestDeleteBankAccountSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/delete-bank-account-success.json");
            var account = new Account(client);
            var deleteAccountSuccessRequest = new DeleteBankAccountRequest(accountHolderCode: "123456", bankAccountUUIDs: new List<string>());
            var deleteAccountSuccessResponse = account.DeleteBankAccount(deleteAccountSuccessRequest);
            Assert.AreEqual(deleteAccountSuccessResponse.PspReference, "9914694372670551");
        }

        /// <summary>
        /// Test /deleteShareholders API call/
        /// </summary>
        [TestMethod]
        public void TestDeleteShareholderSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/delete-shareholder-success.json");
            var account = new Account(client);
            var deleteShareholderRequest = new DeleteShareholderRequest(accountHolderCode: "123456", shareholderCodes: new List<string>());
            var deleteShareholderResponse = account.DeleteShareHolder(deleteShareholderRequest);
            Assert.AreEqual(deleteShareholderResponse.PspReference, "9914694372990637");
        }

        /// <summary>
        /// Test /getAccountHolder API call/
        /// </summary>
        [TestMethod]
        public void TestGetAccountHolders()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/get-account-holder-success.json");
            var account = new Account(client);
            var getAccountHolderRequest = new GetAccountHolderRequest(accountHolderCode: "123456");
            var getAccountHolderResponse = account.GetAccountHolder(getAccountHolderRequest);
            Assert.AreEqual(getAccountHolderResponse.PspReference, "8515813355311349");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderCode, "8515843355311359");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.Email, "test@test.com");
            Assert.AreEqual(getAccountHolderResponse.LegalEntity, GetAccountHolderResponse.LegalEntityEnum.Individual);
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[0].BankAccountName, "MarketPlace Account");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[0].BankAccountUUID, "6026a526-7863-aaaa-dddd-f8fadc47473e");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[0].BankBicSwift, "TESTNL01");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[0].BankCity, "bankCity");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[0].BankName, "bankName");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[0].CountryCode, "NL");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[1].BankAccountName, "MarketPlace Account");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[1].BankAccountUUID, "ab3aeec6-a679-aaaa-dddd-88bd936a6a33");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[1].BankBicSwift, "TESTNL01");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[1].BankCity, "bankCity");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[1].BankName, "bankName");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[1].CountryCode, "NL");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[2].BankAccountName, "MarketPlace Account");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[2].BankAccountUUID, "b301ca68-e227-aaaa-dddd-9bc1f94fc0f0");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[2].BankBicSwift, "TESTNL01");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[2].BankCity, "bankCity");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[2].BankName, "bankName");
            Assert.AreEqual(getAccountHolderResponse.AccountHolderDetails.BankAccountDetails[2].CountryCode, "NL");
            Assert.AreEqual(getAccountHolderResponse.Accounts[0].AccountCode, "115548513");
            Assert.AreEqual(getAccountHolderResponse.Accounts[1].AccountCode, "158653516");
            Assert.AreEqual(getAccountHolderResponse.Accounts[2].AccountCode, "162994490");
        }

        /// <summary>
        /// Test /getUploadedDocuments API call/
        /// </summary>
        [TestMethod]
        public void TestGetUploadedDocumentsSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/get-uploaded-documents-success.json");
            var account = new Account(client);
            var getUploadedDocumentsRequest = new GetUploadedDocumentsRequest(accountHolderCode: "123456");
            var getUploadedDocumentsResponse = account.GetUploadedDocuments(getUploadedDocumentsRequest);
            Assert.AreEqual(getUploadedDocumentsResponse.PspReference, "9914694369860322");
            Assert.AreEqual(getUploadedDocumentsResponse.DocumentDetails[0].AccountHolderCode, "TestAccountHolder8031");
            Assert.AreEqual(getUploadedDocumentsResponse.DocumentDetails[0].BankAccountUUID, "EXAMPLE_UUID");
            Assert.AreEqual(getUploadedDocumentsResponse.DocumentDetails[0].Description, "description1");
            Assert.AreEqual(getUploadedDocumentsResponse.DocumentDetails[0].DocumentType, DocumentDetail.DocumentTypeEnum.BANKSTATEMENT);
            Assert.AreEqual(getUploadedDocumentsResponse.DocumentDetails[0].AccountHolderCode, "TestAccountHolder8031");
        }

        /// <summary>
        /// Test /suspendAccountHolder API call/
        /// </summary>
        [TestMethod]
        public void TestSuspendAccountHolderSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/suspend-account-holder-success.json");
            var account = new Account(client);
            var suspendAccountHolderRequest = new SuspendAccountHolderRequest(accountHolderCode: "123456");
            var suspendAccountHolderResponse = account.SuspendAccountHolder(suspendAccountHolderRequest);
            Assert.AreEqual(suspendAccountHolderResponse.PspReference, "8515813523937793");
            Assert.AreEqual(suspendAccountHolderResponse.AccountHolderStatus.Status, AccountHolderStatus.StatusEnum.Suspended);
            Assert.AreEqual(suspendAccountHolderResponse.AccountHolderStatus.PayoutState.AllowPayout, false);
            Assert.AreEqual(suspendAccountHolderResponse.AccountHolderStatus.PayoutState.Disabled, false);
        }

        /// <summary>
        /// Test /unSuspendAccountHolder API call/
        /// </summary>
        [TestMethod]
        public void TestUnSuspendAccountHolderSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/un-suspend-account-holder-success.json");
            var account = new Account(client);
            var unSuspendAccountHolderRequest = new UnSuspendAccountHolderRequest(accountHolderCode: "123456");
            var unSuspendAccountHolderResponse = account.UnSuspendAccountHolder(unSuspendAccountHolderRequest);
            Assert.AreEqual(unSuspendAccountHolderResponse.PspReference, "8815813528286482");
            Assert.AreEqual(unSuspendAccountHolderResponse.AccountHolderStatus.Status, AccountHolderStatus.StatusEnum.Active);
            Assert.AreEqual(unSuspendAccountHolderResponse.AccountHolderStatus.PayoutState.AllowPayout, false);
            Assert.AreEqual(unSuspendAccountHolderResponse.AccountHolderStatus.PayoutState.Disabled, false);
        }

        /// <summary>
        /// Test /updateAccount API call
        /// </summary>
        [TestMethod]
        public void TestUpdateAccountSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/update-account-success.json");
            var account = new Account(client);
            var updateAccountRequest = new UpdateAccountRequest(accountCode: "123456");
            var updateAccountResponse = account.UpdateAccount(updateAccountRequest);
            Assert.AreEqual(updateAccountResponse.PspReference, "9914860311411119");
            Assert.AreEqual(updateAccountResponse.AccountCode, "198360329231");
            Assert.AreEqual(updateAccountResponse.PayoutSchedule.Schedule, PayoutScheduleResponse.ScheduleEnum.WEEKLY);
        }

        /// <summary>
        /// Test /updateAccountHolder API call
        /// </summary>
        [TestMethod]
        public void TestUpdateAccountHolderSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/update-account-holder-success.json");
            var account = new Account(client);
            var updateAccountHolderRequest = new UpdateAccountHolderRequest(accountHolderCode: "123456");
            var updateAccountHolderResponse = account.UpdateAccountHolder(updateAccountHolderRequest);
            Assert.AreEqual(updateAccountHolderResponse.PspReference, "8515813355311349");
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderCode, "8515843355311359");
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderDetails.Email, "test@test.com");
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderDetails.Address, new ViasAddress(country: "US"));
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderDetails.IndividualDetails.Name.FirstName, "John");
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderDetails.IndividualDetails.Name.Gender, ViasName.GenderEnum.MALE);
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderDetails.IndividualDetails.Name.LastName, "Smith");
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderStatus.Status,
                AccountHolderStatus.StatusEnum.Active);
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderStatus.Events.Count, 0);
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderStatus.ProcessingState.Disabled, false);
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderStatus.ProcessingState.ProcessedFrom, new Amount("USD", 0));
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderStatus.ProcessingState.ProcessedTo, new Amount("USD", 9999));
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderStatus.PayoutState.AllowPayout, false);
            Assert.AreEqual(updateAccountHolderResponse.AccountHolderStatus.PayoutState.Disabled, false);
            Assert.IsNotNull(updateAccountHolderResponse.Verification.AccountHolder.Checks);
        }

        /// <summary>
        /// Test /updateAccountHolderState API call
        /// </summary>
        [TestMethod]
        public void TestUpdateAccountHolderStateSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/update-account-holder-state-success.json");
            var account = new Account(client);
            var updateAccountHolderStateRequest = new UpdateAccountHolderStateRequest(accountHolderCode: "123456", reason: "test reason payout", stateType: UpdateAccountHolderStateRequest.StateTypeEnum.Payout, disable: false);
            var updateAccountHolderStateResponse = account.UpdateAccountHolderState(updateAccountHolderStateRequest);
            Assert.AreEqual(updateAccountHolderStateResponse.PspReference, "8515813355311349");
            Assert.AreEqual(updateAccountHolderStateResponse.AccountHolderCode, "8515843355311359");
            Assert.AreEqual(updateAccountHolderStateResponse.AccountHolderStatus.Status,
            AccountHolderStatus.StatusEnum.Active);
            Assert.AreEqual(updateAccountHolderStateResponse.AccountHolderStatus.Events.Count, 0);
            Assert.AreEqual(updateAccountHolderStateResponse.AccountHolderStatus.ProcessingState.Disabled, false);
            Assert.AreEqual(updateAccountHolderStateResponse.AccountHolderStatus.ProcessingState.ProcessedFrom, new Amount("USD", 0));
            Assert.AreEqual(updateAccountHolderStateResponse.AccountHolderStatus.ProcessingState.ProcessedTo, new Amount("USD", 9999));
            Assert.AreEqual(updateAccountHolderStateResponse.AccountHolderStatus.PayoutState.AllowPayout, false);
            Assert.AreEqual(updateAccountHolderStateResponse.AccountHolderStatus.PayoutState.Disabled, true);
            Assert.AreEqual(updateAccountHolderStateResponse.AccountHolderStatus.PayoutState.DisableReason, "test reason payout");
        }

        /// <summary>
        /// Test /uploadDocument API call
        /// </summary>
        [TestMethod]
        public void TestUpdateDocumentSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/upload-document-success.json");
            var account = new Account(client);
            var documentDetail = new DocumentDetail(accountHolderCode: "123456", filename: "stament.pdf", bankAccountUUID: "aaaaaaaa-7863-f943-4e3s-ffffffff", documentType: DocumentDetail.DocumentTypeEnum.BANKSTATEMENT);          
            var uploadDocumentRequest = new UploadDocumentRequest(documentDetail:documentDetail,documentContent:new byte[1000]);
            var uploadDocumentResponse = account.UploadDocument(uploadDocumentRequest);
            Assert.AreEqual(uploadDocumentResponse.PspReference, "8815815165741111");
            Assert.AreEqual(uploadDocumentResponse.AccountHolderCode, "TestAccountHolder8031");
        }

        /// <summary>
        /// Test /deletePayoutMethods API call
        /// </summary>
        [TestMethod]
        public void TestDeletePayoutMethodsSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/delete-payout-methods.json");
            var account = new Account(client);
            var deletePayoutMethodRequest = new DeletePayoutMethodRequest(accountHolderCode: "123456",payoutMethodCodes:new List<string>());
            var genericResponse = account.DeletePayoutMethods(deletePayoutMethodRequest);
            Assert.AreEqual(genericResponse.PspReference, "85158152328111154");
            Assert.AreEqual(genericResponse.ResultCode, "Success");
        }

        /// <summary>
        /// Test /checkoutAccountHolder API call
        /// </summary>
        [TestMethod]
        public void TestCheckAccountHolderSuccess()
        {
            var client = CreateMockTestClientNullRequiredFieldsRequest("Mocks/marketpay/account/check-account-holder-success.json");
            var account = new Account(client);
            var performVerificationRequest = new PerformVerificationRequest(accountHolderCode: "TestAccountHolder8031", accountStateType: PerformVerificationRequest.AccountStateTypeEnum.Processing, tier: 2);
            var genericResponse = account.CheckAccountholder(performVerificationRequest);
            Assert.AreEqual(genericResponse.PspReference, "85158152328111154");
            Assert.AreEqual(genericResponse.ResultCode, "Success");
        }
    }
}
