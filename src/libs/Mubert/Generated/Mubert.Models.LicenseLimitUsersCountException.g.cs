
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the license limit on the number of users has been exceeded.
    /// </summary>
    public sealed partial class LicenseLimitUsersCountException
    {
        /// <summary>
        /// Example: The limit of the number of users has been exceeded
        /// </summary>
        /// <example>The limit of the number of users has been exceeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Maximum allowed number of users for this license.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("customers_count_limit")]
        public int? CustomersCountLimit { get; set; }

        /// <summary>
        /// Example: LicenseLimitUsersCount
        /// </summary>
        /// <example>LicenseLimitUsersCount</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseLimitUsersCountException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: The limit of the number of users has been exceeded
        /// </param>
        /// <param name="customersCountLimit">
        /// Maximum allowed number of users for this license.<br/>
        /// Example: 100
        /// </param>
        /// <param name="code">
        /// Example: LicenseLimitUsersCount
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseLimitUsersCountException(
            string? message,
            int? customersCountLimit,
            string? code)
        {
            this.Message = message;
            this.CustomersCountLimit = customersCountLimit;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseLimitUsersCountException" /> class.
        /// </summary>
        public LicenseLimitUsersCountException()
        {
        }
    }
}