#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mubert
{
    /// <summary>
    /// Pagination metadata with sorting info
    /// </summary>
    public readonly partial struct MetadataPaginationSortable : global::System.IEquatable<MetadataPaginationSortable>
    {
        /// <summary>
        /// Pagination metadata
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.MetadataPagination? MetadataPagination { get; init; }
#else
        public global::Mubert.MetadataPagination? MetadataPagination { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetadataPagination))]
#endif
        public bool IsMetadataPagination => MetadataPagination != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mubert.MetadataPaginationSortableVariant2? MetadataPaginationSortableVariant2 { get; init; }
#else
        public global::Mubert.MetadataPaginationSortableVariant2? MetadataPaginationSortableVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetadataPaginationSortableVariant2))]
#endif
        public bool IsMetadataPaginationSortableVariant2 => MetadataPaginationSortableVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataPaginationSortable(global::Mubert.MetadataPagination value) => new MetadataPaginationSortable((global::Mubert.MetadataPagination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.MetadataPagination?(MetadataPaginationSortable @this) => @this.MetadataPagination;

        /// <summary>
        /// 
        /// </summary>
        public MetadataPaginationSortable(global::Mubert.MetadataPagination? value)
        {
            MetadataPagination = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataPaginationSortable(global::Mubert.MetadataPaginationSortableVariant2 value) => new MetadataPaginationSortable((global::Mubert.MetadataPaginationSortableVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mubert.MetadataPaginationSortableVariant2?(MetadataPaginationSortable @this) => @this.MetadataPaginationSortableVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MetadataPaginationSortable(global::Mubert.MetadataPaginationSortableVariant2? value)
        {
            MetadataPaginationSortableVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MetadataPaginationSortable(
            global::Mubert.MetadataPagination? metadataPagination,
            global::Mubert.MetadataPaginationSortableVariant2? metadataPaginationSortableVariant2
            )
        {
            MetadataPagination = metadataPagination;
            MetadataPaginationSortableVariant2 = metadataPaginationSortableVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MetadataPaginationSortableVariant2 as object ??
            MetadataPagination as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MetadataPagination?.ToString() ??
            MetadataPaginationSortableVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMetadataPagination && IsMetadataPaginationSortableVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mubert.MetadataPagination?, TResult>? metadataPagination = null,
            global::System.Func<global::Mubert.MetadataPaginationSortableVariant2?, TResult>? metadataPaginationSortableVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMetadataPagination && metadataPagination != null)
            {
                return metadataPagination(MetadataPagination!);
            }
            else if (IsMetadataPaginationSortableVariant2 && metadataPaginationSortableVariant2 != null)
            {
                return metadataPaginationSortableVariant2(MetadataPaginationSortableVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mubert.MetadataPagination?>? metadataPagination = null,
            global::System.Action<global::Mubert.MetadataPaginationSortableVariant2?>? metadataPaginationSortableVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMetadataPagination)
            {
                metadataPagination?.Invoke(MetadataPagination!);
            }
            else if (IsMetadataPaginationSortableVariant2)
            {
                metadataPaginationSortableVariant2?.Invoke(MetadataPaginationSortableVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MetadataPagination,
                typeof(global::Mubert.MetadataPagination),
                MetadataPaginationSortableVariant2,
                typeof(global::Mubert.MetadataPaginationSortableVariant2),
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
        public bool Equals(MetadataPaginationSortable other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mubert.MetadataPagination?>.Default.Equals(MetadataPagination, other.MetadataPagination) &&
                global::System.Collections.Generic.EqualityComparer<global::Mubert.MetadataPaginationSortableVariant2?>.Default.Equals(MetadataPaginationSortableVariant2, other.MetadataPaginationSortableVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MetadataPaginationSortable obj1, MetadataPaginationSortable obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MetadataPaginationSortable>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MetadataPaginationSortable obj1, MetadataPaginationSortable obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MetadataPaginationSortable o && Equals(o);
        }
    }
}
