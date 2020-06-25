// DocSection: filtering_get_items_by_array_element_value
// Get items where multiple choice has a specific value
let customQuery = "items?elements.multiple_choice[contains]=value"

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

// Get items where multiple choice has any of the below values
let customQuery = "items?elements.multiple_choice[any]=value1,value2"

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
