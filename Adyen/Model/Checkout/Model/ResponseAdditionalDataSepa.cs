using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ResponseAdditionalDataSepa {
    /// <summary>
    /// The transaction signature date.  Format: yyyy-MM-dd
    /// </summary>
    /// <value>The transaction signature date.  Format: yyyy-MM-dd</value>
    [DataMember(Name="sepadirectdebit.dateOfSignature", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sepadirectdebit.dateOfSignature")]
    public string SepadirectdebitDateOfSignature { get; set; }

    /// <summary>
    /// Its value corresponds to the pspReference value of the transaction.
    /// </summary>
    /// <value>Its value corresponds to the pspReference value of the transaction.</value>
    [DataMember(Name="sepadirectdebit.mandateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sepadirectdebit.mandateId")]
    public string SepadirectdebitMandateId { get; set; }

    /// <summary>
    /// This field can take one of the following values: * OneOff: (OOFF) Direct debit instruction to initiate exactly one direct debit transaction.  * First: (FRST) Initial/first collection in a series of direct debit instructions. * Recurring: (RCUR) Direct debit instruction to carry out regular direct debit transactions initiated by the creditor. * Final: (FNAL) Last/final collection in a series of direct debit instructions.  Example: OOFF
    /// </summary>
    /// <value>This field can take one of the following values: * OneOff: (OOFF) Direct debit instruction to initiate exactly one direct debit transaction.  * First: (FRST) Initial/first collection in a series of direct debit instructions. * Recurring: (RCUR) Direct debit instruction to carry out regular direct debit transactions initiated by the creditor. * Final: (FNAL) Last/final collection in a series of direct debit instructions.  Example: OOFF</value>
    [DataMember(Name="sepadirectdebit.sequenceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sepadirectdebit.sequenceType")]
    public string SepadirectdebitSequenceType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResponseAdditionalDataSepa {\n");
      sb.Append("  SepadirectdebitDateOfSignature: ").Append(SepadirectdebitDateOfSignature).Append("\n");
      sb.Append("  SepadirectdebitMandateId: ").Append(SepadirectdebitMandateId).Append("\n");
      sb.Append("  SepadirectdebitSequenceType: ").Append(SepadirectdebitSequenceType).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
