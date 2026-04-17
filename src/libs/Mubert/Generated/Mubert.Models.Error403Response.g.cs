
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response for forbidden access errors
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = "code",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Mubert.AccessTokenExpiredException), typeDiscriminator: "AccessTokenExpired")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Mubert.CompanyIsNotActiveException), typeDiscriminator: "CompanyIsNotActive")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Mubert.CompanyIsNotActiveException), typeDiscriminator: "CustomerIsNotActive")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Mubert.ForbiddenException), typeDiscriminator: "Forbidden")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Mubert.LicenseExpiredException), typeDiscriminator: "LicenseExpired")]
    public partial class Error403Response
    {
        /// <summary>
        /// Example: Forbidden action
        /// </summary>
        /// <example>Forbidden action</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error403Response" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Forbidden action
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error403Response(
            string? message,
            string? description)
        {
            this.Message = message;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error403Response" /> class.
        /// </summary>
        public Error403Response()
        {
        }
    }
}