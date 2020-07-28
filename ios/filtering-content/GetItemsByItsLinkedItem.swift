// DocSection: filtering_get_items_by_linked_item
// Gets items attributed to Jane. Matched items may also contain other authors.
let customQuery = "items?elements.author[contains]=jane_doe"
// Gets items attributed to at least Jane, John, or both. Matched items may also contain other authors.
// let customQuery = "items?elements.author[any]=jane_doe,john_wick"

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