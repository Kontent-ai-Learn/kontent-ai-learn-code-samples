// DocSection: schedule_unpublishing_filter_by_date
// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("14372844-0a5d-434a-8423-605b8a631623")
      .Build();

var now = System.DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssZ");

// Gets articles that should be public
// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
DeliveryItemListingResponse<Article> response = await client.GetItemsAsync<Article>(
  new EqualsFilter("system.type", "article"),
  new GreaterThanFilter("elements.publish_until", now)
);

return View(response.Items);
// EndDocSection