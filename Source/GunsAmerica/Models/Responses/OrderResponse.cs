namespace GunsAmerica.Models.Responses;

using System.Text.Json.Serialization;

/// <summary>
/// Order made in GunsAmerica.
/// </summary>
public record class OrderResponse
{
    /// <summary>
    /// Gets Order ID.
    /// </summary>
    [JsonPropertyName("OrderID")]
    public int OrderID { get; init; }

    /// <summary>
    /// Gets Order item IDs.
    /// </summary>
    [JsonPropertyName("ItemIDs")]
    public List<int> ItemIds { get; init; } = new();

    /// <summary>
    /// Gets Order billing name.
    /// </summary>
    [JsonPropertyName("BillToName")]
    public string BillToName { get; init; } = default!;

    /// <summary>
    /// Gets Order billing address 1.
    /// </summary>
    [JsonPropertyName("BillToAddress1")]
    public string BillToAddress1 { get; init; } = default!;

    /// <summary>
    /// Gets Order billing address 2.
    /// </summary>
    [JsonPropertyName("BillToAddress2")]
    public string BillToAddress2 { get; init; } = default!;

    /// <summary>
    /// Gets Order billing city.
    /// </summary>
    [JsonPropertyName("BillToCity")]
    public string BillToCity { get; init; } = default!;

    /// <summary>
    /// Gets Order billing state.
    /// </summary>
    [JsonPropertyName("BillToState")]
    public string BillToState { get; init; } = default!;

    /// <summary>
    /// Gets Order billing postal code.
    /// </summary>
    [JsonPropertyName("BillToPostalCode")]
    public string BillToPostalCode { get; init; } = default!;

    /// <summary>
    /// Gets Order billing country code.
    /// </summary>
    [JsonPropertyName("BillToCountryCode")]
    public string BillToCountryCode { get; init; } = default!;

    /// <summary>
    /// Gets Order billing/buyer email.
    /// </summary>
    [JsonPropertyName("BillToEmail")]
    public string BillToEmail { get; init; } = default!;

    /// <summary>
    /// Gets Order billing phone.
    /// </summary>
    [JsonPropertyName("BillToPhone")]
    public string BillToPhone { get; init; } = default!;

    /// <summary>
    /// Gets Order buyer.
    /// </summary>
    [JsonPropertyName("Buyer")]
    public Buyer Buyer { get; init; } = default!;

    /// <summary>
    /// Gets when the order was cancelled.
    /// </summary>
    [JsonPropertyName("CancelDate")]
    public DateTime CancelDate { get; init; }

    /// <summary>
    /// Gets percentage discount lost when using a credit card.
    /// </summary>
    [JsonPropertyName("LostCashDiscountPercent")]
    public decimal LostCashDiscountPercent { get; init; }

    /// <summary>
    /// Gets discount amount lost when using a credit card.
    /// </summary>
    [JsonPropertyName("LostCashDiscount")]
    public decimal LostCashDiscount { get; init; }

    /// <summary>
    /// Gets the FFL number on the order (if the order needed a FFL).
    /// </summary>
    [JsonPropertyName("FFLNumber")]
    public string FFLNumber { get; init; } = default!;

    /// <summary>
    /// Gets when the FFL was received.
    /// </summary>
    [JsonPropertyName("FFLReceivedDate")]
    public DateTime FFLReceivedDate { get; init; }

    /// <summary>
    /// Gets the FFL status.
    /// </summary>
    [JsonPropertyName("FFLStatus")]
    public string FFLStatus { get; init; } = FflStatuses.Unknown;

    /// <summary>
    /// Gets a value indicating whether buyer left feedback.
    /// </summary>
    [JsonPropertyName("HasBuyerLeftFeedback")]
    public bool HasBuyerLeftFeedback { get; init; }

    /// <summary>
    /// Gets a value indicating whether seller left feedback.
    /// </summary>
    [JsonPropertyName("HasSellerLeftFeedback")]
    public bool HasSellerLeftFeedback { get; init; }

    /// <summary>
    /// Gets a value indicating whether the order was placed on Seller store on GunsAmerica.
    /// </summary>
    [JsonPropertyName("IsStoreOrder")]
    public bool IsStoreOrder { get; init; }

    /// <summary>
    /// Gets Order items.
    /// </summary>
    [JsonPropertyName("Items")]
    public List<OrderItem> Items { get; init; } = new();

    /// <summary>
    /// Gets when the order was last modified.
    /// </summary>
    [JsonPropertyName("LastModifiedDate")]
    public DateTime LastModifiedDate { get; init; }

    /// <summary>
    /// Gets any miscellaneous up charge a seller may add.
    /// </summary>
    [JsonPropertyName("MiscCharge")]
    public decimal MiscCharge { get; init; }

    /// <summary>
    /// Gets the description of any miscellaneous up charge a seller may add.
    /// </summary>
    [JsonPropertyName("MiscDescription")]
    public string MiscDescription { get; init; } = default!;

    /// <summary>
    /// Gets order payment methods.
    /// </summary>
    [JsonPropertyName("PaymentMethods")]
    public Dictionary<PaymentMethod, string> PaymentMethods { get; init; } = new();

    /// <summary>
    /// Gets when the seller received payment.
    /// </summary>
    [JsonPropertyName("PaymentReceivedDate")]
    public DateTime PaymentReceivedDate { get; init; }

    /// <summary>
    /// Gets when the order was created.
    /// </summary>
    [JsonPropertyName("OrderDate")]
    public DateTime OrderDate { get; init; }

