namespace GunsAmerica.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Order buyer.
/// </summary>
public record class Buyer
{
    /// <summary>
    /// Gets User ID.
    /// </summary>
    [JsonPropertyName("UserID")]
    public int UserID { get; init; }

    /// <summary>
    /// Gets account status.
    /// </summary>
    [JsonPropertyName("AccountStatus")]
    public int AccountStatus { get; init; }

    /// <summary>
    /// Gets feedback rating.
    /// </summary>
    [JsonPropertyName("FeedbackRating")]
    public string FeedbackRating { get; init; } = default!;

    /// <summary>
    /// Gets a value indicating whether user is an FFL Dealer.
    /// </summary>
    [JsonPropertyName("IsFFL")]
    public bool IsFfl { get; init; }

    /// <summary>
    /// Gets a value indicating whether user is a valid registered user.
    /// </summary>
    [JsonPropertyName("IsRegisteredUser")]
    public bool IsRegisteredUser { get; init; }

    /// <summary>
    /// Gets a value indicating whether user is a GunsAmerica.com verified user.
    /// </summary>
    [JsonPropertyName("IsVerified")]
    public bool IsVerified { get; init; }

    /// <summary>
    /// Gets username.
    /// </summary>
    [JsonPropertyName("Username")]
    public string Username { get; init; } = default!;

    /// <summary>
    /// Gets date user registered on GunsAmerica.
    /// </summary>
    [JsonPropertyName("MemberSince")]
    public DateTime MemberSince { get; init; }
}
