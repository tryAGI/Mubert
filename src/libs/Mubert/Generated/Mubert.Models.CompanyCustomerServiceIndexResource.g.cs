#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CompanyCustomerServiceIndexResource : global::System.IEquatable<CompanyCustomerServiceIndexResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.CompanyServiceResource? CompanyServiceResource { get; init; }
#else
        public global::Mubert.CompanyServiceResource? CompanyServiceResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompanyServiceResource))]
#endif
        public bool IsCompanyServiceResource => CompanyServiceResource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompanyCustomerServiceIndexResource(global::Mubert.CompanyServiceResource value) => new CompanyCustomerServiceIndexResource((global::Mubert.CompanyServiceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.CompanyServiceResource?(CompanyCustomerServiceIndexResource @this) => @this.CompanyServiceResource;

        /// <summary>
        /// 
        /// </summary>
        public CompanyCustomerServiceIndexResource(global::Mubert.CompanyServiceResource? value)
        {
            CompanyServiceResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompanyServiceResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CompanyServiceResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompanyServiceResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.CompanyServiceResource?, TResult>? companyServiceResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompanyServiceResource && companyServiceResource != null)
            {
                return companyServiceResource(CompanyServiceResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.CompanyServiceResource?>? companyServiceResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompanyServiceResource)
            {
                companyServiceResource?.Invoke(CompanyServiceResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CompanyServiceResource,
                typeof(global::Mubert.CompanyServiceResource),
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
        public bool Equals(CompanyCustomerServiceIndexResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.CompanyServiceResource?>.Default.Equals(CompanyServiceResource, other.CompanyServiceResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompanyCustomerServiceIndexResource obj1, CompanyCustomerServiceIndexResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompanyCustomerServiceIndexResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompanyCustomerServiceIndexResource obj1, CompanyCustomerServiceIndexResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompanyCustomerServiceIndexResource o && Equals(o);
        }
    }
}
