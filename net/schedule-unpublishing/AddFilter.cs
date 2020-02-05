// DocSection: schedule_unpublishing_add_filter
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets all articles
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
var response = await client.GetItemsAsync<Article>(
    new EqualsFilter("system.type", "article")
);

var today = System.DateTime.Today;

// Filters the articles, keeping those that should be public
var itemsToDisplay = response.Items.Where((item) =>
		(item.PublishUntil > today || item.PublishUntil == null));

return View(itemsToDisplay);
// EndDocSection