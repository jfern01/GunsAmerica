namespace GunsAmerica.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Order line item.
/// </summary>
public record class OrderLine
{
    /// <summary>
    /// Gets seller note.
    /// </summary>
    [JsonPropertyName("Note")]
    public string Note { get; init; } = default!;

    /// <summary>
    /// Gets amount.
    /// </summary>
    [JsonPropertyName("Amount")]
    public decimal Amount { get; init; }

    /// <summary>
    /// Gets when the line item was created.
    /// </summary>
    [JsonPropertyName("CreatedOn")]
    public DateTime CreatedOn { get; init; }

    /// <summary>
    /// Gets when the line item was modified.
    /// </summary>
    [JsonPropertyName("ModifiedOn")]
    public DateTime ModifiedOn { get; init; }
}
