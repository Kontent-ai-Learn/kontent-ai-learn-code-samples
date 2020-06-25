// DocSection: filtering_get_product_within_rating
// Gets products whose rating is at least 7 but no greater than 9
let customQuery = "items?elements.product_rating[range]=7,9"

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
