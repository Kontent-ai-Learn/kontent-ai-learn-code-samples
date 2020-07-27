// DocSection: filtering_get_items_by_taxonomy_term
// Get items tagged with a single tag
let customQuery = "items?elements.tags[contains]=kontent"
// Gets items tagged with multiple tags
// let customQuery = "items?elements.tags[all]=kontent,headless"
// Gets items tagged with at least one of multiple tags
// let customQuery = "items?elements.tags[any]=football,soccer"

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