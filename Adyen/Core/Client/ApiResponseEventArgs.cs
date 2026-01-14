using System;

namespace Adyen.Core.Client
{
    /// <summary>
    /// This class is used for wrapping the <see cref="ApiResponse"/>.
    /// </summary>
    public class ApiResponseEventArgs : EventArgs
    {
        /// <summary>
        /// The <see cref="ApiResponse"/>.
        /// </summary>
        public ApiResponse ApiResponse { get; }

        /// <summary>
        /// The <see cref="ApiResponseEventArgs"/> constructed from the Adyen <see cref="ApiResponse"/>.
        /// </summary>
        /// <param name="apiResponse"><see cref="ApiResponse"/>.</param>
        public ApiResponseEventArgs(ApiResponse apiResponse)
        {
            ApiResponse = apiResponse;
        }
    }
}
