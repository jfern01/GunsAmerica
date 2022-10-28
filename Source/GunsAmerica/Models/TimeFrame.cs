namespace GunsAmerica.Models;

/// <summary>
/// When the order was created.
/// </summary>
public enum TimeFrame
{
    /// <summary>
    /// Created Last 24 Hours.
    /// </summary>
    CreatedLast24 = 1,

    /// <summary>
    /// Created Last 48 Hours.
    /// </summary>
    CreatedLast48 = 2,

    /// <summary>
    /// Created Last Week.
    /// </summary>
    CreatedLastWeek = 3,

    /// <summary>
    /// Created Last 2 Weeks.
    /// </summary>
    CreatedLast2Weeks = 4,

    /// <summary>
    /// Created Last 30 Days.
    /// </summary>
    CreatedLast30Days = 5,

    /// <summary>
    /// Created Last 60 Days.
    /// </summary>
    CreatedLast60Days = 6,

    /// <summary>
    /// Created Last 90 Days.
    /// </summary>
    CreatedLast90Days = 7,

    /// <summary>
    /// Created Last 360 Days.
    /// </summary>
    CreatedLast360Days = 8,
}
