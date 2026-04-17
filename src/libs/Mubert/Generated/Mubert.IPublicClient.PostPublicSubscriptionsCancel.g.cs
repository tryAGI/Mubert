#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Cancel Subscription<br/>
        /// Cancel a subscription by company ID and license token. Cancels at the end of the current billing period.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task PostPublicSubscriptionsCancelAsync(

            global::Mubert.PostPublicSubscriptionsCancelRequest request,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Subscription<br/>
        /// Cancel a subscription by company ID and license token. Cancels at the end of the current billing period.
        /// </summary>
        /// <param name="companyId">
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="licenseToken">
        /// Example: abc123def456
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PostPublicSubscriptionsCancelAsync(
            global::System.Guid companyId,
            string licenseToken,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}