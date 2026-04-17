#nullable enable

namespace Mubert
{
    public partial interface IPublicServiceClient
    {
        /// <summary>
        /// Delete customer<br/>
        /// Remove a customer account by their unique identifier. This action is irreversible.
        /// </summary>
        /// <param name="customer">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteServiceCustomersByCustomerAsync(
            global::System.Guid customer,

            object request,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete customer<br/>
        /// Remove a customer account by their unique identifier. This action is irreversible.
        /// </summary>
        /// <param name="customer">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteServiceCustomersByCustomerAsync(
            global::System.Guid customer,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}