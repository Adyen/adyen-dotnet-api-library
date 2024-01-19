using Adyen.Model.Terminal;
using Newtonsoft.Json;

namespace Adyen.Model.TerminalApi
{
    public class SaleToPOIRequest
    {
        private const string JSON_PROPERTY_MESSAGE_HEADER = "MessageHeader";
        private const string JSON_PROPERTY_ABORT_REQUEST = "AbortRequest";
        private const string JSON_PROPERTY_BALANCE_INQUIRY_REQUEST = "BalanceInquiryRequest";
        private const string JSON_PROPERTY_CARD_ACQUISITION_REQUEST = "CardAcquisitionRequest";
        private const string JSON_PROPERTY_ADMIN_REQUEST = "AdminRequest";
        private const string JSON_PROPERTY_DIAGNOSIS_REQUEST = "DiagnosisRequest";
        private const string JSON_PROPERTY_DISPLAY_REQUEST = "DisplayRequest";
        private const string JSON_PROPERTY_ENABLE_SERVICE_REQUEST = "EnableServiceRequest";
        private const string JSON_PROPERTY_EVENT_NOTIFICATION = "EventNotification";
        private const string JSON_PROPERTY_GET_TOTALS_REQUEST = "GetTotalsRequest";
        private const string JSON_PROPERTY_INPUT_REQUEST = "InputRequest";
        private const string JSON_PROPERTY_LOGIN_REQUEST = "LoginRequest";
        private const string JSON_PROPERTY_LOGOUT_REQUEST = "LogoutRequest";
        private const string JSON_PROPERTY_LOYALTY_REQUEST = "LoyaltyRequest";
        private const string JSON_PROPERTY_PAYMENT_REQUEST = "PaymentRequest";
        private const string JSON_PROPERTY_PRINT_REQUEST = "PrintRequest";
        private const string JSON_PROPERTY_CARD_READER_APDU_REQUEST = "CardReaderAPDURequest";
        private const string JSON_PROPERTY_RECONCILIATION_REQUEST = "ReconciliationRequest";
        private const string JSON_PROPERTY_REVERSAL_REQUEST = "ReversalRequest";
        private const string JSON_PROPERTY_STORED_VALUE_REQUEST = "StoredValueRequest";
        private const string JSON_PROPERTY_TRANSACTION_STATUS_REQUEST = "TransactionStatusRequest";
        private const string JSON_PROPERTY_SECURITY_TRAILER = "SecurityTrailer";

        [JsonProperty(JSON_PROPERTY_MESSAGE_HEADER)]
        public MessageHeader MessageHeader { get; set; }

        [JsonProperty(JSON_PROPERTY_ABORT_REQUEST)]
        public AbortRequest AbortRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_BALANCE_INQUIRY_REQUEST)]
        public BalanceInquiryRequest BalanceInquiryRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_CARD_ACQUISITION_REQUEST)]
        public CardAcquisitionRequest CardAcquisitionRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_ADMIN_REQUEST)]
        public AdminRequest AdminRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_DIAGNOSIS_REQUEST)]
        public DiagnosisRequest DiagnosisRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_DISPLAY_REQUEST)]
        public DisplayRequest DisplayRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_ENABLE_SERVICE_REQUEST)]
        public EnableServiceRequest EnableServiceRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_EVENT_NOTIFICATION)]
        public EventNotification EventNotification { get; set; }

        [JsonProperty(JSON_PROPERTY_GET_TOTALS_REQUEST)]
        public GetTotalsRequest GetTotalsRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_INPUT_REQUEST)]
        public InputRequest InputRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_LOGIN_REQUEST)]
        public LoginRequest LoginRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_LOGOUT_REQUEST)]
        public LogoutRequest LogoutRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_LOYALTY_REQUEST)]
        public LoyaltyRequest LoyaltyRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_PAYMENT_REQUEST)]
        public PaymentRequest PaymentRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_PRINT_REQUEST)]
        public PrintRequest PrintRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_CARD_READER_APDU_REQUEST)]
        public CardReaderAPDURequest CardReaderAPDURequest { get; set; }

        [JsonProperty(JSON_PROPERTY_RECONCILIATION_REQUEST)]
        public ReconciliationRequest ReconciliationRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_REVERSAL_REQUEST)]
        public ReversalRequest ReversalRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_STORED_VALUE_REQUEST)]
        public StoredValueRequest StoredValueRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_TRANSACTION_STATUS_REQUEST)]
        public TransactionStatusRequest TransactionStatusRequest { get; set; }

        [JsonProperty(JSON_PROPERTY_SECURITY_TRAILER)]
        public SecurityTrailer SecurityTrailer { get; set; }

        public static SaleToPOIRequest FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<SaleToPOIRequest>(jsonString); 
        }
        
        public string ToJson()
        {
            return Util.JsonOperation.SerializeRequest(this);
        }
    }
}