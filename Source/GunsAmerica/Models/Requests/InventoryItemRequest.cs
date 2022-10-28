namespace GunsAmerica.Models.Requests;

using System.Text.Json.Serialization;

/// <summary>
/// Guns America inventory item.
/// </summary>
public record class InventoryItemRequest : Item
{
    /// <summary>
    /// Gets a value indicating whether to list item on GunsAmerica listings.
    /// </summary>
    [JsonPropertyName("AddToGA")]
    public bool AddToGa { get; init; }

    /// <summary>
    /// Gets a value indicating whether to list item on live store front.
    /// </summary>
    [JsonPropertyName("AddToLSF")]
    public bool AddToLsf { get; init; }

    /// <summary>
    /// Gets number of days before listings ends.
    /// </summary>
    [JsonPropertyName("ListingDuration")]
    public int? ListingDuration { get; init; }

    /// <summary>
    /// Gets or sets list of image URLs.
    /// </summary>
    public List<string> PictureUrlsList { get; set; } = new();

    /// <summary>
    /// Gets comma-separated list of image URLs.
    /// </summary>
    [JsonPropertyName("PictureURLs")]
    public string PictureUrls => string.Join(",", this.PictureUrlsList);
}
