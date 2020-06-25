// DocSection: filtering_get_item_by_id
// Gets items whose codename is one of the following
let customQuery = "items?system.codename[in]=welcome_to_mvc,top_10_websites,kontent_best_practices"

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
