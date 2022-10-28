namespace GunsAmerica.Models;

/// <summary>
/// The order in which the results are returned.
/// </summary>
public enum OrderSort
{
    /// <summary>
    /// Order ID.
    /// </summary>
    OrderId = 0,

    /// <summary>
    /// Buyer Name.
    /// </summary>
    BuyerName = 1,

    /// <summary>
    /// Item ID.
    /// </summary>
    ItemId = 2,

    /// <summary>
    /// Order Date.
    /// </summary>
    OrderDate = 3,

    /// <summary>
    /// Total Price.
    /// </summary>
    TotalPrice = 4,

    /// <summary>
    /// Payment Received.
    /// </summary>
    PaymentReceived = 7,

    /// <summary>
    /// Order Picked up.
    /// </summary>
    OrderPickedUp = 8,
}
