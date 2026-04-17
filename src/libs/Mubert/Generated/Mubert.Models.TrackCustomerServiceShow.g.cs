#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrackCustomerServiceShow : global::System.IEquatable<TrackCustomerServiceShow>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.TrackServiceResource? Resource { get; init; }
#else
        public global::Mubert.TrackServiceResource? Resource { get; }
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
        public global::Mubert.TrackCustomerServiceShowVariant2? TrackCustomerServiceShowVariant2 { get; init; }
#else
        public global::Mubert.TrackCustomerServiceShowVariant2? TrackCustomerServiceShowVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackCustomerServiceShowVariant2))]
#endif
        public bool IsTrackCustomerServiceShowVariant2 => TrackCustomerServiceShowVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackCustomerServiceShow(global::Mubert.TrackServiceResource value) => new TrackCustomerServiceShow((global::Mubert.TrackServiceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackServiceResource?(TrackCustomerServiceShow @this) => @this.Resource;

        /// <summary>
        /// 
        /// </summary>
        public TrackCustomerServiceShow(global::Mubert.TrackServiceResource? value)
        {
            Resource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackCustomerServiceShow(global::Mubert.TrackCustomerServiceShowVariant2 value) => new TrackCustomerServiceShow((global::Mubert.TrackCustomerServiceShowVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackCustomerServiceShowVariant2?(TrackCustomerServiceShow @this) => @this.TrackCustomerServiceShowVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TrackCustomerServiceShow(global::Mubert.TrackCustomerServiceShowVariant2? value)
        {
            TrackCustomerServiceShowVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TrackCustomerServiceShow(
            global::Mubert.TrackServiceResource? resource,
            global::Mubert.TrackCustomerServiceShowVariant2? trackCustomerServiceShowVariant2
            )
        {
            Resource = resource;
            TrackCustomerServiceShowVariant2 = trackCustomerServiceShowVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrackCustomerServiceShowVariant2 as object ??
            Resource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Resource?.ToString() ??
            TrackCustomerServiceShowVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResource && IsTrackCustomerServiceShowVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.TrackServiceResource?, TResult>? resource = null,
            global::System.Func<global::Mubert.TrackCustomerServiceShowVariant2?, TResult>? trackCustomerServiceShowVariant2 = null,
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
            else if (IsTrackCustomerServiceShowVariant2 && trackCustomerServiceShowVariant2 != null)
            {
                return trackCustomerServiceShowVariant2(TrackCustomerServiceShowVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.TrackServiceResource?>? resource = null,
            global::System.Action<global::Mubert.TrackCustomerServiceShowVariant2?>? trackCustomerServiceShowVariant2 = null,
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
            else if (IsTrackCustomerServiceShowVariant2)
            {
                trackCustomerServiceShowVariant2?.Invoke(TrackCustomerServiceShowVariant2!);
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
                typeof(global::Mubert.TrackServiceResource),
                TrackCustomerServiceShowVariant2,
                typeof(global::Mubert.TrackCustomerServiceShowVariant2),
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
        public bool Equals(TrackCustomerServiceShow other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackServiceResource?>.Default.Equals(Resource, other.Resource) &&
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackCustomerServiceShowVariant2?>.Default.Equals(TrackCustomerServiceShowVariant2, other.TrackCustomerServiceShowVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrackCustomerServiceShow obj1, TrackCustomerServiceShow obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackCustomerServiceShow>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrackCustomerServiceShow obj1, TrackCustomerServiceShow obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackCustomerServiceShow o && Equals(o);
        }
    }
}
