#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CompanyShowPublicResource : global::System.IEquatable<CompanyShowPublicResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.CompanyPublicResource? CompanyPublicResource { get; init; }
#else
        public global::Mubert.CompanyPublicResource? CompanyPublicResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompanyPublicResource))]
#endif
        public bool IsCompanyPublicResource => CompanyPublicResource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompanyShowPublicResource(global::Mubert.CompanyPublicResource value) => new CompanyShowPublicResource((global::Mubert.CompanyPublicResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.CompanyPublicResource?(CompanyShowPublicResource @this) => @this.CompanyPublicResource;

        /// <summary>
        /// 
        /// </summary>
        public CompanyShowPublicResource(global::Mubert.CompanyPublicResource? value)
        {
            CompanyPublicResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompanyPublicResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CompanyPublicResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompanyPublicResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.CompanyPublicResource?, TResult>? companyPublicResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompanyPublicResource && companyPublicResource != null)
            {
                return companyPublicResource(CompanyPublicResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.CompanyPublicResource?>? companyPublicResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompanyPublicResource)
            {
                companyPublicResource?.Invoke(CompanyPublicResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CompanyPublicResource,
                typeof(global::Mubert.CompanyPublicResource),
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
        public bool Equals(CompanyShowPublicResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.CompanyPublicResource?>.Default.Equals(CompanyPublicResource, other.CompanyPublicResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompanyShowPublicResource obj1, CompanyShowPublicResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompanyShowPublicResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompanyShowPublicResource obj1, CompanyShowPublicResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompanyShowPublicResource o && Equals(o);
        }
    }
}
