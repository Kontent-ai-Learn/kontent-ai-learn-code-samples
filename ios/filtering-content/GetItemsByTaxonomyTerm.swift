// DocSection: filtering_get_items_by_taxonomy_term
// Get articles tagged with specific tag
let customQuery = "items?elements.tags[contains]=kentico"

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

// Gets articles tagged with any of the below tags
let customQuery = "items?elements.tags[any]=sport,soccer"

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

// Gets articles tagged with all of the below tags
let customQuery = "items?elements.tags[all]=mvc,kontent,headless"

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
