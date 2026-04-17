
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Error403ResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.Error403ResponseDiscriminatorCodeJsonConverter))]
        public global::Mubert.Error403ResponseDiscriminatorCode? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error403ResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error403ResponseDiscriminator(
            global::Mubert.Error403ResponseDiscriminatorCode? code)
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error403ResponseDiscriminator" /> class.
        /// </summary>
        public Error403ResponseDiscriminator()
        {
        }
    }
}