namespace GunsAmerica.Models;

/// <summary>
/// Describes item inspection period.
/// </summary>
public enum InspectionPeriod
{
    /// <summary>
    /// AS IS - No refund or exchange.
    /// </summary>
    AsIs = 1,

    /// <summary>
    /// Three Days from the date the item is received.
    /// </summary>
    ThreeDays = 4,

    /// <summary>
    /// Five Days from the date the item is received.
    /// </summary>
    FiveDays = 6,

    /// <summary>
    /// Seven Days from the date the item is received.
    /// </summary>
    SevenDays = 8,

    /// <summary>
    /// Fourteen Days from the date the item is received.
    /// </summary>
    FourteenDays = 10,

    /// <summary>
    /// 30 day money back guarantee.
    /// </summary>
    ThirtyDayMoneyBackGuarantee = 12,

    /// <summary>
    /// Factory Warranty.
    /// </summary>
    FactoryWarranty = 14,
}
