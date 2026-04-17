#nullable enable

namespace Mubert
{
    public partial interface IPublicServiceClient
    {
        /// <summary>
        /// Retrieve customer by custom ID<br/>
        /// Fetches the details of a customer based on their custom ID
        /// </summary>
        /// <param name="customId">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.CustomerServiceResource> GetServiceCustomersCustomIdByCustomidAsync(
            global::System.Guid customId,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}