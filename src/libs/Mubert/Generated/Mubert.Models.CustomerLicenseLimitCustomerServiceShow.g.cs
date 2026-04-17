#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomerLicenseLimitCustomerServiceShow : global::System.IEquatable<CustomerLicenseLimitCustomerServiceShow>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.CustomerLicenseLimitServiceResource? Resource { get; init; }
#else
        public global::Mubert.CustomerLicenseLimitServiceResource? Resource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Resource))]
#endif
        public bool IsResource => Resource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomerLicenseLimitCustomerServiceShow(global::Mubert.CustomerLicenseLimitServiceResource value) => new CustomerLicenseLimitCustomerServiceShow((global::Mubert.CustomerLicenseLimitServiceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.CustomerLicenseLimitServiceResource?(CustomerLicenseLimitCustomerServiceShow @this) => @this.Resource;

        /// <summary>
        /// 
        /// </summary>
        public CustomerLicenseLimitCustomerServiceShow(global::Mubert.CustomerLicenseLimitServiceResource? value)
        {
            Resource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Resource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Resource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.CustomerLicenseLimitServiceResource?, TResult>? resource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResource && resource != null)
            {
                return resource(Resource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.CustomerLicenseLimitServiceResource?>? resource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResource)
            {
                resource?.Invoke(Resource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Resource,
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
        public bool Equals(CustomerLicenseLimitCustomerServiceShow other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.CustomerLicenseLimitServiceResource?>.Default.Equals(Resource, other.Resource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomerLicenseLimitCustomerServiceShow obj1, CustomerLicenseLimitCustomerServiceShow obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomerLicenseLimitCustomerServiceShow>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomerLicenseLimitCustomerServiceShow obj1, CustomerLicenseLimitCustomerServiceShow obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomerLicenseLimitCustomerServiceShow o && Equals(o);
        }
    }
}
