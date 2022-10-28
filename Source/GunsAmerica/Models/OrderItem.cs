namespace GunsAmerica.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Order item.
/// </summary>
public record class OrderItem
{
    /// <summary>
    /// Gets Item ID.
    /// </summary>
    [JsonPropertyName("ItemID")]
    public int ItemId { get; init; }

    /// <summary>
    /// Gets Item price.
    /// </summary>
    [JsonPropertyName("ItemPrice")]
    public decimal ItemPrice { get; init; }

    /// <summary>
    /// Gets Item sales tax rate.
    /// </summary>
    [JsonPropertyName("SalesTaxRate")]
    public decimal SalesTaxRate { get; init; }

    /// <summary>
    /// Gets Item sales tax.
    /// </summary>
    [JsonPropertyName("SalesTax")]
    public decimal SalesTax { get; init; }

    /// <summary>
    /// Gets a value indicating whether FFL is required for this item.
    /// </summary>
    [JsonPropertyName("IsFFLRequired")]
    public bool IsFflRequired { get; init; }

    /// <summary>
    /// Gets Item title.
    /// </summary>
    [JsonPropertyName("Title")]
    public string Title { get; init; } = default!;

    /// <summary>
    /// Gets Item weight.
    /// </summary>
    [JsonPropertyName("Weight")]
    public decimal Weight { get; init; }

    /// <summary>
    /// Gets Item weight unit.
    /// </summary>
    [JsonPropertyName("WeightUnit")]
    public WeightUnit WeightUnit { get; init; } = WeightUnit.Pounds;

    /// <summary>
    /// Gets Item sub total.
    /// </summary>
    [JsonPropertyName("ItemSubTotal")]
    public decimal ItemSubTotal { get; init; }

    /// <summary>
    /// Gets Item thumbnail.
    /// </summary>
    [JsonPropertyName("Thumbnail")]
    public string Thumbnail { get; init; } = default!;
}
