// DocSection: filtering_get_items_of_type
// Gets items whose publish date is at least 2020-05-10, 00:00:00 but no greater than 2020-05-20, 00:00:00
let customQuery = "items?elements.publish_date[range]=2020-05-10,2020-05-20"

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
