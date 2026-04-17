#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AccessTokenShowPublicResource : global::System.IEquatable<AccessTokenShowPublicResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.AccessTokenPublicResource? AccessTokenPublicResource { get; init; }
#else
        public global::Mubert.AccessTokenPublicResource? AccessTokenPublicResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AccessTokenPublicResource))]
#endif
        public bool IsAccessTokenPublicResource => AccessTokenPublicResource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AccessTokenShowPublicResource(global::Mubert.AccessTokenPublicResource value) => new AccessTokenShowPublicResource((global::Mubert.AccessTokenPublicResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.AccessTokenPublicResource?(AccessTokenShowPublicResource @this) => @this.AccessTokenPublicResource;

        /// <summary>
        /// 
        /// </summary>
        public AccessTokenShowPublicResource(global::Mubert.AccessTokenPublicResource? value)
        {
            AccessTokenPublicResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AccessTokenPublicResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AccessTokenPublicResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAccessTokenPublicResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.AccessTokenPublicResource?, TResult>? accessTokenPublicResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAccessTokenPublicResource && accessTokenPublicResource != null)
            {
                return accessTokenPublicResource(AccessTokenPublicResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.AccessTokenPublicResource?>? accessTokenPublicResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAccessTokenPublicResource)
            {
                accessTokenPublicResource?.Invoke(AccessTokenPublicResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AccessTokenPublicResource,
                typeof(global::Mubert.AccessTokenPublicResource),
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
        public bool Equals(AccessTokenShowPublicResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.AccessTokenPublicResource?>.Default.Equals(AccessTokenPublicResource, other.AccessTokenPublicResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AccessTokenShowPublicResource obj1, AccessTokenShowPublicResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AccessTokenShowPublicResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AccessTokenShowPublicResource obj1, AccessTokenShowPublicResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AccessTokenShowPublicResource o && Equals(o);
        }
    }
}
