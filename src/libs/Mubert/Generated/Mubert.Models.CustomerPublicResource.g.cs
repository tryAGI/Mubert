
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerPublicResource
    {
        /// <summary>
        /// Customer ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Associated company ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_id")]
        public global::System.Guid? CompanyId { get; set; }

        /// <summary>
        /// Custom identifier for the customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// Customer status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPublicResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Customer ID
        /// </param>
        /// <param name="companyId">
        /// Associated company ID
        /// </param>
        /// <param name="customId">
        /// Custom identifier for the customer
        /// </param>
        /// <param name="status">
        /// Customer status
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerPublicResource(
            global::System.Guid? id,
            global::System.Guid? companyId,
            string? customId,
            string? status)
        {
            this.Id = id;
            this.CompanyId = companyId;
            this.CustomId = customId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPublicResource" /> class.
        /// </summary>
        public CustomerPublicResource()
        {
        }
    }
}