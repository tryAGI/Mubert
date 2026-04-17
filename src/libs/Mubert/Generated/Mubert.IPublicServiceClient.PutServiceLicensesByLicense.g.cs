#nullable enable

namespace Mubert
{
    public partial interface IPublicServiceClient
    {
        /// <summary>
        /// Update license<br/>
        /// Update license parameters such as webhook URL and webhook enabled state. Webhooks receive track models when generation completes.
        /// </summary>
        /// <param name="license">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.LicenseServiceResource> PutServiceLicensesByLicenseAsync(
            global::System.Guid license,

            global::Mubert.PutServiceLicensesByLicenseRequest request,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update license<br/>
        /// Update license parameters such as webhook URL and webhook enabled state. Webhooks receive track models when generation completes.
        /// </summary>
        /// <param name="license">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="webhookUrl">
        /// The URL for the webhook.<br/>
        /// Example: https://example.com/webhook
        /// </param>
        /// <param name="webhookEnabled">
        /// A flag indicating whether the webhook is enabled.<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.LicenseServiceResource> PutServiceLicensesByLicenseAsync(
            global::System.Guid license,
            string? webhookUrl = default,
            bool? webhookEnabled = default,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}