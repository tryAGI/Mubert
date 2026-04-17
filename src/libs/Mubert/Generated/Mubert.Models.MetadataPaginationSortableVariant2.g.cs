
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataPaginationSortableVariant2
    {
        /// <summary>
        /// Current sort field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// Order Directions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.OrderDirectionEnumJsonConverter))]
        public global::Mubert.OrderDirectionEnum? Order { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataPaginationSortableVariant2" /> class.
        /// </summary>
        /// <param name="orderBy">
        /// Current sort field
        /// </param>
        /// <param name="order">
        /// Order Directions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataPaginationSortableVariant2(
            string? orderBy,
            global::Mubert.OrderDirectionEnum? order)
        {
            this.OrderBy = orderBy;
            this.Order = order;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataPaginationSortableVariant2" /> class.
        /// </summary>
        public MetadataPaginationSortableVariant2()
        {
        }
    }
}