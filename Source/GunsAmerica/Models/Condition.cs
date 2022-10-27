namespace GunsAmerica.Models;

/// <summary>
/// Describes item condition.
/// </summary>
public enum Condition
{
    /// <summary>
    /// New In Box.
    /// </summary>
    NewInBox = 2,

    /// <summary>
    /// Never fired.
    /// </summary>
    NeverFired = 3,

    /// <summary>
    /// Used, As New.
    /// </summary>
    UsedAsNew = 4,

    /// <summary>
    /// Used, Minor Wear.
    /// </summary>
    UsedMinorWear = 5,

    /// <summary>
    /// Used - See Item Description.
    /// </summary>
    UsedSeeItemDescription = 6,
}
