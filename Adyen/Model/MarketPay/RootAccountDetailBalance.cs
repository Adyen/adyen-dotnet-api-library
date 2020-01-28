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
    public class RootAccountDetailBalance : IEquatable<RootAccountDetailBalance>, IValidatableObject
    {
        [JsonProperty("AccountDetailBalance")]
        public AccountDetailBalance AccountDetailBalance { get; set; }

        public bool Equals(RootAccountDetailBalance other)
        {
            if (other == null)
                return false;

            return
                (
                    this.AccountDetailBalance == other.AccountDetailBalance ||
                    this.AccountDetailBalance != null &&
                    this.AccountDetailBalance.Equals(other.AccountDetailBalance)
                );
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
