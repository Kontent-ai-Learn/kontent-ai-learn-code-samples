// DocSection: filtering_get_items_of_type
// Gets items based on the type Product
let customQuery = "items?system.type=product"

client.getItems(modelType: Product.self, customQuery: customQuery) { (isSuccess, itemsResponse, error) in
    if isSuccess {
        if let products = itemsResponse?.items {
            // Use your items here
        }
    } else {
        if let error = error {
            print(error)
        }
    }
}
// EndDocSection
