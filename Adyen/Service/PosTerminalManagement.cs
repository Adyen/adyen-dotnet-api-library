#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System.Threading.Tasks;
using Adyen.Model.PosTerminalManagement;
using Adyen.Service.Resource.PosTerminalManagement;
using Newtonsoft.Json;

namespace Adyen.Service
{
    public class PosTerminalManagement : AbstractService
    {
        private readonly AssignTerminals _assignTerminals;
        private readonly FindTerminal _findTerminal;
        private readonly GetTerminalsUnderAccount _getTerminalsUnderAccount;
        
        public PosTerminalManagement(Client client) : base(client)
        {
            _assignTerminals = new AssignTerminals(this);
            _findTerminal = new FindTerminal(this);
            _getTerminalsUnderAccount = new GetTerminalsUnderAccount(this);
        }
        /// <summary>
        /// post /assingTerminals
        /// </summary>
        /// <param name="assignTerminalsRequest"></param>
        /// <returns>AssignTerminalsResponse</returns>
        public AssignTerminalsResponse AssignTerminals(AssignTerminalsRequest assignTerminalsRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(assignTerminalsRequest);
            var jsonResponse = _assignTerminals.Request(jsonRequest);
            return JsonConvert.DeserializeObject<AssignTerminalsResponse>(jsonResponse);
        }
        /// <summary>
        /// post /assingTerminals
        /// </summary>
        /// <param name="assignTerminalsRequest"></param>
        /// <returns>task AssignTerminalsResponse</returns>
        public async Task<AssignTerminalsResponse> AssignTerminalsAsync(AssignTerminalsRequest assignTerminalsRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(assignTerminalsRequest);
            var jsonResponse = await _assignTerminals.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<AssignTerminalsResponse>(jsonResponse);
        }
        /// <summary>
        /// post /findTerminal
        /// </summary>
        /// <param name="findTerminalRequest"></param>
        /// <returns>FindTerminalResponse</returns>
        public FindTerminalResponse FindTerminal(FindTerminalRequest findTerminalRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(findTerminalRequest);
            var jsonResponse = _findTerminal.Request(jsonRequest);
            return JsonConvert.DeserializeObject<FindTerminalResponse>(jsonResponse);
        }
        /// <summary>
        /// post /findTerminal
        /// </summary>
        /// <param name="findTerminalRequest"></param>
        /// <returns>task FindTerminalResponse</returns>
        public async Task<FindTerminalResponse> FindTerminalAsync(FindTerminalRequest findTerminalRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(findTerminalRequest);
            var jsonResponse = await _findTerminal.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<FindTerminalResponse>(jsonResponse);
        }
        /// <summary>
        /// post /getTerminalsUnderAccount
        /// </summary>
        /// <param name="getTerminalsUnderAccountRequest"></param>
        /// <returns>GetTerminalsUnderAccountResponse</returns>
        public GetTerminalsUnderAccountResponse GetTerminalsUnderAccount(GetTerminalsUnderAccountRequest getTerminalsUnderAccountRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(getTerminalsUnderAccountRequest);
            var jsonResponse = _getTerminalsUnderAccount.Request(jsonRequest);
            return JsonConvert.DeserializeObject<GetTerminalsUnderAccountResponse>(jsonResponse);
        }
        /// <summary>
        /// post /getTerminalsUnderAccount
        /// </summary>
        /// <param name="getTerminalsUnderAccountRequest"></param>
        /// <returns>task GetTerminalsUnderAccountResponse</returns>
        public async Task<GetTerminalsUnderAccountResponse> GetTerminalsUnderAccountAsync(GetTerminalsUnderAccountRequest getTerminalsUnderAccountRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(getTerminalsUnderAccountRequest);
            var jsonResponse = await _getTerminalsUnderAccount.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<GetTerminalsUnderAccountResponse>(jsonResponse);
        }
    }
}