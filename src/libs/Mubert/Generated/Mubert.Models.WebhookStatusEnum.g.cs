
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Webhook Statuses
    /// </summary>
    public enum WebhookStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Awaiting,
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
        Sending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookStatusEnum value)
        {
            return value switch
            {
                WebhookStatusEnum.Awaiting => "awaiting",
                WebhookStatusEnum.Done => "done",
                WebhookStatusEnum.Failed => "failed",
                WebhookStatusEnum.Sending => "sending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "awaiting" => WebhookStatusEnum.Awaiting,
                "done" => WebhookStatusEnum.Done,
                "failed" => WebhookStatusEnum.Failed,
                "sending" => WebhookStatusEnum.Sending,
                _ => null,
            };
        }
    }
}