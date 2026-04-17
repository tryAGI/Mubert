#nullable enable

namespace Mubert
{
    public partial interface IPublicServiceClient
    {
        /// <summary>
        /// Update an existing customer<br/>
        /// Handles the update of an existing customer identified by their UUID
        /// </summary>
        /// <param name="customer">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.CustomerServiceResource> PutServiceCustomersByCustomerAsync(
            global::System.Guid customer,

            global::Mubert.PutServiceCustomersByCustomerRequest request,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing customer<br/>
        /// Handles the update of an existing customer identified by their UUID
        /// </summary>
        /// <param name="customer">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="customId">
        /// A unique identifier for the customer.<br/>
        /// Example: customer456
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.CustomerServiceResource> PutServiceCustomersByCustomerAsync(
            global::System.Guid customer,
            string customId,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}