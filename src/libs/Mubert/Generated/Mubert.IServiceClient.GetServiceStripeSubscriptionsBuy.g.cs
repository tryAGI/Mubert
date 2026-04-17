#nullable enable

namespace Mubert
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Buy a subscription via GET (redirect flow). Creates a Stripe Checkout session and redirects to checkout URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.GetServiceStripeSubscriptionsBuyResponse> GetServiceStripeSubscriptionsBuyAsync(

            global::Mubert.GetServiceStripeSubscriptionsBuyRequest request,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Buy a subscription via GET (redirect flow). Creates a Stripe Checkout session and redirects to checkout URL.
        /// </summary>
        /// <param name="companyName">
        /// Example: Acme Inc
        /// </param>
        /// <param name="email">
        /// Example: contact@acme.com
        /// </param>
        /// <param name="stripePriceId">
        /// Example: price_1234567890
        /// </param>
        /// <param name="redirectUrl">
        /// Example: https://example.com/success
        /// </param>
        /// <param name="redirectUrlCancel">
        /// Example: https://example.com/cancel
        /// </param>
        /// <param name="couponId">
        /// Example: DISCOUNT20
        /// </param>
        /// <param name="redirect">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.GetServiceStripeSubscriptionsBuyResponse> GetServiceStripeSubscriptionsBuyAsync(
            string email,
            string stripePriceId,
            string? companyName = default,
            string? redirectUrl = default,
            string? redirectUrlCancel = default,
            string? couponId = default,
            bool? redirect = default,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}