namespace GunsAmerica;

using GunsAmerica.Models.Responses;
using RestSharp;
using RestSharp.Authenticators;

/// <summary>
/// GunsAmerica custom OAuth 2.0 authenticator.
/// </summary>
public class Authenticator : AuthenticatorBase
{
    /// <summary>
    /// Base url.
    /// </summary>
    public const string BaseUrl = "https://api-id.gunsamerica.com";

    private readonly string clientId;

    private readonly string clientSecret;

    /// <summary>
    /// Initializes a new instance of the <see cref="Authenticator"/> class.
    /// </summary>
    /// <param name="clientId">Client ID.</param>
    /// <param name="clientSecret">Client Secret.</param>
    public Authenticator(string clientId, string clientSecret)
        : base(string.Empty)
    {
        this.clientId = clientId ?? throw new ArgumentNullException(nameof(clientId));
        this.clientSecret = clientSecret ?? throw new ArgumentNullException(nameof(clientSecret));
    }

    /// <summary>
    /// Gets a value indicating whether the authenticator has a valid token.
    /// </summary>
    public bool ValidToken => !string.IsNullOrEmpty(this.Token) && DateTimeOffset.Now < this.TokenExpiration;

    /// <summary>
    /// Gets token expiration datetime.
    /// </summary>
    public DateTimeOffset TokenExpiration { get; private set; } = DateTimeOffset.MinValue;

    /// <inheritdoc/>
    protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
    {
        if (!this.ValidToken)
        {
            await this.GetTokenAsync().ConfigureAwait(false);
        }

        return new HeaderParameter(KnownHeaders.Authorization, this.Token);
    }

    /// <summary>
    /// Request access token from the OAuth2 endpoint.
    /// </summary>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    protected async Task GetTokenAsync()
    {
        var options = new RestClientOptions(BaseUrl)
        {
            ThrowOnAnyError = true,
        };

        using var client = new RestClient(options)
        {
            Authenticator = new HttpBasicAuthenticator(this.clientId, this.clientSecret),
        };

        var request = new RestRequest("connect/token")
            .AddParameter("grant_type", "client_credentials")
            .AddParameter("scope", "InventoryServiceAPI")
            .AddParameter("client_id", this.clientId)
            .AddParameter("client_secret", this.clientSecret);

        var response = await client.PostAsync<TokenResponse>(request).ConfigureAwait(false);

        this.TokenExpiration = DateTimeOffset.Now.AddSeconds(response!.ExpiresIn);
        this.Token = $"{response!.TokenType} {response!.AccessToken}";
    }
}
