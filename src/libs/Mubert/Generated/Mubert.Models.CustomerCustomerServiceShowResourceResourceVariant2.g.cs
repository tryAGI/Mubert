
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerCustomerServiceShowResourceResourceVariant2
    {
        /// <summary>
        /// Access token associated with the customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        public global::Mubert.AccessTokenServiceResource? Access { get; set; }

        /// <summary>
        /// Company associated with the customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public global::Mubert.CompanyServiceResource? Company { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCustomerServiceShowResourceResourceVariant2" /> class.
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
        public CustomerCustomerServiceShowResourceResourceVariant2(
            global::Mubert.AccessTokenServiceResource? access,
            global::Mubert.CompanyServiceResource? company)
        {
            this.Access = access;
            this.Company = company;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCustomerServiceShowResourceResourceVariant2" /> class.
        /// </summary>
        public CustomerCustomerServiceShowResourceResourceVariant2()
        {
        }
    }
}