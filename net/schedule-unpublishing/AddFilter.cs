// DocSection: schedule_unpublishing_add_filter
using KenticoCloud.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("14372844-0a5d-434a-8423-605b8a631623")
      .Build();

// Gets all articles
// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
var response = await client.GetItemsAsync<Article>(
    new EqualsFilter("system.type", "article")
);

var today = System.DateTime.Today;

// Filters the articles, keeping those that should be public
var itemsToDisplay = response.Items.Where((item) =>
		(item.PublishUntil > today || item.PublishUntil == null));

return View(itemsToDisplay);
// EndDocSection