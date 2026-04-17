#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomerLicenseLimitIndexPublicResource : global::System.IEquatable<CustomerLicenseLimitIndexPublicResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.CustomerLicenseLimitPublicResource? CustomerLicenseLimitPublicResource { get; init; }
#else
        public global::Mubert.CustomerLicenseLimitPublicResource? CustomerLicenseLimitPublicResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomerLicenseLimitPublicResource))]
#endif
        public bool IsCustomerLicenseLimitPublicResource => CustomerLicenseLimitPublicResource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomerLicenseLimitIndexPublicResource(global::Mubert.CustomerLicenseLimitPublicResource value) => new CustomerLicenseLimitIndexPublicResource((global::Mubert.CustomerLicenseLimitPublicResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.CustomerLicenseLimitPublicResource?(CustomerLicenseLimitIndexPublicResource @this) => @this.CustomerLicenseLimitPublicResource;

        /// <summary>
        /// 
        /// </summary>
        public CustomerLicenseLimitIndexPublicResource(global::Mubert.CustomerLicenseLimitPublicResource? value)
        {
            CustomerLicenseLimitPublicResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomerLicenseLimitPublicResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CustomerLicenseLimitPublicResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomerLicenseLimitPublicResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.CustomerLicenseLimitPublicResource?, TResult>? customerLicenseLimitPublicResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerLicenseLimitPublicResource && customerLicenseLimitPublicResource != null)
            {
                return customerLicenseLimitPublicResource(CustomerLicenseLimitPublicResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.CustomerLicenseLimitPublicResource?>? customerLicenseLimitPublicResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerLicenseLimitPublicResource)
            {
                customerLicenseLimitPublicResource?.Invoke(CustomerLicenseLimitPublicResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CustomerLicenseLimitPublicResource,
                typeof(global::Mubert.CustomerLicenseLimitPublicResource),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(CustomerLicenseLimitIndexPublicResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.CustomerLicenseLimitPublicResource?>.Default.Equals(CustomerLicenseLimitPublicResource, other.CustomerLicenseLimitPublicResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomerLicenseLimitIndexPublicResource obj1, CustomerLicenseLimitIndexPublicResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomerLicenseLimitIndexPublicResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomerLicenseLimitIndexPublicResource obj1, CustomerLicenseLimitIndexPublicResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomerLicenseLimitIndexPublicResource o && Equals(o);
        }
    }
}
