using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// Amount
    /// </summary>
    [DataContract]
    public partial class RootAmount : IEquatable<RootAmount>, IValidatableObject
    {
        [JsonProperty("Amount")]
        public Amount Amount { get; set; }

        public bool Equals(RootAmount other)
        {
            if (other == null)
                return false;

            return
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                );
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}