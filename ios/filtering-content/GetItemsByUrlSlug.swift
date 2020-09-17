// DocSection: filtering_get_items_by_url_slug
// Gets items whose URL slug equals to sample-url-slug
let customQuery = "items?elements.url_slug=sample-url-slug"

client.getItems(modelType: Article.self, customQuery: customQuery) { (isSuccess, itemsResponse, error) in
    if isSuccess {
        if let articles = itemsResponse?.items {
            // Use your items here
        }
    } else {
        if let error = error {
            print(error)
        }
    }
}
// EndDocSection