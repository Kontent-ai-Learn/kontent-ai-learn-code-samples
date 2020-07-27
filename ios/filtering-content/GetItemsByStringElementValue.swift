// DocSection: filtering_get_items_by_string_element_value
// Filters items whose Title element value equals to "Hello World" 
let customQuery = "items?elements.title=Hello World"

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