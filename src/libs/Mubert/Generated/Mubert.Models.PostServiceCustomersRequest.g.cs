
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostServiceCustomersRequest
    {
        /// <summary>
        /// A unique identifier for the customer.<br/>
        /// Example: customer123
        /// </summary>
        /// <example>customer123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostServiceCustomersRequest" /> class.
        /// </summary>
        /// <param name="customId">
        /// A unique identifier for the customer.<br/>
        /// Example: customer123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostServiceCustomersRequest(
            string customId)
        {
            this.CustomId = customId ?? throw new global::System.ArgumentNullException(nameof(customId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostServiceCustomersRequest" /> class.
        /// </summary>
        public PostServiceCustomersRequest()
        {
        }
    }
}