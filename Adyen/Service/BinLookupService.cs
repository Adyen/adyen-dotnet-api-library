﻿using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Model.BinLookup;

namespace Adyen.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BinLookupService : AbstractService
    {
        private readonly string _baseUrl;
        
        public BinLookupService(Client client) : base(client)
        {
            _baseUrl = client.Config.Endpoint + ClientConfig.BinLookupPalSuffix + ClientConfig.BinLookupApiVersion;
        }
    
        /// <summary>
        /// Check if 3D Secure is available
        /// </summary>
        /// <param name="threeDSAvailabilityRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ThreeDSAvailabilityResponse</returns>
        public ThreeDSAvailabilityResponse Get3dsAvailability(ThreeDSAvailabilityRequest threeDSAvailabilityRequest, RequestOptions requestOptions = default)
        {
            return Get3dsAvailabilityAsync(threeDSAvailabilityRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Check if 3D Secure is available
        /// </summary>
        /// <param name="threeDSAvailabilityRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ThreeDSAvailabilityResponse</returns>
        public async Task<ThreeDSAvailabilityResponse> Get3dsAvailabilityAsync(ThreeDSAvailabilityRequest threeDSAvailabilityRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/get3dsAvailability";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ThreeDSAvailabilityResponse>(threeDSAvailabilityRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Get a fees cost estimate
        /// </summary>
        /// <param name="costEstimateRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>CostEstimateResponse</returns>
        public CostEstimateResponse GetCostEstimate(CostEstimateRequest costEstimateRequest, RequestOptions requestOptions = default)
        {
            return GetCostEstimateAsync(costEstimateRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a fees cost estimate
        /// </summary>
        /// <param name="costEstimateRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of CostEstimateResponse</returns>
        public async Task<CostEstimateResponse> GetCostEstimateAsync(CostEstimateRequest costEstimateRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/getCostEstimate";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CostEstimateResponse>(costEstimateRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

    }
}