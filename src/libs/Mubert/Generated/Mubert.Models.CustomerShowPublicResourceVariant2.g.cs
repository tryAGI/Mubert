
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerShowPublicResourceVariant2
    {
        /// <summary>
        /// Access token associated with the customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        public global::Mubert.AccessTokenPublicResource? Access { get; set; }

        /// <summary>
        /// Company associated with the customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public global::Mubert.CompanyPublicResource? Company { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerShowPublicResourceVariant2" /> class.
        /// </summary>
        /// <param name="access">
        /// Access token associated with the customer
        /// </param>
        /// <param name="company">
        /// Company associated with the customer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerShowPublicResourceVariant2(
            global::Mubert.AccessTokenPublicResource? access,
            global::Mubert.CompanyPublicResource? company)
        {
            this.Access = access;
            this.Company = company;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerShowPublicResourceVariant2" /> class.
        /// </summary>
        public CustomerShowPublicResourceVariant2()
        {
        }
    }
}