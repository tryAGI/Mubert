#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomerLicenseLimitCustomerServiceIndexResource : global::System.IEquatable<CustomerLicenseLimitCustomerServiceIndexResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.CustomerLicenseLimitServiceResource? CustomerLicenseLimitServiceResource { get; init; }
#else
        public global::Mubert.CustomerLicenseLimitServiceResource? CustomerLicenseLimitServiceResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomerLicenseLimitServiceResource))]
#endif
        public bool IsCustomerLicenseLimitServiceResource => CustomerLicenseLimitServiceResource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomerLicenseLimitCustomerServiceIndexResource(global::Mubert.CustomerLicenseLimitServiceResource value) => new CustomerLicenseLimitCustomerServiceIndexResource((global::Mubert.CustomerLicenseLimitServiceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.CustomerLicenseLimitServiceResource?(CustomerLicenseLimitCustomerServiceIndexResource @this) => @this.CustomerLicenseLimitServiceResource;

        /// <summary>
        /// 
        /// </summary>
        public CustomerLicenseLimitCustomerServiceIndexResource(global::Mubert.CustomerLicenseLimitServiceResource? value)
        {
            CustomerLicenseLimitServiceResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomerLicenseLimitServiceResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CustomerLicenseLimitServiceResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomerLicenseLimitServiceResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.CustomerLicenseLimitServiceResource?, TResult>? customerLicenseLimitServiceResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerLicenseLimitServiceResource && customerLicenseLimitServiceResource != null)
            {
                return customerLicenseLimitServiceResource(CustomerLicenseLimitServiceResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.CustomerLicenseLimitServiceResource?>? customerLicenseLimitServiceResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerLicenseLimitServiceResource)
            {
                customerLicenseLimitServiceResource?.Invoke(CustomerLicenseLimitServiceResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CustomerLicenseLimitServiceResource,
                typeof(global::Mubert.CustomerLicenseLimitServiceResource),
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
        public bool Equals(CustomerLicenseLimitCustomerServiceIndexResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.CustomerLicenseLimitServiceResource?>.Default.Equals(CustomerLicenseLimitServiceResource, other.CustomerLicenseLimitServiceResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomerLicenseLimitCustomerServiceIndexResource obj1, CustomerLicenseLimitCustomerServiceIndexResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomerLicenseLimitCustomerServiceIndexResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomerLicenseLimitCustomerServiceIndexResource obj1, CustomerLicenseLimitCustomerServiceIndexResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomerLicenseLimitCustomerServiceIndexResource o && Equals(o);
        }
    }
}
