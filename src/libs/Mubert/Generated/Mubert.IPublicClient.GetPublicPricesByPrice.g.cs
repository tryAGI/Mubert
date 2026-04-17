#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Retrieve a single price by ID with its options, limits, and Stripe prices
        /// </summary>
        /// <param name="price">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="lang">
        /// Languages
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.GetPublicPricesByPriceResponse> GetPublicPricesByPriceAsync(
            global::System.Guid price,
            global::Mubert.LanguageEnum? lang = default,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}