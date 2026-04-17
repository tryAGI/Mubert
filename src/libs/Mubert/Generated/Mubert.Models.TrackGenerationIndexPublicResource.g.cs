#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrackGenerationIndexPublicResource : global::System.IEquatable<TrackGenerationIndexPublicResource>
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
        public static implicit operator TrackGenerationIndexPublicResource(global::Mubert.TrackGenerationPublicResource value) => new TrackGenerationIndexPublicResource((global::Mubert.TrackGenerationPublicResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackGenerationPublicResource?(TrackGenerationIndexPublicResource @this) => @this.TrackGenerationPublicResource;

        /// <summary>
        /// 
        /// </summary>
        public TrackGenerationIndexPublicResource(global::Mubert.TrackGenerationPublicResource? value)
        {
            TrackGenerationPublicResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrackGenerationPublicResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TrackGenerationPublicResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTrackGenerationPublicResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.TrackGenerationPublicResource?, TResult>? trackGenerationPublicResource = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.TrackGenerationPublicResource?>? trackGenerationPublicResource = null,
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
        public bool Equals(TrackGenerationIndexPublicResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackGenerationPublicResource?>.Default.Equals(TrackGenerationPublicResource, other.TrackGenerationPublicResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrackGenerationIndexPublicResource obj1, TrackGenerationIndexPublicResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackGenerationIndexPublicResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrackGenerationIndexPublicResource obj1, TrackGenerationIndexPublicResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackGenerationIndexPublicResource o && Equals(o);
        }
    }
}
