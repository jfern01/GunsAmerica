namespace GunsAmerica;

using System.Text.Json;
using RestSharp;
using RestSharp.Serializers;

/// <summary>
/// JSON serializer specifically to deal with Guns America API inconsistencies.
/// </summary>
public class JsonSerializer : IRestSerializer, ISerializer, IDeserializer
{
    private readonly JsonSerializerOptions options;

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonSerializer"/> class.
    /// </summary>
    public JsonSerializer() => this.options = new JsonSerializerOptions(JsonSerializerDefaults.Web);

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonSerializer"/> class.
    /// </summary>
    /// <param name="options">Instance of <see cref="JsonSerializerOptions"/>.</param>
    public JsonSerializer(JsonSerializerOptions options) => this.options = options;

    /// <inheritdoc/>
    public string ContentType { get; set; } = "application/json";

    /// <inheritdoc/>
    public ISerializer Serializer => this;

    /// <inheritdoc/>
    public IDeserializer Deserializer => this;

    /// <inheritdoc/>
    public DataFormat DataFormat => DataFormat.Json;

    /// <inheritdoc/>
    public string[] AcceptedContentTypes => RestSharp.Serializers.ContentType.JsonAccept;

    /// <inheritdoc/>
    public SupportsContentType SupportsContentType => contentType => contentType.EndsWith("json", StringComparison.InvariantCultureIgnoreCase);

    /// <inheritdoc/>
    public string? Serialize(object? obj) => obj == null ? null : System.Text.Json.JsonSerializer.Serialize(obj, this.options);

    /// <inheritdoc/>
    public string? Serialize(Parameter parameter) => this.Serialize(parameter.Value);

    /// <inheritdoc/>
    public T? Deserialize<T>(RestResponse response) => System.Text.Json.JsonSerializer.Deserialize<T>(response.Content!.Replace("[[]]", "[]"), this.options);
}
