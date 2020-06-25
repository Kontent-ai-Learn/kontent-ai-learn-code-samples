// DocSection: filtering_get_items_by_string_element_value
// Gets items whose URL Slug is as follows - this is same as filtering by text element value
let customQuery = "items?elements.url_slug=article-title"

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
