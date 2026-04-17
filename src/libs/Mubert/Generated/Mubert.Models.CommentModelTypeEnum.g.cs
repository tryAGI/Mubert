
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Comment Model Types
    /// </summary>
    public enum CommentModelTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Company,
        /// <summary>
        /// 
        /// </summary>
        Customer,
        /// <summary>
        /// 
        /// </summary>
        License,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommentModelTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommentModelTypeEnum value)
        {
            return value switch
            {
                CommentModelTypeEnum.Company => "company",
                CommentModelTypeEnum.Customer => "customer",
                CommentModelTypeEnum.License => "license",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommentModelTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "company" => CommentModelTypeEnum.Company,
                "customer" => CommentModelTypeEnum.Customer,
                "license" => CommentModelTypeEnum.License,
                _ => null,
            };
        }
    }
}