#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrackGenerationCustomerServiceIndexResource : global::System.IEquatable<TrackGenerationCustomerServiceIndexResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.TrackGenerationServiceResource? TrackGenerationServiceResource { get; init; }
#else
        public global::Mubert.TrackGenerationServiceResource? TrackGenerationServiceResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackGenerationServiceResource))]
#endif
        public bool IsTrackGenerationServiceResource => TrackGenerationServiceResource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackGenerationCustomerServiceIndexResource(global::Mubert.TrackGenerationServiceResource value) => new TrackGenerationCustomerServiceIndexResource((global::Mubert.TrackGenerationServiceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackGenerationServiceResource?(TrackGenerationCustomerServiceIndexResource @this) => @this.TrackGenerationServiceResource;

        /// <summary>
        /// 
        /// </summary>
        public TrackGenerationCustomerServiceIndexResource(global::Mubert.TrackGenerationServiceResource? value)
        {
            TrackGenerationServiceResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrackGenerationServiceResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TrackGenerationServiceResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTrackGenerationServiceResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.TrackGenerationServiceResource?, TResult>? trackGenerationServiceResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackGenerationServiceResource && trackGenerationServiceResource != null)
            {
                return trackGenerationServiceResource(TrackGenerationServiceResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.TrackGenerationServiceResource?>? trackGenerationServiceResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackGenerationServiceResource)
            {
                trackGenerationServiceResource?.Invoke(TrackGenerationServiceResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TrackGenerationServiceResource,
                typeof(global::Mubert.TrackGenerationServiceResource),
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
        public bool Equals(TrackGenerationCustomerServiceIndexResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackGenerationServiceResource?>.Default.Equals(TrackGenerationServiceResource, other.TrackGenerationServiceResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrackGenerationCustomerServiceIndexResource obj1, TrackGenerationCustomerServiceIndexResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackGenerationCustomerServiceIndexResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrackGenerationCustomerServiceIndexResource obj1, TrackGenerationCustomerServiceIndexResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackGenerationCustomerServiceIndexResource o && Equals(o);
        }
    }
}
