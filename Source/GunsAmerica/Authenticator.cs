namespace GunsAmerica;

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

    /// <inheritdoc/>
    protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
    {
        var token = string.IsNullOrEmpty(this.Token) ? await this.GetTokenAsync().ConfigureAwait(false) : this.Token;

        return new HeaderParameter(KnownHeaders.Authorization, token);
    }

    /// <summary>
    /// Request access token from the OAuth2 endpoint.
    /// </summary>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    protected async Task<string> GetTokenAsync()
    {
        var options = new RestClientOptions(BaseUrl);

        using var client = new RestClient(options)
        {
            Authenticator = new HttpBasicAuthenticator(this.clientId, this.clientSecret),
        };

        var request = new RestRequest("connect/token")
            .AddParameter("grant_type", "client_credentials")
            .AddParameter("scope", "InventoryServiceAPI")
            .AddParameter("client_id", this.clientId)
            .AddParameter("client_secret", this.clientSecret);

        var response = await client.PostAsync<Models.TokenResponse>(request).ConfigureAwait(false);

        return $"{response!.TokenType} {response!.AccessToken}";
    }
}
