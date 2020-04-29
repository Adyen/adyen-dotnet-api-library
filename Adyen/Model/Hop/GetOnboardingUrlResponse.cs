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
         /// <summary>
    /// The result code.
    /// </summary>
    /// <value>The result code.</value>
    [DataMember(Name = "resultCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resultCode")]
        public string ResultCode { get; set; }
         /// <summary>
    /// Indicates whether the request is processed synchronously or asynchronously.  Depending on the request's platform settings, the following scenarios may be applied: * **sync:** The processing of the request is immediately attempted; it may result in an error if the providing service is unavailable. * **async:** The request is queued and will be executed when the providing service is available in the order in which the requests are received. * **asyncOnError:** The processing of the request is immediately attempted, but if the providing service is unavailable, the request is scheduled in a queue.
    /// </summary>
    /// <value>Indicates whether the request is processed synchronously or asynchronously.  Depending on the request's platform settings, the following scenarios may be applied: * **sync:** The processing of the request is immediately attempted; it may result in an error if the providing service is unavailable. * **async:** The request is queued and will be executed when the providing service is available in the order in which the requests are received. * **asyncOnError:** The processing of the request is immediately attempted, but if the providing service is unavailable, the request is scheduled in a queue.</value>
    [DataMember(Name="submittedAsync", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "submittedAsync")]
        public bool SubmittedAsync { get; set; }
        [DataMember(Name = "redirectUrl", EmitDefaultValue = false)]
        public string RedirectUrl { get; set; }
    }
}
