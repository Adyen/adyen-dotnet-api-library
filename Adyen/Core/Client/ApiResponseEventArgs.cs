using System;

namespace Adyen.Core.Client
{
    /// <summary>
    /// Used for tracking server health.
    /// </summary>
    public class ApiResponseEventArgs : EventArgs
    {
        /// <summary>
        /// The ApiResponse.
        /// </summary>
        public ApiResponse ApiResponse { get; }

        /// <summary>
        /// The <see cref="ApiResponseEventArgs"/>.
        /// </summary>
        /// <param name="apiResponse"><see cref="ApiResponse"/>.</param>
        public ApiResponseEventArgs(ApiResponse apiResponse)
        {
            ApiResponse = apiResponse;
        }
    }
}
