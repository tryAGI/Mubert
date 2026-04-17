#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomerShowPublicResource : global::System.IEquatable<CustomerShowPublicResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.CustomerPublicResource? CustomerPublicResource { get; init; }
#else
        public global::Mubert.CustomerPublicResource? CustomerPublicResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomerPublicResource))]
#endif
        public bool IsCustomerPublicResource => CustomerPublicResource != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.CustomerShowPublicResourceVariant2? CustomerShowPublicResourceVariant2 { get; init; }
#else
        public global::Mubert.CustomerShowPublicResourceVariant2? CustomerShowPublicResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomerShowPublicResourceVariant2))]
#endif
        public bool IsCustomerShowPublicResourceVariant2 => CustomerShowPublicResourceVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomerShowPublicResource(global::Mubert.CustomerPublicResource value) => new CustomerShowPublicResource((global::Mubert.CustomerPublicResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.CustomerPublicResource?(CustomerShowPublicResource @this) => @this.CustomerPublicResource;

        /// <summary>
        /// 
        /// </summary>
        public CustomerShowPublicResource(global::Mubert.CustomerPublicResource? value)
        {
            CustomerPublicResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomerShowPublicResource(global::Mubert.CustomerShowPublicResourceVariant2 value) => new CustomerShowPublicResource((global::Mubert.CustomerShowPublicResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.CustomerShowPublicResourceVariant2?(CustomerShowPublicResource @this) => @this.CustomerShowPublicResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CustomerShowPublicResource(global::Mubert.CustomerShowPublicResourceVariant2? value)
        {
            CustomerShowPublicResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomerShowPublicResource(
            global::Mubert.CustomerPublicResource? customerPublicResource,
            global::Mubert.CustomerShowPublicResourceVariant2? customerShowPublicResourceVariant2
            )
        {
            CustomerPublicResource = customerPublicResource;
            CustomerShowPublicResourceVariant2 = customerShowPublicResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomerShowPublicResourceVariant2 as object ??
            CustomerPublicResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CustomerPublicResource?.ToString() ??
            CustomerShowPublicResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomerPublicResource && IsCustomerShowPublicResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.CustomerPublicResource?, TResult>? customerPublicResource = null,
            global::System.Func<global::Mubert.CustomerShowPublicResourceVariant2?, TResult>? customerShowPublicResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerPublicResource && customerPublicResource != null)
            {
                return customerPublicResource(CustomerPublicResource!);
            }
            else if (IsCustomerShowPublicResourceVariant2 && customerShowPublicResourceVariant2 != null)
            {
                return customerShowPublicResourceVariant2(CustomerShowPublicResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.CustomerPublicResource?>? customerPublicResource = null,
            global::System.Action<global::Mubert.CustomerShowPublicResourceVariant2?>? customerShowPublicResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerPublicResource)
            {
                customerPublicResource?.Invoke(CustomerPublicResource!);
            }
            else if (IsCustomerShowPublicResourceVariant2)
            {
                customerShowPublicResourceVariant2?.Invoke(CustomerShowPublicResourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CustomerPublicResource,
                typeof(global::Mubert.CustomerPublicResource),
                CustomerShowPublicResourceVariant2,
                typeof(global::Mubert.CustomerShowPublicResourceVariant2),
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
        public bool Equals(CustomerShowPublicResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.CustomerPublicResource?>.Default.Equals(CustomerPublicResource, other.CustomerPublicResource) &&
                global::System.Collections.Generic.EqualityComparer<global::Mubert.CustomerShowPublicResourceVariant2?>.Default.Equals(CustomerShowPublicResourceVariant2, other.CustomerShowPublicResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomerShowPublicResource obj1, CustomerShowPublicResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomerShowPublicResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomerShowPublicResource obj1, CustomerShowPublicResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomerShowPublicResource o && Equals(o);
        }
    }
}
