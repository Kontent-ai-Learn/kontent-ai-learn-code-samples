// DocSection: filtering_datetime_lte_gte
// system.last_modified value is stored with ms precision such as 2020-07-20T09:18:17.4857463Z
// Date&Time element value is stored with minute precision such as 2020-04-29T00:00:00Z

// Filters items modified after April 9 2020, 9 am UTC+0
let customQuery = "items?system.last_modified[gt]=2020-05-09T09:00:00.000000Z"

// Other examples:
// Filters items released at or after April 9 2020, 7 am UTC+0
// let customQuery = "elements.release_date[gte]=2020-05-09T07:00:00Z"
// Filters items modified before April 5 2020 UTC+0
// let customQuery = "system.last_modified[lt]=2020-05-05"
// Filters items released at or before April 5 2020 10:30 am UTC+0
// let customQuery = "elements.release_date[lte]=2020-05-05T10:30:00Z"

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