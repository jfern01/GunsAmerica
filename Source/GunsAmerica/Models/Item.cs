namespace GunsAmerica.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Guns America item.
/// </summary>
public record class Item
{
    /// <summary>
    /// Gets Category ID.
    /// </summary>
    [JsonPropertyName("CategoryID")]
    public int CategoryId { get; init; }

    /// <summary>
    /// Gets Item condition.
    /// </summary>
    [JsonPropertyName("Condition")]
    public Condition Condition { get; init; } = Condition.NewInBox;

    /// <summary>
    /// Gets Item description.
    /// </summary>
    [JsonPropertyName("Description")]
    public string Description { get; init; } = default!;

    /// <summary>
    /// Gets Buy Now price.
    /// </summary>
    [JsonPropertyName("BuyNowPrice")]
    public decimal BuyNowPrice { get; init; }

    /// <summary>
    /// Gets Fixed price.
    /// </summary>
    [JsonPropertyName("FixedPrice")]
    public decimal FixedPrice { get; init; }

    /// <summary>
    /// Gets Item inspection period.
    /// </summary>
    [JsonPropertyName("InspectionPeriod")]
    public InspectionPeriod InspectionPeriod { get; init; } = InspectionPeriod.AsIs;

    /// <summary>
    /// Gets Item MPN.
    /// </summary>
    [JsonPropertyName("MfgPartNumber")]
    public string Mpn { get; init; } = default!;

    /// <summary>
    /// Gets Item quantity.
    /// </summary>
    [JsonPropertyName("Quantity")]
    public int Quantity { get; init; }

    /// <summary>
    /// Gets Reserve price.
    /// </summary>
    [JsonPropertyName("ReserverPrice")]
    public decimal ReservePrice { get; init; }

    /// <summary>
    /// Gets Item serial number.
    /// </summary>
    [JsonPropertyName("SerialNumber")]
    public string SerialNumber { get; init; } = default!;

    /// <summary>
    /// Gets Item shipping cost.
    /// </summary>
    [JsonPropertyName("ShippingCost")]
    public decimal ShippingCost { get; init; }

    /// <summary>
    /// Gets Item shipping text.
    /// </summary>
    [JsonPropertyName("ShippingText")]
    public string ShippingText { get; init; } = default!;

    /// <summary>
    /// Gets Item SKU.
    /// </summary>
    [JsonPropertyName("SKU")]
    public string Sku { get; init; } = default!;

    /// <summary>
    /// Gets Item title.
    /// </summary>
    [JsonPropertyName("Title")]
    public string Title { get; init; } = default!;

    /// <summary>
    /// Gets Item UPC.
    /// </summary>
    [JsonPropertyName("UPC")]
    public string UPC { get; init; } = default!;

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
}
