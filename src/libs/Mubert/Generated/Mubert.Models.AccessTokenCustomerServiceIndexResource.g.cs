#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AccessTokenCustomerServiceIndexResource : global::System.IEquatable<AccessTokenCustomerServiceIndexResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.AccessTokenServiceResource? AccessTokenServiceResource { get; init; }
#else
        public global::Mubert.AccessTokenServiceResource? AccessTokenServiceResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AccessTokenServiceResource))]
#endif
        public bool IsAccessTokenServiceResource => AccessTokenServiceResource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AccessTokenCustomerServiceIndexResource(global::Mubert.AccessTokenServiceResource value) => new AccessTokenCustomerServiceIndexResource((global::Mubert.AccessTokenServiceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.AccessTokenServiceResource?(AccessTokenCustomerServiceIndexResource @this) => @this.AccessTokenServiceResource;

        /// <summary>
        /// 
        /// </summary>
        public AccessTokenCustomerServiceIndexResource(global::Mubert.AccessTokenServiceResource? value)
        {
            AccessTokenServiceResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AccessTokenServiceResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AccessTokenServiceResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAccessTokenServiceResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.AccessTokenServiceResource?, TResult>? accessTokenServiceResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAccessTokenServiceResource && accessTokenServiceResource != null)
            {
                return accessTokenServiceResource(AccessTokenServiceResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.AccessTokenServiceResource?>? accessTokenServiceResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAccessTokenServiceResource)
            {
                accessTokenServiceResource?.Invoke(AccessTokenServiceResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AccessTokenServiceResource,
                typeof(global::Mubert.AccessTokenServiceResource),
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
        public bool Equals(AccessTokenCustomerServiceIndexResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.AccessTokenServiceResource?>.Default.Equals(AccessTokenServiceResource, other.AccessTokenServiceResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AccessTokenCustomerServiceIndexResource obj1, AccessTokenCustomerServiceIndexResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AccessTokenCustomerServiceIndexResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AccessTokenCustomerServiceIndexResource obj1, AccessTokenCustomerServiceIndexResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AccessTokenCustomerServiceIndexResource o && Equals(o);
        }
    }
}
