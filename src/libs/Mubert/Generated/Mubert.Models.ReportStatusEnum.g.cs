
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Report Status
    /// </summary>
    public enum ReportStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InQueue,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReportStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReportStatusEnum value)
        {
            return value switch
            {
                ReportStatusEnum.Done => "done",
                ReportStatusEnum.Failed => "failed",
                ReportStatusEnum.InQueue => "in_queue",
                ReportStatusEnum.Processing => "processing",
                ReportStatusEnum.Stopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReportStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "done" => ReportStatusEnum.Done,
                "failed" => ReportStatusEnum.Failed,
                "in_queue" => ReportStatusEnum.InQueue,
                "processing" => ReportStatusEnum.Processing,
                "stopped" => ReportStatusEnum.Stopped,
                _ => null,
            };
        }
    }
}