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
  public class AdditionalData3DSecure {
    /// <summary>
    /// Indicates if you are able to process 3D Secure 2 transactions natively on your payment page. Send this parameter when you are using `/payments` endpoint with any of our [native 3D Secure 2 solutions](https://docs.adyen.com/checkout/3d-secure/native-3ds2).   > This parameter only indicates readiness to support native 3D Secure 2 authentication. To specify if you _want_ to perform 3D Secure, use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) or send the `executeThreeD` parameter.  Possible values: * **true** - Ready to support native 3D Secure 2 authentication. Setting this to true does not mean always applying 3D Secure 2. Adyen still selects the version of 3D Secure based on configuration to optimize authorisation rates and improve the shopper's experience. * **false** – Not ready to support native 3D Secure 2 authentication. Adyen will not offer 3D Secure 2 to your shopper regardless of your configuration. 
    /// </summary>
    /// <value>Indicates if you are able to process 3D Secure 2 transactions natively on your payment page. Send this parameter when you are using `/payments` endpoint with any of our [native 3D Secure 2 solutions](https://docs.adyen.com/checkout/3d-secure/native-3ds2).   > This parameter only indicates readiness to support native 3D Secure 2 authentication. To specify if you _want_ to perform 3D Secure, use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) or send the `executeThreeD` parameter.  Possible values: * **true** - Ready to support native 3D Secure 2 authentication. Setting this to true does not mean always applying 3D Secure 2. Adyen still selects the version of 3D Secure based on configuration to optimize authorisation rates and improve the shopper's experience. * **false** – Not ready to support native 3D Secure 2 authentication. Adyen will not offer 3D Secure 2 to your shopper regardless of your configuration. </value>
    [DataMember(Name="allow3DS2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow3DS2")]
    public string Allow3DS2 { get; set; }

    /// <summary>
    /// Indicates if you want to perform 3D Secure authentication on a transaction.   > Alternatively, you can use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) to configure rules for applying 3D Secure.  Possible values: * **true** – Perform 3D Secure authentication. * **false** – Don't perform 3D Secure authentication. 
    /// </summary>
    /// <value>Indicates if you want to perform 3D Secure authentication on a transaction.   > Alternatively, you can use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) to configure rules for applying 3D Secure.  Possible values: * **true** – Perform 3D Secure authentication. * **false** – Don't perform 3D Secure authentication. </value>
    [DataMember(Name="executeThreeD", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executeThreeD")]
    public string ExecuteThreeD { get; set; }

    /// <summary>
    /// In case of Secure+, this field must be set to **CUPSecurePlus**.
    /// </summary>
    /// <value>In case of Secure+, this field must be set to **CUPSecurePlus**.</value>
    [DataMember(Name="mpiImplementationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mpiImplementationType")]
    public string MpiImplementationType { get; set; }

    /// <summary>
    /// Indicates the [exemption type](https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest) that you want to request for the transaction.   Possible values: * **lowValue**  * **secureCorporate**  * **trustedBeneficiary**  * **transactionRiskAnalysis** 
    /// </summary>
    /// <value>Indicates the [exemption type](https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest) that you want to request for the transaction.   Possible values: * **lowValue**  * **secureCorporate**  * **trustedBeneficiary**  * **transactionRiskAnalysis** </value>
    [DataMember(Name="scaExemption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scaExemption")]
    public string ScaExemption { get; set; }

    /// <summary>
    /// Indicates your preference for the 3D Secure version.  > If you use this parameter, you override the checks from Adyen's Authentication Engine. We recommend to use this field only if you have an extensive knowledge of 3D Secure.  Possible values: * **1.0.2**: Apply 3D Secure version 1.0.2.  * **2.1.0**: Apply 3D Secure version 2.1.0.  * **2.2.0**: Apply 3D Secure version 2.2.0. If the issuer does not support version 2.2.0, we will fall back to 2.1.0.  The following rules apply: * If you prefer 2.1.0 or 2.2.0 but we receive a negative `transStatus` in the `ARes`, we will apply the fallback policy configured in your account. For example, if the configuration is to fall back to 3D Secure 1, we will apply version 1.0.2. * If you prefer 2.1.0 or 2.2.0 but the BIN is not enrolled, you will receive an error.  
    /// </summary>
    /// <value>Indicates your preference for the 3D Secure version.  > If you use this parameter, you override the checks from Adyen's Authentication Engine. We recommend to use this field only if you have an extensive knowledge of 3D Secure.  Possible values: * **1.0.2**: Apply 3D Secure version 1.0.2.  * **2.1.0**: Apply 3D Secure version 2.1.0.  * **2.2.0**: Apply 3D Secure version 2.2.0. If the issuer does not support version 2.2.0, we will fall back to 2.1.0.  The following rules apply: * If you prefer 2.1.0 or 2.2.0 but we receive a negative `transStatus` in the `ARes`, we will apply the fallback policy configured in your account. For example, if the configuration is to fall back to 3D Secure 1, we will apply version 1.0.2. * If you prefer 2.1.0 or 2.2.0 but the BIN is not enrolled, you will receive an error.  </value>
    [DataMember(Name="threeDSVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDSVersion")]
    public string ThreeDSVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalData3DSecure {\n");
      sb.Append("  Allow3DS2: ").Append(Allow3DS2).Append("\n");
      sb.Append("  ExecuteThreeD: ").Append(ExecuteThreeD).Append("\n");
      sb.Append("  MpiImplementationType: ").Append(MpiImplementationType).Append("\n");
      sb.Append("  ScaExemption: ").Append(ScaExemption).Append("\n");
      sb.Append("  ThreeDSVersion: ").Append(ThreeDSVersion).Append("\n");
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
