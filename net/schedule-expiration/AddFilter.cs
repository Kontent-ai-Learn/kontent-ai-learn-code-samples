// DocSection: schedule_expiration_add_filter
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets all landing pages
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
var response = await client.GetItemsAsync<LandingPage>(
    new EqualsFilter("system.type", "landing_page")
);

var today = System.DateTime.Today;

// Filters the landing pages, keeping those that should be public
var itemsToDisplay = response.Items.Where((item) =>
		(item.ExpireAt > today || item.ExpireAt == null));

return View(itemsToDisplay);
// EndDocSection