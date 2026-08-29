
#nullable enable

namespace Revocalize
{
    /// <summary>
    ///
    /// </summary>
    public enum TaskStatusResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskStatusResponseStatus value)
        {
            return value switch
            {
                TaskStatusResponseStatus.Completed => "completed",
                TaskStatusResponseStatus.Failed => "failed",
                TaskStatusResponseStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TaskStatusResponseStatus.Completed,
                "failed" => TaskStatusResponseStatus.Failed,
                "in_progress" => TaskStatusResponseStatus.InProgress,
                _ => null,
            };
        }
    }
}