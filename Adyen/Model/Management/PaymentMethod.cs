/*
* Management API
*
*
* The version of the OpenAPI document: 3
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Management
{
    /// <summary>
    /// PaymentMethod
    /// </summary>
    [DataContract(Name = "PaymentMethod")]
    public partial class PaymentMethod : IEquatable<PaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Payment method status. Possible values: * **valid** * **pending** * **invalid** * **rejected**
        /// </summary>
        /// <value>Payment method status. Possible values: * **valid** * **pending** * **invalid** * **rejected**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerificationStatusEnum
        {
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 1,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2,

            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 3,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 4

        }


        /// <summary>
        /// Payment method status. Possible values: * **valid** * **pending** * **invalid** * **rejected**
        /// </summary>
        /// <value>Payment method status. Possible values: * **valid** * **pending** * **invalid** * **rejected**</value>
        [DataMember(Name = "verificationStatus", EmitDefaultValue = false)]
        public VerificationStatusEnum? VerificationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        /// <param name="afterpayTouch">afterpayTouch.</param>
        /// <param name="allowed">Indicates whether receiving payments is allowed. This value is set to **true** by Adyen after screening your merchant account..</param>
        /// <param name="amex">amex.</param>
        /// <param name="applePay">applePay.</param>
        /// <param name="bcmc">bcmc.</param>
        /// <param name="businessLineId">The unique identifier of the business line. Required if you are a [platform model](https://docs.adyen.com/platforms)..</param>
        /// <param name="cartesBancaires">cartesBancaires.</param>
        /// <param name="clearpay">clearpay.</param>
        /// <param name="countries">The list of countries where a payment method is available. By default, all countries supported by the payment method..</param>
        /// <param name="cup">cup.</param>
        /// <param name="currencies">The list of currencies that a payment method supports. By default, all currencies supported by the payment method..</param>
        /// <param name="customRoutingFlags">The list of custom routing flags to route payment to the intended acquirer..</param>
        /// <param name="diners">diners.</param>
        /// <param name="discover">discover.</param>
        /// <param name="eftposAustralia">eftposAustralia.</param>
        /// <param name="enabled">Indicates whether the payment method is enabled (**true**) or disabled (**false**)..</param>
        /// <param name="giroPay">giroPay.</param>
        /// <param name="girocard">girocard.</param>
        /// <param name="googlePay">googlePay.</param>
        /// <param name="id">The identifier of the resource. (required).</param>
        /// <param name="ideal">ideal.</param>
        /// <param name="interacCard">interacCard.</param>
        /// <param name="jcb">jcb.</param>
        /// <param name="klarna">klarna.</param>
        /// <param name="maestro">maestro.</param>
        /// <param name="mc">mc.</param>
        /// <param name="mealVoucherFR">mealVoucherFR.</param>
        /// <param name="paypal">paypal.</param>
        /// <param name="reference">Your reference for the payment method. Supported characters a-z, A-Z, 0-9..</param>
        /// <param name="shopperInteraction">The sales channel..</param>
        /// <param name="sofort">sofort.</param>
        /// <param name="storeIds">The unique identifier of the store for which to configure the payment method, if any..</param>
        /// <param name="swish">swish.</param>
        /// <param name="twint">twint.</param>
        /// <param name="type">Payment method [variant](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api)..</param>
        /// <param name="verificationStatus">Payment method status. Possible values: * **valid** * **pending** * **invalid** * **rejected**.</param>
        /// <param name="vipps">vipps.</param>
        /// <param name="visa">visa.</param>
        public PaymentMethod(AfterpayTouchInfo afterpayTouch = default(AfterpayTouchInfo), bool? allowed = default(bool?), AmexInfo amex = default(AmexInfo), ApplePayInfo applePay = default(ApplePayInfo), BcmcInfo bcmc = default(BcmcInfo), string businessLineId = default(string), CartesBancairesInfo cartesBancaires = default(CartesBancairesInfo), ClearpayInfo clearpay = default(ClearpayInfo), List<string> countries = default(List<string>), GenericPmWithTdiInfo cup = default(GenericPmWithTdiInfo), List<string> currencies = default(List<string>), List<string> customRoutingFlags = default(List<string>), GenericPmWithTdiInfo diners = default(GenericPmWithTdiInfo), GenericPmWithTdiInfo discover = default(GenericPmWithTdiInfo), GenericPmWithTdiInfo eftposAustralia = default(GenericPmWithTdiInfo), bool? enabled = default(bool?), GiroPayInfo giroPay = default(GiroPayInfo), GenericPmWithTdiInfo girocard = default(GenericPmWithTdiInfo), GooglePayInfo googlePay = default(GooglePayInfo), string id = default(string), GenericPmWithTdiInfo ideal = default(GenericPmWithTdiInfo), GenericPmWithTdiInfo interacCard = default(GenericPmWithTdiInfo), GenericPmWithTdiInfo jcb = default(GenericPmWithTdiInfo), KlarnaInfo klarna = default(KlarnaInfo), GenericPmWithTdiInfo maestro = default(GenericPmWithTdiInfo), GenericPmWithTdiInfo mc = default(GenericPmWithTdiInfo), MealVoucherFRInfo mealVoucherFR = default(MealVoucherFRInfo), PayPalInfo paypal = default(PayPalInfo), string reference = default(string), string shopperInteraction = default(string), SofortInfo sofort = default(SofortInfo), List<string> storeIds = default(List<string>), SwishInfo swish = default(SwishInfo), TwintInfo twint = default(TwintInfo), string type = default(string), VerificationStatusEnum? verificationStatus = default(VerificationStatusEnum?), VippsInfo vipps = default(VippsInfo), GenericPmWithTdiInfo visa = default(GenericPmWithTdiInfo))
        {
            this.Id = id;
            this.AfterpayTouch = afterpayTouch;
            this.Allowed = allowed;
            this.Amex = amex;
            this.ApplePay = applePay;
            this.Bcmc = bcmc;
            this.BusinessLineId = businessLineId;
            this.CartesBancaires = cartesBancaires;
            this.Clearpay = clearpay;
            this.Countries = countries;
            this.Cup = cup;
            this.Currencies = currencies;
            this.CustomRoutingFlags = customRoutingFlags;
            this.Diners = diners;
            this.Discover = discover;
            this.EftposAustralia = eftposAustralia;
            this.Enabled = enabled;
            this.GiroPay = giroPay;
            this.Girocard = girocard;
            this.GooglePay = googlePay;
            this.Ideal = ideal;
            this.InteracCard = interacCard;
            this.Jcb = jcb;
            this.Klarna = klarna;
            this.Maestro = maestro;
            this.Mc = mc;
            this.MealVoucherFR = mealVoucherFR;
            this.Paypal = paypal;
            this.Reference = reference;
            this.ShopperInteraction = shopperInteraction;
            this.Sofort = sofort;
            this.StoreIds = storeIds;
            this.Swish = swish;
            this.Twint = twint;
            this.Type = type;
            this.VerificationStatus = verificationStatus;
            this.Vipps = vipps;
            this.Visa = visa;
        }

        /// <summary>
        /// Gets or Sets AfterpayTouch
        /// </summary>
        [DataMember(Name = "afterpayTouch", EmitDefaultValue = false)]
        public AfterpayTouchInfo AfterpayTouch { get; set; }

        /// <summary>
        /// Indicates whether receiving payments is allowed. This value is set to **true** by Adyen after screening your merchant account.
        /// </summary>
        /// <value>Indicates whether receiving payments is allowed. This value is set to **true** by Adyen after screening your merchant account.</value>
        [DataMember(Name = "allowed", EmitDefaultValue = false)]
        public bool? Allowed { get; set; }

        /// <summary>
        /// Gets or Sets Amex
        /// </summary>
        [DataMember(Name = "amex", EmitDefaultValue = false)]
        public AmexInfo Amex { get; set; }

        /// <summary>
        /// Gets or Sets ApplePay
        /// </summary>
        [DataMember(Name = "applePay", EmitDefaultValue = false)]
        public ApplePayInfo ApplePay { get; set; }

        /// <summary>
        /// Gets or Sets Bcmc
        /// </summary>
        [DataMember(Name = "bcmc", EmitDefaultValue = false)]
        public BcmcInfo Bcmc { get; set; }

        /// <summary>
        /// The unique identifier of the business line. Required if you are a [platform model](https://docs.adyen.com/platforms).
        /// </summary>
        /// <value>The unique identifier of the business line. Required if you are a [platform model](https://docs.adyen.com/platforms).</value>
        [DataMember(Name = "businessLineId", EmitDefaultValue = false)]
        public string BusinessLineId { get; set; }

        /// <summary>
        /// Gets or Sets CartesBancaires
        /// </summary>
        [DataMember(Name = "cartesBancaires", EmitDefaultValue = false)]
        public CartesBancairesInfo CartesBancaires { get; set; }

        /// <summary>
        /// Gets or Sets Clearpay
        /// </summary>
        [DataMember(Name = "clearpay", EmitDefaultValue = false)]
        public ClearpayInfo Clearpay { get; set; }

        /// <summary>
        /// The list of countries where a payment method is available. By default, all countries supported by the payment method.
        /// </summary>
        /// <value>The list of countries where a payment method is available. By default, all countries supported by the payment method.</value>
        [DataMember(Name = "countries", EmitDefaultValue = false)]
        public List<string> Countries { get; set; }

        /// <summary>
        /// Gets or Sets Cup
        /// </summary>
        [DataMember(Name = "cup", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Cup { get; set; }

        /// <summary>
        /// The list of currencies that a payment method supports. By default, all currencies supported by the payment method.
        /// </summary>
        /// <value>The list of currencies that a payment method supports. By default, all currencies supported by the payment method.</value>
        [DataMember(Name = "currencies", EmitDefaultValue = false)]
        public List<string> Currencies { get; set; }

        /// <summary>
        /// The list of custom routing flags to route payment to the intended acquirer.
        /// </summary>
        /// <value>The list of custom routing flags to route payment to the intended acquirer.</value>
        [DataMember(Name = "customRoutingFlags", EmitDefaultValue = false)]
        public List<string> CustomRoutingFlags { get; set; }

        /// <summary>
        /// Gets or Sets Diners
        /// </summary>
        [DataMember(Name = "diners", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Diners { get; set; }

        /// <summary>
        /// Gets or Sets Discover
        /// </summary>
        [DataMember(Name = "discover", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Discover { get; set; }

        /// <summary>
        /// Gets or Sets EftposAustralia
        /// </summary>
        [DataMember(Name = "eftpos_australia", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo EftposAustralia { get; set; }

        /// <summary>
        /// Indicates whether the payment method is enabled (**true**) or disabled (**false**).
        /// </summary>
        /// <value>Indicates whether the payment method is enabled (**true**) or disabled (**false**).</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets GiroPay
        /// </summary>
        [DataMember(Name = "giroPay", EmitDefaultValue = false)]
        public GiroPayInfo GiroPay { get; set; }

        /// <summary>
        /// Gets or Sets Girocard
        /// </summary>
        [DataMember(Name = "girocard", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Girocard { get; set; }

        /// <summary>
        /// Gets or Sets GooglePay
        /// </summary>
        [DataMember(Name = "googlePay", EmitDefaultValue = false)]
        public GooglePayInfo GooglePay { get; set; }

        /// <summary>
        /// The identifier of the resource.
        /// </summary>
        /// <value>The identifier of the resource.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Ideal
        /// </summary>
        [DataMember(Name = "ideal", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Ideal { get; set; }

        /// <summary>
        /// Gets or Sets InteracCard
        /// </summary>
        [DataMember(Name = "interac_card", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo InteracCard { get; set; }

        /// <summary>
        /// Gets or Sets Jcb
        /// </summary>
        [DataMember(Name = "jcb", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Jcb { get; set; }

        /// <summary>
        /// Gets or Sets Klarna
        /// </summary>
        [DataMember(Name = "klarna", EmitDefaultValue = false)]
        public KlarnaInfo Klarna { get; set; }

        /// <summary>
        /// Gets or Sets Maestro
        /// </summary>
        [DataMember(Name = "maestro", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Maestro { get; set; }

        /// <summary>
        /// Gets or Sets Mc
        /// </summary>
        [DataMember(Name = "mc", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Mc { get; set; }

        /// <summary>
        /// Gets or Sets MealVoucherFR
        /// </summary>
        [DataMember(Name = "mealVoucher_FR", EmitDefaultValue = false)]
        public MealVoucherFRInfo MealVoucherFR { get; set; }

        /// <summary>
        /// Gets or Sets Paypal
        /// </summary>
        [DataMember(Name = "paypal", EmitDefaultValue = false)]
        public PayPalInfo Paypal { get; set; }

        /// <summary>
        /// Your reference for the payment method. Supported characters a-z, A-Z, 0-9.
        /// </summary>
        /// <value>Your reference for the payment method. Supported characters a-z, A-Z, 0-9.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The sales channel.
        /// </summary>
        /// <value>The sales channel.</value>
        [DataMember(Name = "shopperInteraction", EmitDefaultValue = false)]
        public string ShopperInteraction { get; set; }

        /// <summary>
        /// Gets or Sets Sofort
        /// </summary>
        [DataMember(Name = "sofort", EmitDefaultValue = false)]
        public SofortInfo Sofort { get; set; }

        /// <summary>
        /// The unique identifier of the store for which to configure the payment method, if any.
        /// </summary>
        /// <value>The unique identifier of the store for which to configure the payment method, if any.</value>
        [DataMember(Name = "storeIds", EmitDefaultValue = false)]
        public List<string> StoreIds { get; set; }

        /// <summary>
        /// Gets or Sets Swish
        /// </summary>
        [DataMember(Name = "swish", EmitDefaultValue = false)]
        public SwishInfo Swish { get; set; }

        /// <summary>
        /// Gets or Sets Twint
        /// </summary>
        [DataMember(Name = "twint", EmitDefaultValue = false)]
        public TwintInfo Twint { get; set; }

        /// <summary>
        /// Payment method [variant](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api).
        /// </summary>
        /// <value>Payment method [variant](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api).</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Vipps
        /// </summary>
        [DataMember(Name = "vipps", EmitDefaultValue = false)]
        public VippsInfo Vipps { get; set; }

        /// <summary>
        /// Gets or Sets Visa
        /// </summary>
        [DataMember(Name = "visa", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Visa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethod {\n");
            sb.Append("  AfterpayTouch: ").Append(AfterpayTouch).Append("\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  Amex: ").Append(Amex).Append("\n");
            sb.Append("  ApplePay: ").Append(ApplePay).Append("\n");
            sb.Append("  Bcmc: ").Append(Bcmc).Append("\n");
            sb.Append("  BusinessLineId: ").Append(BusinessLineId).Append("\n");
            sb.Append("  CartesBancaires: ").Append(CartesBancaires).Append("\n");
            sb.Append("  Clearpay: ").Append(Clearpay).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  Cup: ").Append(Cup).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  CustomRoutingFlags: ").Append(CustomRoutingFlags).Append("\n");
            sb.Append("  Diners: ").Append(Diners).Append("\n");
            sb.Append("  Discover: ").Append(Discover).Append("\n");
            sb.Append("  EftposAustralia: ").Append(EftposAustralia).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  GiroPay: ").Append(GiroPay).Append("\n");
            sb.Append("  Girocard: ").Append(Girocard).Append("\n");
            sb.Append("  GooglePay: ").Append(GooglePay).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ideal: ").Append(Ideal).Append("\n");
            sb.Append("  InteracCard: ").Append(InteracCard).Append("\n");
            sb.Append("  Jcb: ").Append(Jcb).Append("\n");
            sb.Append("  Klarna: ").Append(Klarna).Append("\n");
            sb.Append("  Maestro: ").Append(Maestro).Append("\n");
            sb.Append("  Mc: ").Append(Mc).Append("\n");
            sb.Append("  MealVoucherFR: ").Append(MealVoucherFR).Append("\n");
            sb.Append("  Paypal: ").Append(Paypal).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ShopperInteraction: ").Append(ShopperInteraction).Append("\n");
            sb.Append("  Sofort: ").Append(Sofort).Append("\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
            sb.Append("  Swish: ").Append(Swish).Append("\n");
            sb.Append("  Twint: ").Append(Twint).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
            sb.Append("  Vipps: ").Append(Vipps).Append("\n");
            sb.Append("  Visa: ").Append(Visa).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentMethod);
        }

        /// <summary>
        /// Returns true if PaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AfterpayTouch == input.AfterpayTouch ||
                    (this.AfterpayTouch != null &&
                    this.AfterpayTouch.Equals(input.AfterpayTouch))
                ) && 
                (
                    this.Allowed == input.Allowed ||
                    this.Allowed.Equals(input.Allowed)
                ) && 
                (
                    this.Amex == input.Amex ||
                    (this.Amex != null &&
                    this.Amex.Equals(input.Amex))
                ) && 
                (
                    this.ApplePay == input.ApplePay ||
                    (this.ApplePay != null &&
                    this.ApplePay.Equals(input.ApplePay))
                ) && 
                (
                    this.Bcmc == input.Bcmc ||
                    (this.Bcmc != null &&
                    this.Bcmc.Equals(input.Bcmc))
                ) && 
                (
                    this.BusinessLineId == input.BusinessLineId ||
                    (this.BusinessLineId != null &&
                    this.BusinessLineId.Equals(input.BusinessLineId))
                ) && 
                (
                    this.CartesBancaires == input.CartesBancaires ||
                    (this.CartesBancaires != null &&
                    this.CartesBancaires.Equals(input.CartesBancaires))
                ) && 
                (
                    this.Clearpay == input.Clearpay ||
                    (this.Clearpay != null &&
                    this.Clearpay.Equals(input.Clearpay))
                ) && 
                (
                    this.Countries == input.Countries ||
                    this.Countries != null &&
                    input.Countries != null &&
                    this.Countries.SequenceEqual(input.Countries)
                ) && 
                (
                    this.Cup == input.Cup ||
                    (this.Cup != null &&
                    this.Cup.Equals(input.Cup))
                ) && 
                (
                    this.Currencies == input.Currencies ||
                    this.Currencies != null &&
                    input.Currencies != null &&
                    this.Currencies.SequenceEqual(input.Currencies)
                ) && 
                (
                    this.CustomRoutingFlags == input.CustomRoutingFlags ||
                    this.CustomRoutingFlags != null &&
                    input.CustomRoutingFlags != null &&
                    this.CustomRoutingFlags.SequenceEqual(input.CustomRoutingFlags)
                ) && 
                (
                    this.Diners == input.Diners ||
                    (this.Diners != null &&
                    this.Diners.Equals(input.Diners))
                ) && 
                (
                    this.Discover == input.Discover ||
                    (this.Discover != null &&
                    this.Discover.Equals(input.Discover))
                ) && 
                (
                    this.EftposAustralia == input.EftposAustralia ||
                    (this.EftposAustralia != null &&
                    this.EftposAustralia.Equals(input.EftposAustralia))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.GiroPay == input.GiroPay ||
                    (this.GiroPay != null &&
                    this.GiroPay.Equals(input.GiroPay))
                ) && 
                (
                    this.Girocard == input.Girocard ||
                    (this.Girocard != null &&
                    this.Girocard.Equals(input.Girocard))
                ) && 
                (
                    this.GooglePay == input.GooglePay ||
                    (this.GooglePay != null &&
                    this.GooglePay.Equals(input.GooglePay))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Ideal == input.Ideal ||
                    (this.Ideal != null &&
                    this.Ideal.Equals(input.Ideal))
                ) && 
                (
                    this.InteracCard == input.InteracCard ||
                    (this.InteracCard != null &&
                    this.InteracCard.Equals(input.InteracCard))
                ) && 
                (
                    this.Jcb == input.Jcb ||
                    (this.Jcb != null &&
                    this.Jcb.Equals(input.Jcb))
                ) && 
                (
                    this.Klarna == input.Klarna ||
                    (this.Klarna != null &&
                    this.Klarna.Equals(input.Klarna))
                ) && 
                (
                    this.Maestro == input.Maestro ||
                    (this.Maestro != null &&
                    this.Maestro.Equals(input.Maestro))
                ) && 
                (
                    this.Mc == input.Mc ||
                    (this.Mc != null &&
                    this.Mc.Equals(input.Mc))
                ) && 
                (
                    this.MealVoucherFR == input.MealVoucherFR ||
                    (this.MealVoucherFR != null &&
                    this.MealVoucherFR.Equals(input.MealVoucherFR))
                ) && 
                (
                    this.Paypal == input.Paypal ||
                    (this.Paypal != null &&
                    this.Paypal.Equals(input.Paypal))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.ShopperInteraction == input.ShopperInteraction ||
                    (this.ShopperInteraction != null &&
                    this.ShopperInteraction.Equals(input.ShopperInteraction))
                ) && 
                (
                    this.Sofort == input.Sofort ||
                    (this.Sofort != null &&
                    this.Sofort.Equals(input.Sofort))
                ) && 
                (
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    input.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
                ) && 
                (
                    this.Swish == input.Swish ||
                    (this.Swish != null &&
                    this.Swish.Equals(input.Swish))
                ) && 
                (
                    this.Twint == input.Twint ||
                    (this.Twint != null &&
                    this.Twint.Equals(input.Twint))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.VerificationStatus == input.VerificationStatus ||
                    this.VerificationStatus.Equals(input.VerificationStatus)
                ) && 
                (
                    this.Vipps == input.Vipps ||
                    (this.Vipps != null &&
                    this.Vipps.Equals(input.Vipps))
                ) && 
                (
                    this.Visa == input.Visa ||
                    (this.Visa != null &&
                    this.Visa.Equals(input.Visa))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AfterpayTouch != null)
                {
                    hashCode = (hashCode * 59) + this.AfterpayTouch.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Allowed.GetHashCode();
                if (this.Amex != null)
                {
                    hashCode = (hashCode * 59) + this.Amex.GetHashCode();
                }
                if (this.ApplePay != null)
                {
                    hashCode = (hashCode * 59) + this.ApplePay.GetHashCode();
                }
                if (this.Bcmc != null)
                {
                    hashCode = (hashCode * 59) + this.Bcmc.GetHashCode();
                }
                if (this.BusinessLineId != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLineId.GetHashCode();
                }
                if (this.CartesBancaires != null)
                {
                    hashCode = (hashCode * 59) + this.CartesBancaires.GetHashCode();
                }
                if (this.Clearpay != null)
                {
                    hashCode = (hashCode * 59) + this.Clearpay.GetHashCode();
                }
                if (this.Countries != null)
                {
                    hashCode = (hashCode * 59) + this.Countries.GetHashCode();
                }
                if (this.Cup != null)
                {
                    hashCode = (hashCode * 59) + this.Cup.GetHashCode();
                }
                if (this.Currencies != null)
                {
                    hashCode = (hashCode * 59) + this.Currencies.GetHashCode();
                }
                if (this.CustomRoutingFlags != null)
                {
                    hashCode = (hashCode * 59) + this.CustomRoutingFlags.GetHashCode();
                }
                if (this.Diners != null)
                {
                    hashCode = (hashCode * 59) + this.Diners.GetHashCode();
                }
                if (this.Discover != null)
                {
                    hashCode = (hashCode * 59) + this.Discover.GetHashCode();
                }
                if (this.EftposAustralia != null)
                {
                    hashCode = (hashCode * 59) + this.EftposAustralia.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.GiroPay != null)
                {
                    hashCode = (hashCode * 59) + this.GiroPay.GetHashCode();
                }
                if (this.Girocard != null)
                {
                    hashCode = (hashCode * 59) + this.Girocard.GetHashCode();
                }
                if (this.GooglePay != null)
                {
                    hashCode = (hashCode * 59) + this.GooglePay.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Ideal != null)
                {
                    hashCode = (hashCode * 59) + this.Ideal.GetHashCode();
                }
                if (this.InteracCard != null)
                {
                    hashCode = (hashCode * 59) + this.InteracCard.GetHashCode();
                }
                if (this.Jcb != null)
                {
                    hashCode = (hashCode * 59) + this.Jcb.GetHashCode();
                }
                if (this.Klarna != null)
                {
                    hashCode = (hashCode * 59) + this.Klarna.GetHashCode();
                }
                if (this.Maestro != null)
                {
                    hashCode = (hashCode * 59) + this.Maestro.GetHashCode();
                }
                if (this.Mc != null)
                {
                    hashCode = (hashCode * 59) + this.Mc.GetHashCode();
                }
                if (this.MealVoucherFR != null)
                {
                    hashCode = (hashCode * 59) + this.MealVoucherFR.GetHashCode();
                }
                if (this.Paypal != null)
                {
                    hashCode = (hashCode * 59) + this.Paypal.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.ShopperInteraction != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperInteraction.GetHashCode();
                }
                if (this.Sofort != null)
                {
                    hashCode = (hashCode * 59) + this.Sofort.GetHashCode();
                }
                if (this.StoreIds != null)
                {
                    hashCode = (hashCode * 59) + this.StoreIds.GetHashCode();
                }
                if (this.Swish != null)
                {
                    hashCode = (hashCode * 59) + this.Swish.GetHashCode();
                }
                if (this.Twint != null)
                {
                    hashCode = (hashCode * 59) + this.Twint.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VerificationStatus.GetHashCode();
                if (this.Vipps != null)
                {
                    hashCode = (hashCode * 59) + this.Vipps.GetHashCode();
                }
                if (this.Visa != null)
                {
                    hashCode = (hashCode * 59) + this.Visa.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 150.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
