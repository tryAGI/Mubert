
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Detailed context of the error, providing additional debug information.
    /// </summary>
    public sealed partial class RenderApiExceptionContext
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}