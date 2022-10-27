namespace GunsAmerica;

using GunsAmerica.Models;
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

        var options = new RestClientOptions(BaseUrl)
        {
            ThrowOnAnyError = true,
        };

        this.client = new RestClient(options)
        {
            Authenticator = new Authenticator(this.clientId, this.clientKey),
        };

        _ = this.client.UseOnlySerializer(() => new JsonSerializer());
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        this.client?.Dispose();
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Returns your items listed on GunsAmerica.
    /// </summary>
    /// <param name="options">Items request parameters.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public async Task<CollectionResponse<ItemResponse>> GetItemsAsync(ItemsRequest? options = null)
    {
        var request = new RestRequest("items");

        if (options != null)
        {
            _ = request.AddOrUpdateParameters(options.GetParameters());
        }

        var response = await this.client.ExecuteGetAsync<CollectionResponse<ItemResponse>>(request).ConfigureAwait(false);

        return response.Data!;
    }
}
