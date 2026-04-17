#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AccessTokenCustomerServiceShow : global::System.IEquatable<AccessTokenCustomerServiceShow>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.AccessTokenServiceResource? Resource { get; init; }
#else
        public global::Mubert.AccessTokenServiceResource? Resource { get; }
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
        public static implicit operator AccessTokenCustomerServiceShow(global::Mubert.AccessTokenServiceResource value) => new AccessTokenCustomerServiceShow((global::Mubert.AccessTokenServiceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.AccessTokenServiceResource?(AccessTokenCustomerServiceShow @this) => @this.Resource;

        /// <summary>
        /// 
        /// </summary>
        public AccessTokenCustomerServiceShow(global::Mubert.AccessTokenServiceResource? value)
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
            global::System.Func<global::Mubert.AccessTokenServiceResource?, TResult>? resource = null,
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
            global::System.Action<global::Mubert.AccessTokenServiceResource?>? resource = null,
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
        public bool Equals(AccessTokenCustomerServiceShow other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.AccessTokenServiceResource?>.Default.Equals(Resource, other.Resource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AccessTokenCustomerServiceShow obj1, AccessTokenCustomerServiceShow obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AccessTokenCustomerServiceShow>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AccessTokenCustomerServiceShow obj1, AccessTokenCustomerServiceShow obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AccessTokenCustomerServiceShow o && Equals(o);
        }
    }
}
