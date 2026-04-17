#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrackGenerationShowPublicResource : global::System.IEquatable<TrackGenerationShowPublicResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.TrackGenerationPublicResource? TrackGenerationPublicResource { get; init; }
#else
        public global::Mubert.TrackGenerationPublicResource? TrackGenerationPublicResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackGenerationPublicResource))]
#endif
        public bool IsTrackGenerationPublicResource => TrackGenerationPublicResource != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.TrackGenerationShowPublicResourceVariant2? TrackGenerationShowPublicResourceVariant2 { get; init; }
#else
        public global::Mubert.TrackGenerationShowPublicResourceVariant2? TrackGenerationShowPublicResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackGenerationShowPublicResourceVariant2))]
#endif
        public bool IsTrackGenerationShowPublicResourceVariant2 => TrackGenerationShowPublicResourceVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackGenerationShowPublicResource(global::Mubert.TrackGenerationPublicResource value) => new TrackGenerationShowPublicResource((global::Mubert.TrackGenerationPublicResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackGenerationPublicResource?(TrackGenerationShowPublicResource @this) => @this.TrackGenerationPublicResource;

        /// <summary>
        /// 
        /// </summary>
        public TrackGenerationShowPublicResource(global::Mubert.TrackGenerationPublicResource? value)
        {
            TrackGenerationPublicResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackGenerationShowPublicResource(global::Mubert.TrackGenerationShowPublicResourceVariant2 value) => new TrackGenerationShowPublicResource((global::Mubert.TrackGenerationShowPublicResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackGenerationShowPublicResourceVariant2?(TrackGenerationShowPublicResource @this) => @this.TrackGenerationShowPublicResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TrackGenerationShowPublicResource(global::Mubert.TrackGenerationShowPublicResourceVariant2? value)
        {
            TrackGenerationShowPublicResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TrackGenerationShowPublicResource(
            global::Mubert.TrackGenerationPublicResource? trackGenerationPublicResource,
            global::Mubert.TrackGenerationShowPublicResourceVariant2? trackGenerationShowPublicResourceVariant2
            )
        {
            TrackGenerationPublicResource = trackGenerationPublicResource;
            TrackGenerationShowPublicResourceVariant2 = trackGenerationShowPublicResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrackGenerationShowPublicResourceVariant2 as object ??
            TrackGenerationPublicResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TrackGenerationPublicResource?.ToString() ??
            TrackGenerationShowPublicResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTrackGenerationPublicResource && IsTrackGenerationShowPublicResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.TrackGenerationPublicResource?, TResult>? trackGenerationPublicResource = null,
            global::System.Func<global::Mubert.TrackGenerationShowPublicResourceVariant2?, TResult>? trackGenerationShowPublicResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackGenerationPublicResource && trackGenerationPublicResource != null)
            {
                return trackGenerationPublicResource(TrackGenerationPublicResource!);
            }
            else if (IsTrackGenerationShowPublicResourceVariant2 && trackGenerationShowPublicResourceVariant2 != null)
            {
                return trackGenerationShowPublicResourceVariant2(TrackGenerationShowPublicResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.TrackGenerationPublicResource?>? trackGenerationPublicResource = null,
            global::System.Action<global::Mubert.TrackGenerationShowPublicResourceVariant2?>? trackGenerationShowPublicResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackGenerationPublicResource)
            {
                trackGenerationPublicResource?.Invoke(TrackGenerationPublicResource!);
            }
            else if (IsTrackGenerationShowPublicResourceVariant2)
            {
                trackGenerationShowPublicResourceVariant2?.Invoke(TrackGenerationShowPublicResourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TrackGenerationPublicResource,
                typeof(global::Mubert.TrackGenerationPublicResource),
                TrackGenerationShowPublicResourceVariant2,
                typeof(global::Mubert.TrackGenerationShowPublicResourceVariant2),
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
        public bool Equals(TrackGenerationShowPublicResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackGenerationPublicResource?>.Default.Equals(TrackGenerationPublicResource, other.TrackGenerationPublicResource) &&
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackGenerationShowPublicResourceVariant2?>.Default.Equals(TrackGenerationShowPublicResourceVariant2, other.TrackGenerationShowPublicResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrackGenerationShowPublicResource obj1, TrackGenerationShowPublicResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackGenerationShowPublicResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrackGenerationShowPublicResource obj1, TrackGenerationShowPublicResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackGenerationShowPublicResource o && Equals(o);
        }
    }
}
