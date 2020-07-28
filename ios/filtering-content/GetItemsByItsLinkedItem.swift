// DocSection: filtering_get_items_by_linked_item
// Gets items whose linked item has codename as one of specified values
let customQuery = "items?elements.authors[any]=john_snow,johnny_bravo"

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

// Gets items whose linked item has codename of certain value
let customQuery = "items?elements.authors[contains]=joe_down"

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
