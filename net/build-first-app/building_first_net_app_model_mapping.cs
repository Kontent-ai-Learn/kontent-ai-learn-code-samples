// Retrieves 3 articles ordered by their post date
public async Task<ViewResult> Index()
{
    var response = await DeliveryClient.GetItemsAsync<Article>(
        new EqualsFilter("system.type", "article"),
        new LimitParameter(3),
        new DepthParameter(0),
        new OrderParameter("elements.post_date")
    );

    // Sends the strongly-typed content items to a View 
    return View(response.Items);
}
