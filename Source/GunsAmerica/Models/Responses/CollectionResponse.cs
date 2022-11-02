namespace GunsAmerica.Models.Responses;

using System.Text.Json.Serialization;

/// <summary>
/// Collection response wrapper.
/// </summary>
/// <typeparam name="T">Entity type.</typeparam>
public record class CollectionResponse<T>
{
    /// <summary>
    /// Gets item count.
    /// </summary>
    [JsonPropertyName("Count")]
    public int Count { get; init; }

    /// <summary>
    /// Gets page index.
    /// </summary>
    [JsonPropertyName("PageIndex")]
    public int PageIndex { get; init; }

    /// <summary>
    /// Gets page size.
    /// </summary>
    [JsonPropertyName("PageSize")]
    public int PageSize { get; init; }

    /// <summary>
    /// Gets wrapped results.
    /// </summary>
    [JsonPropertyName("Results")]
    public List<List<T>> WrappedResults { get; init; } = new() { new() };

    /// <summary>
    /// Gets results.
    /// </summary>
    [JsonIgnore]
    public List<T> Results => this.WrappedResults.FirstOrDefault() ?? new();
}
