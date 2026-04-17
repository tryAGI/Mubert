
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating an error encountered in the Render API.
    /// </summary>
    public sealed partial class RenderApiException
    {
        /// <summary>
        /// Description of the error message.<br/>
        /// Example: Render Api Error
        /// </summary>
        /// <example>Render Api Error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Detailed context of the error, providing additional debug information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// Unique code identifying the type of Render API error.<br/>
        /// Example: RenderApi
        /// </summary>
        /// <example>RenderApi</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderApiException" /> class.
        /// </summary>
        /// <param name="message">
        /// Description of the error message.<br/>
        /// Example: Render Api Error
        /// </param>
        /// <param name="context">
        /// Detailed context of the error, providing additional debug information.
        /// </param>
        /// <param name="code">
        /// Unique code identifying the type of Render API error.<br/>
        /// Example: RenderApi
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenderApiException(
            string? message,
            object? context,
            string? code)
        {
            this.Message = message;
            this.Context = context;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderApiException" /> class.
        /// </summary>
        public RenderApiException()
        {
        }
    }
}