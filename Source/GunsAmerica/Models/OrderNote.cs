namespace GunsAmerica.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Order note.
/// </summary>
public record class OrderNote
{
    /// <summary>
    /// Gets note content.
    /// </summary>
    [JsonPropertyName("Note")]
    public string Note { get; init; } = default!;

    /// <summary>
    /// Gets when the note is entered.
    /// </summary>
    [JsonPropertyName("CreatedOn")]
    public DateTime CreatedOn { get; init; }
}
