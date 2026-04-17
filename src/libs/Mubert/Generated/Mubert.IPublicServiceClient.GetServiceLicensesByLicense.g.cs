#nullable enable

namespace Mubert
{
    public partial interface IPublicServiceClient
    {
        /// <summary>
        /// Retrieve details of a specific license<br/>
        /// Retrieve details for a specific license including type, status, webhook configuration, track expiration time, feature access, and comprehensive limits.
        /// </summary>
        /// <param name="license">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.LicenseServiceResource> GetServiceLicensesByLicenseAsync(
            global::System.Guid license,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}