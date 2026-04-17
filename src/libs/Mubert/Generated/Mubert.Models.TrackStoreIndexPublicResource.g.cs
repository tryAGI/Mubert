#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrackStoreIndexPublicResource : global::System.IEquatable<TrackStoreIndexPublicResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.TrackStorePublicResource? TrackStorePublicResource { get; init; }
#else
        public global::Mubert.TrackStorePublicResource? TrackStorePublicResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackStorePublicResource))]
#endif
        public bool IsTrackStorePublicResource => TrackStorePublicResource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackStoreIndexPublicResource(global::Mubert.TrackStorePublicResource value) => new TrackStoreIndexPublicResource((global::Mubert.TrackStorePublicResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackStorePublicResource?(TrackStoreIndexPublicResource @this) => @this.TrackStorePublicResource;

        /// <summary>
        /// 
        /// </summary>
        public TrackStoreIndexPublicResource(global::Mubert.TrackStorePublicResource? value)
        {
            TrackStorePublicResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrackStorePublicResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TrackStorePublicResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTrackStorePublicResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.TrackStorePublicResource?, TResult>? trackStorePublicResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackStorePublicResource && trackStorePublicResource != null)
            {
                return trackStorePublicResource(TrackStorePublicResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.TrackStorePublicResource?>? trackStorePublicResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackStorePublicResource)
            {
                trackStorePublicResource?.Invoke(TrackStorePublicResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TrackStorePublicResource,
                typeof(global::Mubert.TrackStorePublicResource),
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
        public bool Equals(TrackStoreIndexPublicResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackStorePublicResource?>.Default.Equals(TrackStorePublicResource, other.TrackStorePublicResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrackStoreIndexPublicResource obj1, TrackStoreIndexPublicResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackStoreIndexPublicResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrackStoreIndexPublicResource obj1, TrackStoreIndexPublicResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackStoreIndexPublicResource o && Equals(o);
        }
    }
}
