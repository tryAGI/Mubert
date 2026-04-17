#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LicenseIndexPublicResource : global::System.IEquatable<LicenseIndexPublicResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.LicensePublicResource? LicensePublicResource { get; init; }
#else
        public global::Mubert.LicensePublicResource? LicensePublicResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LicensePublicResource))]
#endif
        public bool IsLicensePublicResource => LicensePublicResource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LicenseIndexPublicResource(global::Mubert.LicensePublicResource value) => new LicenseIndexPublicResource((global::Mubert.LicensePublicResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.LicensePublicResource?(LicenseIndexPublicResource @this) => @this.LicensePublicResource;

        /// <summary>
        /// 
        /// </summary>
        public LicenseIndexPublicResource(global::Mubert.LicensePublicResource? value)
        {
            LicensePublicResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LicensePublicResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LicensePublicResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLicensePublicResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.LicensePublicResource?, TResult>? licensePublicResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLicensePublicResource && licensePublicResource != null)
            {
                return licensePublicResource(LicensePublicResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.LicensePublicResource?>? licensePublicResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLicensePublicResource)
            {
                licensePublicResource?.Invoke(LicensePublicResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LicensePublicResource,
                typeof(global::Mubert.LicensePublicResource),
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
        public bool Equals(LicenseIndexPublicResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.LicensePublicResource?>.Default.Equals(LicensePublicResource, other.LicensePublicResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LicenseIndexPublicResource obj1, LicenseIndexPublicResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LicenseIndexPublicResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LicenseIndexPublicResource obj1, LicenseIndexPublicResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LicenseIndexPublicResource o && Equals(o);
        }
    }
}
