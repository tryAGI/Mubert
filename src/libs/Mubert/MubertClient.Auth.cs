namespace Mubert;

public sealed partial class MubertClient
{
    /// <summary>
    /// Default base URL for the Mubert AI Music API.
    /// </summary>
    public const string DefaultBaseUrlValue = "https://music-api.mubert.com";

    /// <summary>
    /// Creates a new <see cref="MubertClient"/> with dual-header authentication for the
    /// public customer endpoints (<c>customer-id</c> + <c>access-token</c>).
    /// </summary>
    /// <param name="customerId">Your Mubert customer id.</param>
    /// <param name="accessToken">Your Mubert access token.</param>
    /// <param name="httpClient">Optional <see cref="global::System.Net.Http.HttpClient"/> instance.</param>
    /// <param name="baseUri">Optional base URI override. Defaults to <c>https://music-api.mubert.com</c>.</param>
    /// <param name="disposeHttpClient">Whether to dispose the HTTP client when this client is disposed.</param>
    public MubertClient(
        string customerId,
        string accessToken,
        global::System.Net.Http.HttpClient? httpClient = null,
        global::System.Uri? baseUri = null,
        bool disposeHttpClient = true) : this(
            httpClient,
            baseUri ?? new global::System.Uri(DefaultBaseUrlValue),
            authorizations: null,
            disposeHttpClient: disposeHttpClient)
    {
        customerId = customerId ?? throw new global::System.ArgumentNullException(nameof(customerId));
        accessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));

        // Mubert's public endpoints require BOTH customer-id and access-token as headers.
        // AutoSDK only injects a single bearer scheme, so we skip the Authorizations
        // list entirely and set both headers on DefaultRequestHeaders so every sub-client
        // (Public, PublicService, Service) inherits them.
        Authorizations.Clear();

        HttpClient.DefaultRequestHeaders.Remove("customer-id");
        HttpClient.DefaultRequestHeaders.Remove("access-token");
        HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("customer-id", customerId);
        HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("access-token", accessToken);
    }

    /// <summary>
    /// Creates a new <see cref="MubertClient"/> with dual-header authentication for the
    /// service endpoints (<c>company-id</c> + <c>license-token</c>).
    /// </summary>
    /// <param name="companyId">Your Mubert company id.</param>
    /// <param name="licenseToken">Your Mubert license token.</param>
    /// <param name="serviceScope">Unused marker parameter to disambiguate the service-auth overload.</param>
    /// <param name="httpClient">Optional <see cref="global::System.Net.Http.HttpClient"/> instance.</param>
    /// <param name="baseUri">Optional base URI override. Defaults to <c>https://music-api.mubert.com</c>.</param>
    /// <param name="disposeHttpClient">Whether to dispose the HTTP client when this client is disposed.</param>
    public MubertClient(
        string companyId,
        string licenseToken,
        MubertServiceScope serviceScope,
        global::System.Net.Http.HttpClient? httpClient = null,
        global::System.Uri? baseUri = null,
        bool disposeHttpClient = true) : this(
            httpClient,
            baseUri ?? new global::System.Uri(DefaultBaseUrlValue),
            authorizations: null,
            disposeHttpClient: disposeHttpClient)
    {
        _ = serviceScope;
        companyId = companyId ?? throw new global::System.ArgumentNullException(nameof(companyId));
        licenseToken = licenseToken ?? throw new global::System.ArgumentNullException(nameof(licenseToken));

        Authorizations.Clear();

        HttpClient.DefaultRequestHeaders.Remove("company-id");
        HttpClient.DefaultRequestHeaders.Remove("license-token");
        HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("company-id", companyId);
        HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("license-token", licenseToken);
    }

    [global::System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Performance",
        "CA1822:Mark members as static",
        Justification = "Required partial method signature.")]
    partial void Initialized(global::System.Net.Http.HttpClient client)
    {
        // The Mubert OpenAPI spec does not declare a servers[] entry, so the
        // generated DefaultBaseUrl is empty. Ensure a sensible default so users
        // don't have to pass a baseUri every time.
        if (client.BaseAddress is null)
        {
            client.BaseAddress = new global::System.Uri(DefaultBaseUrlValue);
        }
    }
}

/// <summary>
/// Disambiguator for the <see cref="MubertClient"/> service-auth constructor.
/// Use <see cref="Service"/> to opt into <c>company-id</c>/<c>license-token</c> auth.
/// </summary>
public enum MubertServiceScope
{
    /// <summary>
    /// Service-level auth using <c>company-id</c> + <c>license-token</c> headers.
    /// </summary>
    Service,
}
