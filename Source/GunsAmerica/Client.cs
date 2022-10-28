namespace GunsAmerica;

using GunsAmerica.Models.Requests;
using GunsAmerica.Models.Responses;
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

    /// <summary>
    /// Returns uploaded inventory on GunsAmerica associated with dealer account.
    /// </summary>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public async Task<List<InventoryItemRequest>> GetInventoryAsync()
    {
        var request = new RestRequest("inventory");

        var response = await this.client.ExecuteGetAsync<List<InventoryItemRequest>>(request).ConfigureAwait(false);

        return response.Data!;
    }

    /// <summary>
    /// Returns an item that matches your seller stock number.
    /// </summary>
    /// <param name="sellerStockNumber">Seller stock number.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public async Task<InventoryItemRequest> GetInventoryAsync(string sellerStockNumber)
    {
        sellerStockNumber = sellerStockNumber ?? throw new ArgumentNullException(nameof(sellerStockNumber));

        var request = new RestRequest("inventory/{sellerStockNumber}")
            .AddUrlSegment("sellerStockNumber", sellerStockNumber);

        var response = await this.client.ExecuteGetAsync<InventoryItemRequest>(request).ConfigureAwait(false);

        return response.Data!;
    }

    /// <summary>
    /// This will mark your uploaded item as deleted.
    /// Listings with same seller stock number that are not manually listed will become inactive.
    /// </summary>
    /// <param name="sellerStockNumber">Seller stock number.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public async Task<bool> DeleteInventoryAsync(string sellerStockNumber)
    {
        sellerStockNumber = sellerStockNumber ?? throw new ArgumentNullException(nameof(sellerStockNumber));

        var request = new RestRequest("inventory/{sellerStockNumber}")
            .AddUrlSegment("sellerStockNumber", sellerStockNumber);

        var response = await this.client.DeleteAsync(request).ConfigureAwait(false);

        return response.IsSuccessStatusCode;
    }

    /// <summary>
    /// This API enables you to create (post listing) or update inventory item.
    /// </summary>
    /// <param name="item">Item to upsert.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public async Task<InventoryItemResponse> UpsertInventoryAsync(InventoryItemRequest item)
    {
        item = item ?? throw new ArgumentNullException(nameof(item));

        var request = new RestRequest("items")
            .AddJsonBody(item);

        var response = await this.client.ExecutePostAsync<InventoryItemResponse>(request).ConfigureAwait(false);

        return response.Data!;
    }
}
