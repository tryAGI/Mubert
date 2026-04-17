
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Mubert AI Music API for B2B integrations. Generate music tracks, manage streaming, and control customer accounts.<br/>
    /// ### AI-optimized documentation<br/>
    /// - [llms.txt](https://music-api.mubert.com/swagger-doc/llms.txt) — short endpoint index for AI agents<br/>
    /// - [llms-full.txt](https://music-api.mubert.com/swagger-doc/llms-full.txt) — full reference with parameters and models<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IMubertClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Mubert.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Mubert.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Public.
        /// </summary>
        public PublicClient Public { get; }

        /// <summary>
        /// Public Service.
        /// </summary>
        public PublicServiceClient PublicService { get; }

        /// <summary>
        /// Service.
        /// </summary>
        public ServiceClient Service { get; }

    }
}