#nullable enable

namespace Mubert
{
    public partial interface IPublicServiceClient
    {
        /// <summary>
        /// Create a new customer<br/>
        /// Create a new customer account. Requires a unique custom_id (alphanumeric, max 255 chars). Returns customer_id and access_token for public API authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.CustomerServiceResource> PostServiceCustomersAsync(

            global::Mubert.PostServiceCustomersRequest request,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new customer<br/>
        /// Create a new customer account. Requires a unique custom_id (alphanumeric, max 255 chars). Returns customer_id and access_token for public API authentication.
        /// </summary>
        /// <param name="customId">
        /// A unique identifier for the customer.<br/>
        /// Example: customer123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.CustomerServiceResource> PostServiceCustomersAsync(
            string customId,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}