#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomerCustomerServiceShowResourceResource : global::System.IEquatable<CustomerCustomerServiceShowResourceResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.CustomerServiceResource? CustomerServiceResource { get; init; }
#else
        public global::Mubert.CustomerServiceResource? CustomerServiceResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomerServiceResource))]
#endif
        public bool IsCustomerServiceResource => CustomerServiceResource != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.CustomerCustomerServiceShowResourceResourceVariant2? CustomerCustomerServiceShowResourceResourceVariant2 { get; init; }
#else
        public global::Mubert.CustomerCustomerServiceShowResourceResourceVariant2? CustomerCustomerServiceShowResourceResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomerCustomerServiceShowResourceResourceVariant2))]
#endif
        public bool IsCustomerCustomerServiceShowResourceResourceVariant2 => CustomerCustomerServiceShowResourceResourceVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomerCustomerServiceShowResourceResource(global::Mubert.CustomerServiceResource value) => new CustomerCustomerServiceShowResourceResource((global::Mubert.CustomerServiceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.CustomerServiceResource?(CustomerCustomerServiceShowResourceResource @this) => @this.CustomerServiceResource;

        /// <summary>
        /// 
        /// </summary>
        public CustomerCustomerServiceShowResourceResource(global::Mubert.CustomerServiceResource? value)
        {
            CustomerServiceResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomerCustomerServiceShowResourceResource(global::Mubert.CustomerCustomerServiceShowResourceResourceVariant2 value) => new CustomerCustomerServiceShowResourceResource((global::Mubert.CustomerCustomerServiceShowResourceResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.CustomerCustomerServiceShowResourceResourceVariant2?(CustomerCustomerServiceShowResourceResource @this) => @this.CustomerCustomerServiceShowResourceResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CustomerCustomerServiceShowResourceResource(global::Mubert.CustomerCustomerServiceShowResourceResourceVariant2? value)
        {
            CustomerCustomerServiceShowResourceResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomerCustomerServiceShowResourceResource(
            global::Mubert.CustomerServiceResource? customerServiceResource,
            global::Mubert.CustomerCustomerServiceShowResourceResourceVariant2? customerCustomerServiceShowResourceResourceVariant2
            )
        {
            CustomerServiceResource = customerServiceResource;
            CustomerCustomerServiceShowResourceResourceVariant2 = customerCustomerServiceShowResourceResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomerCustomerServiceShowResourceResourceVariant2 as object ??
            CustomerServiceResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CustomerServiceResource?.ToString() ??
            CustomerCustomerServiceShowResourceResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomerServiceResource && IsCustomerCustomerServiceShowResourceResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.CustomerServiceResource?, TResult>? customerServiceResource = null,
            global::System.Func<global::Mubert.CustomerCustomerServiceShowResourceResourceVariant2?, TResult>? customerCustomerServiceShowResourceResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerServiceResource && customerServiceResource != null)
            {
                return customerServiceResource(CustomerServiceResource!);
            }
            else if (IsCustomerCustomerServiceShowResourceResourceVariant2 && customerCustomerServiceShowResourceResourceVariant2 != null)
            {
                return customerCustomerServiceShowResourceResourceVariant2(CustomerCustomerServiceShowResourceResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.CustomerServiceResource?>? customerServiceResource = null,
            global::System.Action<global::Mubert.CustomerCustomerServiceShowResourceResourceVariant2?>? customerCustomerServiceShowResourceResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerServiceResource)
            {
                customerServiceResource?.Invoke(CustomerServiceResource!);
            }
            else if (IsCustomerCustomerServiceShowResourceResourceVariant2)
            {
                customerCustomerServiceShowResourceResourceVariant2?.Invoke(CustomerCustomerServiceShowResourceResourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CustomerServiceResource,
                typeof(global::Mubert.CustomerServiceResource),
                CustomerCustomerServiceShowResourceResourceVariant2,
                typeof(global::Mubert.CustomerCustomerServiceShowResourceResourceVariant2),
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
        public bool Equals(CustomerCustomerServiceShowResourceResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.CustomerServiceResource?>.Default.Equals(CustomerServiceResource, other.CustomerServiceResource) &&
                global::System.Collections.Generic.EqualityComparer<global::Mubert.CustomerCustomerServiceShowResourceResourceVariant2?>.Default.Equals(CustomerCustomerServiceShowResourceResourceVariant2, other.CustomerCustomerServiceShowResourceResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomerCustomerServiceShowResourceResource obj1, CustomerCustomerServiceShowResourceResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomerCustomerServiceShowResourceResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomerCustomerServiceShowResourceResource obj1, CustomerCustomerServiceShowResourceResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomerCustomerServiceShowResourceResource o && Equals(o);
        }
    }
}
