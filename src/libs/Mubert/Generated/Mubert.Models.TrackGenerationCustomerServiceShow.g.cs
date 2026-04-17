#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrackGenerationCustomerServiceShow : global::System.IEquatable<TrackGenerationCustomerServiceShow>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.TrackGenerationServiceResource? Resource { get; init; }
#else
        public global::Mubert.TrackGenerationServiceResource? Resource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Resource))]
#endif
        public bool IsResource => Resource != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.TrackGenerationCustomerServiceShowVariant2? TrackGenerationCustomerServiceShowVariant2 { get; init; }
#else
        public global::Mubert.TrackGenerationCustomerServiceShowVariant2? TrackGenerationCustomerServiceShowVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackGenerationCustomerServiceShowVariant2))]
#endif
        public bool IsTrackGenerationCustomerServiceShowVariant2 => TrackGenerationCustomerServiceShowVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackGenerationCustomerServiceShow(global::Mubert.TrackGenerationServiceResource value) => new TrackGenerationCustomerServiceShow((global::Mubert.TrackGenerationServiceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackGenerationServiceResource?(TrackGenerationCustomerServiceShow @this) => @this.Resource;

        /// <summary>
        /// 
        /// </summary>
        public TrackGenerationCustomerServiceShow(global::Mubert.TrackGenerationServiceResource? value)
        {
            Resource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackGenerationCustomerServiceShow(global::Mubert.TrackGenerationCustomerServiceShowVariant2 value) => new TrackGenerationCustomerServiceShow((global::Mubert.TrackGenerationCustomerServiceShowVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackGenerationCustomerServiceShowVariant2?(TrackGenerationCustomerServiceShow @this) => @this.TrackGenerationCustomerServiceShowVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TrackGenerationCustomerServiceShow(global::Mubert.TrackGenerationCustomerServiceShowVariant2? value)
        {
            TrackGenerationCustomerServiceShowVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TrackGenerationCustomerServiceShow(
            global::Mubert.TrackGenerationServiceResource? resource,
            global::Mubert.TrackGenerationCustomerServiceShowVariant2? trackGenerationCustomerServiceShowVariant2
            )
        {
            Resource = resource;
            TrackGenerationCustomerServiceShowVariant2 = trackGenerationCustomerServiceShowVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrackGenerationCustomerServiceShowVariant2 as object ??
            Resource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Resource?.ToString() ??
            TrackGenerationCustomerServiceShowVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResource && IsTrackGenerationCustomerServiceShowVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.TrackGenerationServiceResource?, TResult>? resource = null,
            global::System.Func<global::Mubert.TrackGenerationCustomerServiceShowVariant2?, TResult>? trackGenerationCustomerServiceShowVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResource && resource != null)
            {
                return resource(Resource!);
            }
            else if (IsTrackGenerationCustomerServiceShowVariant2 && trackGenerationCustomerServiceShowVariant2 != null)
            {
                return trackGenerationCustomerServiceShowVariant2(TrackGenerationCustomerServiceShowVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.TrackGenerationServiceResource?>? resource = null,
            global::System.Action<global::Mubert.TrackGenerationCustomerServiceShowVariant2?>? trackGenerationCustomerServiceShowVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResource)
            {
                resource?.Invoke(Resource!);
            }
            else if (IsTrackGenerationCustomerServiceShowVariant2)
            {
                trackGenerationCustomerServiceShowVariant2?.Invoke(TrackGenerationCustomerServiceShowVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Resource,
                typeof(global::Mubert.TrackGenerationServiceResource),
                TrackGenerationCustomerServiceShowVariant2,
                typeof(global::Mubert.TrackGenerationCustomerServiceShowVariant2),
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
        public bool Equals(TrackGenerationCustomerServiceShow other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackGenerationServiceResource?>.Default.Equals(Resource, other.Resource) &&
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackGenerationCustomerServiceShowVariant2?>.Default.Equals(TrackGenerationCustomerServiceShowVariant2, other.TrackGenerationCustomerServiceShowVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrackGenerationCustomerServiceShow obj1, TrackGenerationCustomerServiceShow obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackGenerationCustomerServiceShow>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrackGenerationCustomerServiceShow obj1, TrackGenerationCustomerServiceShow obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackGenerationCustomerServiceShow o && Equals(o);
        }
    }
}
