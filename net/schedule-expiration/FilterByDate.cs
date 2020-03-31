// DocSection: schedule_expiration_filter_by_date
// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-delivery-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

var now = System.DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssZ");

// Gets articles that should be public
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemListingResponse<Article> response = await client.GetItemsAsync<Article>(
  new EqualsFilter("system.type", "article"),
  new GreaterThanFilter("elements.expire_at", now)
);

return View(response.Items);
// EndDocSection