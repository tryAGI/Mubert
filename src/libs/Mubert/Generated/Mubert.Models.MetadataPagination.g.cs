
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Pagination metadata
    /// </summary>
    public sealed partial class MetadataPagination
    {
        /// <summary>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataPagination" /> class.
        /// </summary>
        /// <param name="total">
        /// Example: 1000
        /// </param>
        /// <param name="limit">
        /// Example: 100
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataPagination(
            int? total,
            int? limit,
            int? offset)
        {
            this.Total = total;
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataPagination" /> class.
        /// </summary>
        public MetadataPagination()
        {
        }
    }
}