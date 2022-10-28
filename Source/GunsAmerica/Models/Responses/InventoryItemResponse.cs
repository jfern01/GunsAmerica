namespace GunsAmerica.Models.Responses;

using System.Text.Json.Serialization;
using GunsAmerica.Models.Requests;

/// <summary>
/// Response for the an upsert operation on an inventory item.
/// </summary>
public record class InventoryItemResponse : InventoryItemRequest
{
    /// <summary>
    /// Gets Category name.
    /// </summary>
    [JsonPropertyName("CategoryName")]
    public string CategoryName { get; init; } = default!;

    /// <summary>
    /// Gets count of quantity reduced.
    /// </summary>
    [JsonPropertyName("CountOfDrops")]
    public int CountOfDrops { get; init; }

    /// <summary>
    /// Gets Item delete datetime.
    /// </summary>
    [JsonPropertyName("DeletedOn")]
    public DateTime? DeletedOn { get; init; }

    /// <summary>
    /// Gets Item errors.
    /// </summary>
    [JsonPropertyName("Error")]
    public List<string> Error { get; init; } = new();

    /// <summary>
    /// Gets Item warnings.
    /// </summary>
    [JsonPropertyName("Warning")]
    public List<string> Warning { get; init; } = new();

    /// <summary>
    /// Gets Item ID.
    /// </summary>
    [JsonPropertyName("ItemID")]
    public int ItemId { get; init; }

    /// <summary>
    /// Gets Item listing ID.
    /// </summary>
    [JsonPropertyName("ListingId")]
    public int ListingId { get; init; }

    /// <summary>
    /// Gets Item listing status.
    /// </summary>
    [JsonPropertyName("ListingStatus")]
    public string ListingStatus { get; init; } = default!;

    /// <summary>
    /// Gets Item listing URL.
    /// </summary>
    [JsonPropertyName("ListingUrl")]
    public string ListingUrl { get; init; } = default!;

    /// <summary>
    /// Gets Item last modified datetime.
    /// </summary>
    [JsonPropertyName("ModifiedOn")]
    public DateTime ModifiedOn { get; init; }

    /// <summary>
    /// Gets Item store listing ID.
    /// </summary>
    [JsonPropertyName("StoreListingId")]
    public int StoreListingId { get; init; }

    /// <summary>
    /// Gets Item store listing status.
    /// </summary>
    [JsonPropertyName("StoreListingStatus")]
    public string StoreListingStatus { get; init; } = default!;

    /// <summary>
    /// Gets Item store listing URL.
    /// </summary>
    [JsonPropertyName("StoreListingUrl")]
    public string StoreListingUrl { get; init; } = default!;
}
