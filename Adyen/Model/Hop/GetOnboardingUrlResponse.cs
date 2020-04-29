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

using System.Runtime.Serialization;

namespace Adyen.Model.Hop
{
    [DataContract]
    public class GetOnboardingUrlResponse
    {
    /// <summary>
    /// Contains field validation errors that would prevent requests from being processed.
    /// </summary>
    /// <value>Contains field validation errors that would prevent requests from being processed.</value>
    [DataMember(Name="invalidFields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invalidFields")]
    public List<ErrorFieldType> InvalidFields { get; set; }

    
  /// <summary>
    /// The reference of a request.  Can be used to uniquely identify the request.
    /// </summary>
    /// <value>The reference of a request.  Can be used to uniquely identify the request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pspReference")]

        public string PspReference { get; set; }
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public string ResultCode { get; set; }
        [DataMember(Name = "submittedAsync", EmitDefaultValue = false)]
        public bool SubmittedAsync { get; set; }
        [DataMember(Name = "redirectUrl", EmitDefaultValue = false)]
        public string RedirectUrl { get; set; }
    }
}
