#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrackStoreCustomerServiceIndexResource : global::System.IEquatable<TrackStoreCustomerServiceIndexResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.TrackStoreServiceResource? TrackStoreServiceResource { get; init; }
#else
        public global::Mubert.TrackStoreServiceResource? TrackStoreServiceResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackStoreServiceResource))]
#endif
        public bool IsTrackStoreServiceResource => TrackStoreServiceResource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackStoreCustomerServiceIndexResource(global::Mubert.TrackStoreServiceResource value) => new TrackStoreCustomerServiceIndexResource((global::Mubert.TrackStoreServiceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackStoreServiceResource?(TrackStoreCustomerServiceIndexResource @this) => @this.TrackStoreServiceResource;

        /// <summary>
        /// 
        /// </summary>
        public TrackStoreCustomerServiceIndexResource(global::Mubert.TrackStoreServiceResource? value)
        {
            TrackStoreServiceResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrackStoreServiceResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TrackStoreServiceResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTrackStoreServiceResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.TrackStoreServiceResource?, TResult>? trackStoreServiceResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackStoreServiceResource && trackStoreServiceResource != null)
            {
                return trackStoreServiceResource(TrackStoreServiceResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.TrackStoreServiceResource?>? trackStoreServiceResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackStoreServiceResource)
            {
                trackStoreServiceResource?.Invoke(TrackStoreServiceResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TrackStoreServiceResource,
                typeof(global::Mubert.TrackStoreServiceResource),
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
        public bool Equals(TrackStoreCustomerServiceIndexResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackStoreServiceResource?>.Default.Equals(TrackStoreServiceResource, other.TrackStoreServiceResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrackStoreCustomerServiceIndexResource obj1, TrackStoreCustomerServiceIndexResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackStoreCustomerServiceIndexResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrackStoreCustomerServiceIndexResource obj1, TrackStoreCustomerServiceIndexResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackStoreCustomerServiceIndexResource o && Equals(o);
        }
    }
}
