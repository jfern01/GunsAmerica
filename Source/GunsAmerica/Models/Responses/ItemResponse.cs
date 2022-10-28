namespace GunsAmerica.Models.Responses;

using System.Text.Json.Serialization;

/// <summary>
/// Item listed on GunsAmerica.
/// </summary>
public record class ItemResponse : Item
{
    /// <summary>
    /// Gets Listing ID.
    /// </summary>
    [JsonPropertyName("ListingId")]
    public int ListingId { get; init; }

    /// <summary>
    /// Gets Listing URL.
    /// </summary>
    [JsonPropertyName("ListingUrl")]
    public string ListingUrl { get; init; } = default!;

    /// <summary>
    /// Gets Category name.
    /// </summary>
    [JsonPropertyName("CategoryName")]
    public string CategoryName { get; init; } = default!;

    /// <summary>
    /// Gets a value indicating whether item is manually created or edited. If true, item cannot be updated by the API.
    /// </summary>
    [JsonPropertyName("IsManual")]
    public bool IsManual { get; init; }

    /// <summary>
    /// Gets Listing end date.
    /// </summary>
    [JsonPropertyName("ListingEndDate")]
    public DateTime? ListingEndDate { get; init; }

    /// <summary>
    /// Gets Listing type.
    /// </summary>
    [JsonPropertyName("ListingType")]
    public string ListingType { get; init; } = default!;
}
