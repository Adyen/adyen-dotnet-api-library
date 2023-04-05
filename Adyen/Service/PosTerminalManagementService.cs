﻿using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Model.PosTerminalManagement;

namespace Adyen.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PosTerminalManagementService : AbstractService
    {
        private readonly string _baseUrl;
        
        public PosTerminalManagementService(Client client) : base(client)
        {
            _baseUrl = client.Config.PosTerminalManagementEndpoint + "/" + ClientConfig.PosTerminalManagementVersion;
        }
    
        /// <summary>
        /// Assign terminals
        /// </summary>
        /// <param name="assignTerminalsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>AssignTerminalsResponse</returns>
        public AssignTerminalsResponse AssignTerminals(AssignTerminalsRequest assignTerminalsRequest, RequestOptions requestOptions = default)
        {
            return AssignTerminalsAsync(assignTerminalsRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Assign terminals
        /// </summary>
        /// <param name="assignTerminalsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of AssignTerminalsResponse</returns>
        public async Task<AssignTerminalsResponse> AssignTerminalsAsync(AssignTerminalsRequest assignTerminalsRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/assignTerminals";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<AssignTerminalsResponse>(assignTerminalsRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Get the account or store of a terminal
        /// </summary>
        /// <param name="findTerminalRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>FindTerminalResponse</returns>
        public FindTerminalResponse FindTerminal(FindTerminalRequest findTerminalRequest, RequestOptions requestOptions = default)
        {
            return FindTerminalAsync(findTerminalRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the account or store of a terminal
        /// </summary>
        /// <param name="findTerminalRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of FindTerminalResponse</returns>
        public async Task<FindTerminalResponse> FindTerminalAsync(FindTerminalRequest findTerminalRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/findTerminal";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<FindTerminalResponse>(findTerminalRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Get the stores of an account
        /// </summary>
        /// <param name="getStoresUnderAccountRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>GetStoresUnderAccountResponse</returns>
        public GetStoresUnderAccountResponse GetStoresUnderAccount(GetStoresUnderAccountRequest getStoresUnderAccountRequest, RequestOptions requestOptions = default)
        {
            return GetStoresUnderAccountAsync(getStoresUnderAccountRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the stores of an account
        /// </summary>
        /// <param name="getStoresUnderAccountRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of GetStoresUnderAccountResponse</returns>
        public async Task<GetStoresUnderAccountResponse> GetStoresUnderAccountAsync(GetStoresUnderAccountRequest getStoresUnderAccountRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/getStoresUnderAccount";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<GetStoresUnderAccountResponse>(getStoresUnderAccountRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Get the details of a terminal
        /// </summary>
        /// <param name="getTerminalDetailsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>GetTerminalDetailsResponse</returns>
        public GetTerminalDetailsResponse GetTerminalDetails(GetTerminalDetailsRequest getTerminalDetailsRequest, RequestOptions requestOptions = default)
        {
            return GetTerminalDetailsAsync(getTerminalDetailsRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the details of a terminal
        /// </summary>
        /// <param name="getTerminalDetailsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of GetTerminalDetailsResponse</returns>
        public async Task<GetTerminalDetailsResponse> GetTerminalDetailsAsync(GetTerminalDetailsRequest getTerminalDetailsRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/getTerminalDetails";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<GetTerminalDetailsResponse>(getTerminalDetailsRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Get the list of terminals
        /// </summary>
        /// <param name="getTerminalsUnderAccountRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>GetTerminalsUnderAccountResponse</returns>
        public GetTerminalsUnderAccountResponse GetTerminalsUnderAccount(GetTerminalsUnderAccountRequest getTerminalsUnderAccountRequest, RequestOptions requestOptions = default)
        {
            return GetTerminalsUnderAccountAsync(getTerminalsUnderAccountRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the list of terminals
        /// </summary>
        /// <param name="getTerminalsUnderAccountRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of GetTerminalsUnderAccountResponse</returns>
        public async Task<GetTerminalsUnderAccountResponse> GetTerminalsUnderAccountAsync(GetTerminalsUnderAccountRequest getTerminalsUnderAccountRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/getTerminalsUnderAccount";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<GetTerminalsUnderAccountResponse>(getTerminalsUnderAccountRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }
    }
}
