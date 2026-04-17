#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PlaylistCustomerServiceIndexResource : global::System.IEquatable<PlaylistCustomerServiceIndexResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.PlaylistServiceResource? PlaylistServiceResource { get; init; }
#else
        public global::Mubert.PlaylistServiceResource? PlaylistServiceResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlaylistServiceResource))]
#endif
        public bool IsPlaylistServiceResource => PlaylistServiceResource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlaylistCustomerServiceIndexResource(global::Mubert.PlaylistServiceResource value) => new PlaylistCustomerServiceIndexResource((global::Mubert.PlaylistServiceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.PlaylistServiceResource?(PlaylistCustomerServiceIndexResource @this) => @this.PlaylistServiceResource;

        /// <summary>
        /// 
        /// </summary>
        public PlaylistCustomerServiceIndexResource(global::Mubert.PlaylistServiceResource? value)
        {
            PlaylistServiceResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PlaylistServiceResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PlaylistServiceResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPlaylistServiceResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.PlaylistServiceResource?, TResult>? playlistServiceResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlaylistServiceResource && playlistServiceResource != null)
            {
                return playlistServiceResource(PlaylistServiceResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.PlaylistServiceResource?>? playlistServiceResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlaylistServiceResource)
            {
                playlistServiceResource?.Invoke(PlaylistServiceResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PlaylistServiceResource,
                typeof(global::Mubert.PlaylistServiceResource),
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
        public bool Equals(PlaylistCustomerServiceIndexResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.PlaylistServiceResource?>.Default.Equals(PlaylistServiceResource, other.PlaylistServiceResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PlaylistCustomerServiceIndexResource obj1, PlaylistCustomerServiceIndexResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PlaylistCustomerServiceIndexResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PlaylistCustomerServiceIndexResource obj1, PlaylistCustomerServiceIndexResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PlaylistCustomerServiceIndexResource o && Equals(o);
        }
    }
}
