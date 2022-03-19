namespace GunsAmerica;

using RestSharp;

/// <summary>
/// The API client.
/// </summary>
public class Client : IDisposable
{
    /// <summary>
    /// API base url.
    /// </summary>
    public const string BaseUrl = "https://api.gunsamerica.com/api/";

    private readonly RestClient client;

    private readonly string clientId;

    private readonly string clientKey;

    /// <summary>
    /// Initializes a new instance of the <see cref="Client"/> class.
    /// </summary>
    /// <param name="clientId">Client ID.</param>
    /// <param name="clientKey">Client Key.</param>
    public Client(string clientId, string clientKey)
    {
        this.clientId = clientId ?? throw new ArgumentNullException(nameof(clientId));
        this.clientKey = clientKey ?? throw new ArgumentNullException(nameof(clientKey));

        this.client = new RestClient(BaseUrl)
        {
            Authenticator = new Authenticator(this.clientId, this.clientKey),
        };
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        this.client?.Dispose();
        GC.SuppressFinalize(this);
    }
}
