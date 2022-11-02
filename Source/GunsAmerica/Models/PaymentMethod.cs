namespace GunsAmerica.Models;

/// <summary>
/// Payment method.
/// </summary>
public enum PaymentMethod
{
    /// <summary>
    /// Personal Check.
    /// </summary>
    PersonalCheck = 4,

    /// <summary>
    /// Visa MasterCard.
    /// </summary>
    VisaMasterCard = 8,

    /// <summary>
    /// AMEX.
    /// </summary>
    Amex = 64,

    /// <summary>
    /// Discover.
    /// </summary>
    Discover = 128,

    /// <summary>
    /// Certified Check.
    /// </summary>
    CertifiedCheck = 8192,

    /// <summary>
    /// Money Order.
    /// </summary>
    MoneyOrder = 32768,
}
