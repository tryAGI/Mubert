#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrackIndexPublicResource : global::System.IEquatable<TrackIndexPublicResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.TrackPublicResource? TrackPublicResource { get; init; }
#else
        public global::Mubert.TrackPublicResource? TrackPublicResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackPublicResource))]
#endif
        public bool IsTrackPublicResource => TrackPublicResource != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.TrackIndexPublicResourceVariant2? TrackIndexPublicResourceVariant2 { get; init; }
#else
        public global::Mubert.TrackIndexPublicResourceVariant2? TrackIndexPublicResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackIndexPublicResourceVariant2))]
#endif
        public bool IsTrackIndexPublicResourceVariant2 => TrackIndexPublicResourceVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackIndexPublicResource(global::Mubert.TrackPublicResource value) => new TrackIndexPublicResource((global::Mubert.TrackPublicResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackPublicResource?(TrackIndexPublicResource @this) => @this.TrackPublicResource;

        /// <summary>
        /// 
        /// </summary>
        public TrackIndexPublicResource(global::Mubert.TrackPublicResource? value)
        {
            TrackPublicResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackIndexPublicResource(global::Mubert.TrackIndexPublicResourceVariant2 value) => new TrackIndexPublicResource((global::Mubert.TrackIndexPublicResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackIndexPublicResourceVariant2?(TrackIndexPublicResource @this) => @this.TrackIndexPublicResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TrackIndexPublicResource(global::Mubert.TrackIndexPublicResourceVariant2? value)
        {
            TrackIndexPublicResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TrackIndexPublicResource(
            global::Mubert.TrackPublicResource? trackPublicResource,
            global::Mubert.TrackIndexPublicResourceVariant2? trackIndexPublicResourceVariant2
            )
        {
            TrackPublicResource = trackPublicResource;
            TrackIndexPublicResourceVariant2 = trackIndexPublicResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrackIndexPublicResourceVariant2 as object ??
            TrackPublicResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TrackPublicResource?.ToString() ??
            TrackIndexPublicResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTrackPublicResource && IsTrackIndexPublicResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.TrackPublicResource?, TResult>? trackPublicResource = null,
            global::System.Func<global::Mubert.TrackIndexPublicResourceVariant2?, TResult>? trackIndexPublicResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackPublicResource && trackPublicResource != null)
            {
                return trackPublicResource(TrackPublicResource!);
            }
            else if (IsTrackIndexPublicResourceVariant2 && trackIndexPublicResourceVariant2 != null)
            {
                return trackIndexPublicResourceVariant2(TrackIndexPublicResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.TrackPublicResource?>? trackPublicResource = null,
            global::System.Action<global::Mubert.TrackIndexPublicResourceVariant2?>? trackIndexPublicResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackPublicResource)
            {
                trackPublicResource?.Invoke(TrackPublicResource!);
            }
            else if (IsTrackIndexPublicResourceVariant2)
            {
                trackIndexPublicResourceVariant2?.Invoke(TrackIndexPublicResourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TrackPublicResource,
                typeof(global::Mubert.TrackPublicResource),
                TrackIndexPublicResourceVariant2,
                typeof(global::Mubert.TrackIndexPublicResourceVariant2),
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
        public bool Equals(TrackIndexPublicResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackPublicResource?>.Default.Equals(TrackPublicResource, other.TrackPublicResource) &&
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackIndexPublicResourceVariant2?>.Default.Equals(TrackIndexPublicResourceVariant2, other.TrackIndexPublicResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrackIndexPublicResource obj1, TrackIndexPublicResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackIndexPublicResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrackIndexPublicResource obj1, TrackIndexPublicResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackIndexPublicResource o && Equals(o);
        }
    }
}
