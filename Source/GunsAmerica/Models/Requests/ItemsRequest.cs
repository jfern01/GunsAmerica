namespace GunsAmerica.Models.Requests;

using System.Globalization;
using RestSharp;

/// <summary>
/// Query parameters for GET /items request.
/// </summary>
public class ItemsRequest
{
    /// <summary>
    /// Gets or sets list of category ids.
    /// </summary>
    public List<string> CategoriesList { get; set; } = new();

    /// <summary>
    /// Gets comma-separated list of valid category ids.
    /// </summary>
    public string Categories => string.Join(",", this.CategoriesList);

    /// <summary>
    /// Gets or sets the keywords to use for search.
    /// </summary>
    public string? Keywords { get; set; }

    /// <summary>
    /// Gets or sets maximum item price.
    /// </summary>
    public decimal? MaxPrice { get; set; }

    /// <summary>
    /// Gets or sets minimum item price.
    /// </summary>
    public decimal? MinPrice { get; set; }

    /// <summary>
    /// Gets or sets search type.
    /// </summary>
    public string? SearchType { get; set; }

    /// <summary>
    /// Gets or sets selling status.
    /// </summary>
    public SellingStatus? SellingStatus { get; set; }

    /// <summary>
    /// Gets or sets serial number.
    /// </summary>
    public string? SerialNumber { get; set; }

    /// <summary>
    /// Gets or sets SKU.
    /// </summary>
    public string? Sku { get; set; }

    /// <summary>
    /// Gets or sets UPC.
    /// </summary>
    public string? Upc { get; set; }

    /// <summary>
    /// Gets or sets item sort.
    /// </summary>
    public ItemSort? Sort { get; set; }

    /// <summary>
    /// Get collected values.
    /// </summary>
    /// <returns>Dicionary of key/values.</returns>
    public IDictionary<string, string?> GetValues() =>
        new Dictionary<string, string?>(9)
        {
            { "Categories", this.Categories },
            { "Keywords", this.Keywords },
            { "MaxPrice", this.MaxPrice?.ToString(CultureInfo.InvariantCulture) },
            { "MinPrice", this.MinPrice?.ToString(CultureInfo.InvariantCulture) },
            { "SearchType", this.SearchType },
            { "SellingStatus", this.SellingStatus.HasValue ? ((int)this.SellingStatus).ToString(CultureInfo.InvariantCulture) : null },
            { "SerialNumber", this.SerialNumber },
            { "SKU", this.Sku },
            { "UPC", this.Upc },
            { "Sort", this.Sort.HasValue ? ((int)this.Sort).ToString(CultureInfo.InvariantCulture) : null },
        };

    /// <summary>
    /// Get request parameters.
    /// </summary>
    /// <returns>Collection of parameters.</returns>
    public IEnumerable<Parameter> GetParameters() =>
        this.GetValues()
            .Where(v => !string.IsNullOrEmpty(v.Value))
            .Select(v => new QueryParameter(v.Key, v.Value));
}
