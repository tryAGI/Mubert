#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PlaylistIndexPublicResource : global::System.IEquatable<PlaylistIndexPublicResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.PlaylistPublicResource? PlaylistPublicResource { get; init; }
#else
        public global::Mubert.PlaylistPublicResource? PlaylistPublicResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlaylistPublicResource))]
#endif
        public bool IsPlaylistPublicResource => PlaylistPublicResource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlaylistIndexPublicResource(global::Mubert.PlaylistPublicResource value) => new PlaylistIndexPublicResource((global::Mubert.PlaylistPublicResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.PlaylistPublicResource?(PlaylistIndexPublicResource @this) => @this.PlaylistPublicResource;

        /// <summary>
        /// 
        /// </summary>
        public PlaylistIndexPublicResource(global::Mubert.PlaylistPublicResource? value)
        {
            PlaylistPublicResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PlaylistPublicResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PlaylistPublicResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPlaylistPublicResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.PlaylistPublicResource?, TResult>? playlistPublicResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlaylistPublicResource && playlistPublicResource != null)
            {
                return playlistPublicResource(PlaylistPublicResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.PlaylistPublicResource?>? playlistPublicResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlaylistPublicResource)
            {
                playlistPublicResource?.Invoke(PlaylistPublicResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PlaylistPublicResource,
                typeof(global::Mubert.PlaylistPublicResource),
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
        public bool Equals(PlaylistIndexPublicResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.PlaylistPublicResource?>.Default.Equals(PlaylistPublicResource, other.PlaylistPublicResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PlaylistIndexPublicResource obj1, PlaylistIndexPublicResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PlaylistIndexPublicResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PlaylistIndexPublicResource obj1, PlaylistIndexPublicResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PlaylistIndexPublicResource o && Equals(o);
        }
    }
}
