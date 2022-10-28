namespace GunsAmerica.Models;

/// <summary>
/// Status of the sold order.
/// </summary>
public enum OrderStatus
{
    /// <summary>
    /// All.
    /// </summary>
    All = 0,

    /// <summary>
    /// Pending Seller Review.
    /// </summary>
    PendingSellerReview = 1,

    /// <summary>
    /// Pending Buyer Confirmation.
    /// </summary>
    PendingBuyerConfirmation = 2,

    /// <summary>
    /// Pending Payment Received.
    /// </summary>
    PendingPaymentReceived = 3,

    /// <summary>
    /// Pending Shipment.
    /// </summary>
    PendingShipment = 4,

    /// <summary>
    /// Complete.
    /// </summary>
    Complete = 5,

    /// <summary>
    /// Cancelled.
    /// </summary>
    Cancelled = 6,

    /// <summary>
    /// Pending Buyer Review.
    /// </summary>
    PendingBuyerReview = 7,
}
