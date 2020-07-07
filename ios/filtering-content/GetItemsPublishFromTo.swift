// DocSection: filtering_get_published_from_to
// Gets items whose publish date is at least 2020-05-10, 00:00:00
let customQuery = "items?elements.publish_date[gt]=2020-05-10"

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

// Gets items whose publish date is at least 2020-05-10, 00:00:00
let customQuery = "items?elements.publish_date[gte]=2020-05-10"

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

// Gets items whose publish date is at most 2020-05-19, 23:59:00
let customQuery = "items?elements.publish_date[lt]=2020-05-20"

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

// Gets items whose publish date is at most 2020-05-19, 23:59:00
let customQuery = "items?elements.publish_date[lte]=2020-05-20"

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
