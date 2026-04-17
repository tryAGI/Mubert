
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPublicMusicLibraryParamsResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<global::Mubert.GetPublicMusicLibraryParamsResponseItemValue>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicMusicLibraryParamsResponseItem" /> class.
        /// </summary>
        /// <param name="param"></param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPublicMusicLibraryParamsResponseItem(
            string? param,
            global::System.Collections.Generic.IList<global::Mubert.GetPublicMusicLibraryParamsResponseItemValue>? values)
        {
            this.Param = param;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicMusicLibraryParamsResponseItem" /> class.
        /// </summary>
        public GetPublicMusicLibraryParamsResponseItem()
        {
        }
    }
}