    /// <summary>
    /// Gets order total.
    /// </summary>
    [JsonPropertyName("OrderTotal")]
    public decimal OrderTotal { get; init; }

    /// <summary>
    /// Gets total tax amount.
    /// </summary>
    [JsonPropertyName("SalesTaxTotal")]
    public decimal SalesTaxTotal { get; init; }

    /// <summary>
    /// Gets order number.
    /// </summary>
    [JsonPropertyName("SellerOrderID")]
    public string SellerOrderID { get; init; } = default!;

    /// <summary>
    /// Gets shipping carrier.
    /// </summary>
    [JsonPropertyName("ShipCarrier")]
    public Dictionary<ShipCarrier, string> ShipCarrier { get; init; } = new();

    /// <summary>
    /// Gets shipping cost.
    /// </summary>
    [JsonPropertyName("ShipCost")]
    public decimal ShipCost { get; init; }

    /// <summary>
    /// Gets when the order shipped.
    /// </summary>
    [JsonPropertyName("ShipDate")]
    public DateTime ShipDate { get; init; }

    /// <summary>
    /// Gets seller warehouse name.
    /// </summary>
    [JsonPropertyName("ShipFromName")]
    public string ShipFromName { get; init; } = default!;

    /// <summary>
    /// Gets seller warehouse address 1.
    /// </summary>
    [JsonPropertyName("ShipFromAddress1")]
    public string ShipFromAddress1 { get; init; } = default!;

    /// <summary>
    /// Gets seller warehouse address 2.
    /// </summary>
    [JsonPropertyName("ShipFromAddress2")]
    public string ShipFromAddress2 { get; init; } = default!;

    /// <summary>
    /// Gets seller warehouse city.
    /// </summary>
    [JsonPropertyName("ShipFromCity")]
    public string ShipFromCity { get; init; } = default!;

    /// <summary>
    /// Gets seller warehouse state or province.
    /// </summary>
    [JsonPropertyName("ShipFromState")]
    public string ShipFromState { get; init; } = default!;

    /// <summary>
    /// Gets seller warehouse postal code.
    /// </summary>
    [JsonPropertyName("ShipFromPostalCode")]
    public string ShipFromPostalCode { get; init; } = default!;

    /// <summary>
    /// Gets seller warehouse email.
    /// </summary>
    [JsonPropertyName("ShipFromEmail")]
    public string ShipFromEmail { get; init; } = default!;

    /// <summary>
    /// Gets seller warehouse phone.
    /// </summary>
    [JsonPropertyName("ShipFromPhone")]
    public string ShipFromPhone { get; init; } = default!;

    /// <summary>
    /// Gets handling cost.
    /// </summary>
    [JsonPropertyName("ShipHandlingCost")]
    public decimal ShipHandlingCost { get; init; }

    /// <summary>
    /// Gets shipping insurance cost.
    /// </summary>
    [JsonPropertyName("ShipInsuranceCost")]
    public decimal ShipInsuranceCost { get; init; }

    /// <summary>
    /// Gets Order buyer name.
    /// </summary>
    [JsonPropertyName("ShipToName")]
    public string ShipToName { get; init; } = default!;

    /// <summary>
    /// Gets Order shipping address 1.
    /// </summary>
    [JsonPropertyName("ShipToAddress1")]
    public string ShipToAddress1 { get; init; } = default!;

    /// <summary>
    /// Gets Order shipping address 2.
    /// </summary>
    [JsonPropertyName("ShipToAddress2")]
    public string ShipToAddress2 { get; init; } = default!;

    /// <summary>
    /// Gets Order shipping city.
    /// </summary>
    [JsonPropertyName("ShipToCity")]
    public string ShipToCity { get; init; } = default!;

    /// <summary>
    /// Gets Order shipping state.
    /// </summary>
    [JsonPropertyName("ShipToState")]
    public string ShipToState { get; init; } = default!;

    /// <summary>
    /// Gets Order shipping postal code.
    /// </summary>
    [JsonPropertyName("ShipToPostalCode")]
    public string ShipToPostalCode { get; init; } = default!;

    /// <summary>
    /// Gets Order buyer email.
    /// </summary>
    [JsonPropertyName("ShipToEmail")]
    public string ShipToEmail { get; init; } = default!;

    /// <summary>
    /// Gets Order shipping phone.
    /// </summary>
    [JsonPropertyName("ShipToPhone")]
    public string ShipToPhone { get; init; } = default!;

    /// <summary>
    /// Gets Order tracking number.
    /// </summary>
    [JsonPropertyName("ShipTrackingNumber")]
    public string ShipTrackingNumber { get; init; } = default!;

    /// <summary>
    /// Gets Order status.
    /// </summary>
    [JsonPropertyName("Status")]
    public Dictionary<OrderStatus, string> Status { get; init; } = new();

    /// <summary>
    /// Gets a value indicating whether payment was received.
    /// </summary>
    [JsonPropertyName("PaymentReceived")]
    public bool PaymentReceived { get; init; }

    /// <summary>
    /// Gets Order notes.
    /// </summary>
    [JsonPropertyName("OrderNotes")]
    public List<OrderNote> Notes { get; init; } = new();

    /// <summary>
    /// Gets Order line items.
    /// </summary>
    [JsonPropertyName("OrderLineItems")]
    public List<OrderLine> Lines { get; init; } = new();

    /// <summary>
    /// Gets a value indicating whether order is local.
    /// </summary>
    [JsonPropertyName("IsLocalOrder")]
    public bool IsLocalOrder { get; init; }
}
