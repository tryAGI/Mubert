#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrackCustomerServiceIndexResource : global::System.IEquatable<TrackCustomerServiceIndexResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.TrackServiceResource? TrackServiceResource { get; init; }
#else
        public global::Mubert.TrackServiceResource? TrackServiceResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackServiceResource))]
#endif
        public bool IsTrackServiceResource => TrackServiceResource != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTrackServiceResource(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mubert.TrackServiceResource? value)
        {
            value = TrackServiceResource;
            return IsTrackServiceResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mubert.TrackServiceResource PickTrackServiceResource() => IsTrackServiceResource
            ? TrackServiceResource!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TrackServiceResource' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.TrackCustomerServiceIndexResourceVariant2? TrackCustomerServiceIndexResourceVariant2 { get; init; }
#else
        public global::Mubert.TrackCustomerServiceIndexResourceVariant2? TrackCustomerServiceIndexResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackCustomerServiceIndexResourceVariant2))]
#endif
        public bool IsTrackCustomerServiceIndexResourceVariant2 => TrackCustomerServiceIndexResourceVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTrackCustomerServiceIndexResourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mubert.TrackCustomerServiceIndexResourceVariant2? value)
        {
            value = TrackCustomerServiceIndexResourceVariant2;
            return IsTrackCustomerServiceIndexResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mubert.TrackCustomerServiceIndexResourceVariant2 PickTrackCustomerServiceIndexResourceVariant2() => IsTrackCustomerServiceIndexResourceVariant2
            ? TrackCustomerServiceIndexResourceVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TrackCustomerServiceIndexResourceVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackCustomerServiceIndexResource(global::Mubert.TrackServiceResource value) => new TrackCustomerServiceIndexResource((global::Mubert.TrackServiceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackServiceResource?(TrackCustomerServiceIndexResource @this) => @this.TrackServiceResource;

        /// <summary>
        /// 
        /// </summary>
        public TrackCustomerServiceIndexResource(global::Mubert.TrackServiceResource? value)
        {
            TrackServiceResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TrackCustomerServiceIndexResource FromTrackServiceResource(global::Mubert.TrackServiceResource? value) => new TrackCustomerServiceIndexResource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackCustomerServiceIndexResource(global::Mubert.TrackCustomerServiceIndexResourceVariant2 value) => new TrackCustomerServiceIndexResource((global::Mubert.TrackCustomerServiceIndexResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.TrackCustomerServiceIndexResourceVariant2?(TrackCustomerServiceIndexResource @this) => @this.TrackCustomerServiceIndexResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TrackCustomerServiceIndexResource(global::Mubert.TrackCustomerServiceIndexResourceVariant2? value)
        {
            TrackCustomerServiceIndexResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TrackCustomerServiceIndexResource FromTrackCustomerServiceIndexResourceVariant2(global::Mubert.TrackCustomerServiceIndexResourceVariant2? value) => new TrackCustomerServiceIndexResource(value);

        /// <summary>
        /// 
        /// </summary>
        public TrackCustomerServiceIndexResource(
            global::Mubert.TrackServiceResource? trackServiceResource,
            global::Mubert.TrackCustomerServiceIndexResourceVariant2? trackCustomerServiceIndexResourceVariant2
            )
        {
            TrackServiceResource = trackServiceResource;
            TrackCustomerServiceIndexResourceVariant2 = trackCustomerServiceIndexResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrackCustomerServiceIndexResourceVariant2 as object ??
            TrackServiceResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TrackServiceResource?.ToString() ??
            TrackCustomerServiceIndexResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTrackServiceResource && IsTrackCustomerServiceIndexResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.TrackServiceResource, TResult>? trackServiceResource = null,
            global::System.Func<global::Mubert.TrackCustomerServiceIndexResourceVariant2, TResult>? trackCustomerServiceIndexResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackServiceResource && trackServiceResource != null)
            {
                return trackServiceResource(TrackServiceResource!);
            }
            else if (IsTrackCustomerServiceIndexResourceVariant2 && trackCustomerServiceIndexResourceVariant2 != null)
            {
                return trackCustomerServiceIndexResourceVariant2(TrackCustomerServiceIndexResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.TrackServiceResource>? trackServiceResource = null,

            global::System.Action<global::Mubert.TrackCustomerServiceIndexResourceVariant2>? trackCustomerServiceIndexResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackServiceResource)
            {
                trackServiceResource?.Invoke(TrackServiceResource!);
            }
            else if (IsTrackCustomerServiceIndexResourceVariant2)
            {
                trackCustomerServiceIndexResourceVariant2?.Invoke(TrackCustomerServiceIndexResourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Mubert.TrackServiceResource>? trackServiceResource = null,
            global::System.Action<global::Mubert.TrackCustomerServiceIndexResourceVariant2>? trackCustomerServiceIndexResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrackServiceResource)
            {
                trackServiceResource?.Invoke(TrackServiceResource!);
            }
            else if (IsTrackCustomerServiceIndexResourceVariant2)
            {
                trackCustomerServiceIndexResourceVariant2?.Invoke(TrackCustomerServiceIndexResourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TrackServiceResource,
                typeof(global::Mubert.TrackServiceResource),
                TrackCustomerServiceIndexResourceVariant2,
                typeof(global::Mubert.TrackCustomerServiceIndexResourceVariant2),
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
        public bool Equals(TrackCustomerServiceIndexResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackServiceResource?>.Default.Equals(TrackServiceResource, other.TrackServiceResource) &&
                global::System.Collections.Generic.EqualityComparer<global::Mubert.TrackCustomerServiceIndexResourceVariant2?>.Default.Equals(TrackCustomerServiceIndexResourceVariant2, other.TrackCustomerServiceIndexResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrackCustomerServiceIndexResource obj1, TrackCustomerServiceIndexResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackCustomerServiceIndexResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrackCustomerServiceIndexResource obj1, TrackCustomerServiceIndexResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackCustomerServiceIndexResource o && Equals(o);
        }
    }
}
