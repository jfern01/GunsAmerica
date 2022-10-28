namespace GunsAmerica.Models.Responses;

using System.Text.Json.Serialization;

/// <summary>
/// Authentication token response.
/// </summary>
public record class TokenResponse
{
    /// <summary>
    /// Gets access token.
    /// </summary>
    [JsonPropertyName("access_token")]
    public string AccessToken { get; init; } = default!;

    /// <summary>
    /// Gets token type.
    /// </summary>
    [JsonPropertyName("token_type")]
    public string TokenType { get; init; } = default!;

    /// <summary>
    /// Gets TTL in seconds.
    /// </summary>
    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; init; }
}
