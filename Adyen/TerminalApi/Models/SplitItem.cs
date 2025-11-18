using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Terminal
{
    public class SplitItem
    {
        /// <summary>
        /// Amount of each split item, in minor units.
        /// You do not need to specify the amount for the fees, since this is not known at the time of payment.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Split type, see possible values: <see cref="SplitItemType"/>.
        /// Defines the part of the payment you want to book to the specified <see cref="Account"/>.
        /// A type of <see cref="SplitItemType.MarketPlace"/> or <see cref="SplitItemType.VAT"/>  sends the amount to the <see cref="Account"/> specified.
        /// A type of <see cref="SplitItemType.Commission"/> or <see cref="SplitItemType.PaymentFee"/> sends the amount to your liable account.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Account that will receive the split.
        /// This is the accountCode of one of your account holder's accounts or your own liable account.
        /// You do not need to specify an account when <see cref="Type"/> is <see cref="SplitItemType.Commission"/>.
        /// Account that will receive (or be charged) the split.
        /// </summary>
        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }

        /// <summary>
        /// The reference for that specific transaction split, which is returned in our reporting.
        /// Required if the <see cref="Type"/> is <see cref="SplitItemType.BalanceAccount"/>.
        /// </summary>
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }
        
        /// <summary>
        /// The description for that specific transaction split, which is returned in our reporting.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SplitItem {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

    }
}