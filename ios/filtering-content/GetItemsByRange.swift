// DocSection: filtering_get_items_by_range
// system.last_modified value is stored with ms precision such as 2020-07-20T09:18:17.4857463Z
// Date&Time element value is stored with minute precision such as 2020-04-29T00:00:00Z

// Gets items modified between April 5, 2020 10:30 UTC and April 7, 2020, 7:00 UTC
let customQuery = "items?system.last_modified[range]=2020-05-05T10:30:00,2020-05-07T07:00:00"

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