// DocSection: filtering_get_item_by_id
let customQuery = "items?system.id=2f7288a1-cfc8-47be-9bf1-b1d312f7da18"

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
