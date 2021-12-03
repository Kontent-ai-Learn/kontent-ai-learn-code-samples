// DocSection: filtering_get_subpages
// Gets pages linking travel insurance as their subpage.
let customQuery = "items?elements.subpages[contains]=travel_insurance"
// Gets pages linking at least travel insurance, car insurance, or both as their subpage.
// let customQuery = "items?elements.subpages[any]=travel_insurance,car_insurance"

client.getItems(modelType: Page.self, customQuery: customQuery) { (isSuccess, itemsResponse, error) in
    if isSuccess {
        if let pages = itemsResponse?.items {
            // Use your items here
        }
    } else {
        if let error = error {
            print(error)
        }
    }
}
// EndDocSection