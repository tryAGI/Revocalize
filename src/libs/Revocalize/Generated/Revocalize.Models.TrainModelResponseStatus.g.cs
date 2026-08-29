
#nullable enable

namespace Revocalize
{
    /// <summary>
    ///
    /// </summary>
    public enum TrainModelResponseStatus
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
        Training,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainModelResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainModelResponseStatus value)
        {
            return value switch
            {
                TrainModelResponseStatus.Completed => "completed",
                TrainModelResponseStatus.Failed => "failed",
                TrainModelResponseStatus.Training => "training",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainModelResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TrainModelResponseStatus.Completed,
                "failed" => TrainModelResponseStatus.Failed,
                "training" => TrainModelResponseStatus.Training,
                _ => null,
            };
        }
    }
}