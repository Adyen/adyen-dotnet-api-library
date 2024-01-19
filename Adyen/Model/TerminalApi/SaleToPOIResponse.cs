using System.Text;
using Adyen.Model.Terminal;
using Newtonsoft.Json;

namespace Adyen.Model.TerminalApi
{
    public class SaleToPOIResponse 
    {
        private const string JsonPropertyMessageHeader = "MessageHeader";
        private const string JsonPropertyBalanceInquiryResponse = "BalanceInquiryResponse";
        private const string JsonPropertyCardInquisitionResponse = "CardAcquisitionResponse";
        private const string JsonPropertyAdminResponse = "AdminResponse";
        private const string JsonPropertyDiagnosisResponse = "DiagnosisResponse";
        private const string JsonPropertyDisplayResponse = "DisplayResponse";
        private const string JsonPropertyEnableServiceResponse = "EnableServiceResponse";
        private const string JsonPropertyEventNotification = "EventNotification";
        private const string JsonPropertyGetTotalsResponse = "GetTotalsResponse";
        private const string JsonPropertyInputResponse = "InputResponse";
        private const string JsonPropertyInputUpdate = "InputUpdate";
        private const string JsonPropertyLoginResponse = "LoginResponse";
        private const string JsonPropertyLogoutResponse = "LogoutResponse";
        private const string JsonPropertyLoyaltyResponse = "LoyaltyResponse";
        private const string JsonPropertyPaymentResponse = "PaymentResponse";
        private const string JsonPropertyPrintResponse = "PrintResponse";
        private const string JsonPropertyCardReaderApduResponse = "CardReaderAPDUResponse";
        private const string JsonPropertyReconciliationResponse = "ReconciliationResponse";
        private const string JsonPropertyReversalResponse = "ReversalResponse";
        private const string JsonPropertyStoredValueResponse = "StoredValueResponse";
        private const string JsonPropertyTransactionStatusResponse = "TransactionStatusResponse";
        private const string JSON_PROPERTY_SECURITY_TRAILER = "SecurityTrailer";

        [JsonProperty(JsonPropertyMessageHeader)]
        public MessageHeader MessageHeader { get; set; }

        [JsonProperty(JsonPropertyBalanceInquiryResponse)]
        public BalanceInquiryResponse BalanceInquiryResponse { get; set; }

        [JsonProperty(JsonPropertyCardInquisitionResponse)]
        public CardAcquisitionResponse CardAcquisitionResponse { get; set; }

        [JsonProperty(JsonPropertyAdminResponse)]
        public AdminResponse AdminResponse { get; set; }

        [JsonProperty(JsonPropertyDiagnosisResponse)]
        public DiagnosisResponse DiagnosisResponse { get; set; }

        [JsonProperty(JsonPropertyDisplayResponse)]
        public DisplayResponse DisplayResponse { get; set; }

        [JsonProperty(JsonPropertyEnableServiceResponse)]
        public EnableServiceResponse EnableServiceResponse { get; set; }

        [JsonProperty(JsonPropertyEventNotification)]
        public EventNotification EventNotification { get; set; }

        [JsonProperty(JsonPropertyGetTotalsResponse)]
        public GetTotalsResponse GetTotalsResponse { get; set; }

        [JsonProperty(JsonPropertyInputResponse)]
        public InputResponse InputResponse { get; set; }

        [JsonProperty(JsonPropertyInputUpdate)]
        public InputUpdate InputUpdate { get; set; }

        [JsonProperty(JsonPropertyLoginResponse)]
        public LoginResponse LoginResponse { get; set; }

        [JsonProperty(JsonPropertyLogoutResponse)]
        public LogoutResponse LogoutResponse { get; set; }

        [JsonProperty(JsonPropertyLoyaltyResponse)]
        public LoyaltyResponse LoyaltyResponse { get; set; }

        [JsonProperty(JsonPropertyPaymentResponse)]
        public PaymentResponse PaymentResponse { get; set; }

        [JsonProperty(JsonPropertyPrintResponse)]
        public PrintResponse PrintResponse { get; set; }

        [JsonProperty(JsonPropertyCardReaderApduResponse)]
        public CardReaderAPDUResponse CardReaderAPDUResponse { get; set; }

        [JsonProperty(JsonPropertyReconciliationResponse)]
        public ReconciliationResponse ReconciliationResponse { get; set; }

        [JsonProperty(JsonPropertyReversalResponse)]
        public ReversalResponse ReversalResponse { get; set; }

        [JsonProperty(JsonPropertyStoredValueResponse)]
        public StoredValueResponse StoredValueResponse { get; set; }

        [JsonProperty(JsonPropertyTransactionStatusResponse)]
        public TransactionStatusResponse TransactionStatusResponse { get; set; }

        [JsonProperty(JSON_PROPERTY_SECURITY_TRAILER)]
        public SecurityTrailer SecurityTrailer { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SaleToPOIResponse {\n");
            try
            {
                sb.Append("    saleToPOIResponse: ").Append(JsonConvert.SerializeObject(this, Formatting.Indented)).Append("\n");
            }
            catch (JsonException e)
            {
                sb.Append("Error: Could not serialize saleToPOIResponse");
            }
            sb.Append("}");
            return sb.ToString();
        }

        public static SaleToPOIResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<SaleToPOIResponse>(jsonString);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}