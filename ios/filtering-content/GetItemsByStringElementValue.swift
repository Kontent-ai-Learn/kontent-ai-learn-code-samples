// DocSection: filtering_get_items_by_string_element_value
// Gets items whose Article title element equals "Get started with MVC"
let customQuery = "items?elements.article_title=Get started with MVC"

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
