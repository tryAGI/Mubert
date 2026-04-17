#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrackShowPublicResource : global::System.IEquatable<TrackShowPublicResource>
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
        public global::Mubert.TrackShowPublicResourceVariant2? TrackShowPublicResourceVariant2 { get; init; }
#else
        public global::Mubert.TrackShowPublicResourceVariant2? TrackShowPublicResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackShowPublicResourceVariant2))]
#endif
        public bool IsTrackShowPublicResourceVariant2 => TrackShowPublicResourceVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackShowPublicResource(global::Mubert.TrackPublicResource value) => new TrackShowPublicResource((global::Mubert.TrackPublicResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackPublicResource?(TrackShowPublicResource @this) => @this.TrackPublicResource;

        /// <summary>
        /// 
        /// </summary>
        public TrackShowPublicResource(global::Mubert.TrackPublicResource? value)
        {
            TrackPublicResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackShowPublicResource(global::Mubert.TrackShowPublicResourceVariant2 value) => new TrackShowPublicResource((global::Mubert.TrackShowPublicResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackShowPublicResourceVariant2?(TrackShowPublicResource @this) => @this.TrackShowPublicResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TrackShowPublicResource(global::Mubert.TrackShowPublicResourceVariant2? value)
        {
            TrackShowPublicResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TrackShowPublicResource(
            global::Mubert.TrackPublicResource? trackPublicResource,
            global::Mubert.TrackShowPublicResourceVariant2? trackShowPublicResourceVariant2
            )
        {
            TrackPublicResource = trackPublicResource;
            TrackShowPublicResourceVariant2 = trackShowPublicResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrackShowPublicResourceVariant2 as object ??
            TrackPublicResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TrackPublicResource?.ToString() ??
            TrackShowPublicResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTrackPublicResource && IsTrackShowPublicResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.TrackPublicResource?, TResult>? trackPublicResource = null,
            global::System.Func<global::Mubert.TrackShowPublicResourceVariant2?, TResult>? trackShowPublicResourceVariant2 = null,
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
            else if (IsTrackShowPublicResourceVariant2 && trackShowPublicResourceVariant2 != null)
            {
                return trackShowPublicResourceVariant2(TrackShowPublicResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.TrackPublicResource?>? trackPublicResource = null,
            global::System.Action<global::Mubert.TrackShowPublicResourceVariant2?>? trackShowPublicResourceVariant2 = null,
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
            else if (IsTrackShowPublicResourceVariant2)
            {
                trackShowPublicResourceVariant2?.Invoke(TrackShowPublicResourceVariant2!);
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
                TrackShowPublicResourceVariant2,
                typeof(global::Mubert.TrackShowPublicResourceVariant2),
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
        public bool Equals(TrackShowPublicResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackPublicResource?>.Default.Equals(TrackPublicResource, other.TrackPublicResource) &&
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackShowPublicResourceVariant2?>.Default.Equals(TrackShowPublicResourceVariant2, other.TrackShowPublicResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrackShowPublicResource obj1, TrackShowPublicResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackShowPublicResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrackShowPublicResource obj1, TrackShowPublicResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackShowPublicResource o && Equals(o);
        }
    }
}
