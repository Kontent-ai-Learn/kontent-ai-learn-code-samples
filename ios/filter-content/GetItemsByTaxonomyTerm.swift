// DocSection: filtering_get_items_by_taxonomy_term
// Note: Filters work with codenames of the tags.
// Gets items tagged with one specific tag
let customQuery = "items?elements.tags[contains]=kontent_ai"
// Gets items tagged with a list of specific tags
// let customQuery = "items?elements.tags[all]=kontent_ai,platform"
// Gets items tagged with at least one of multiple tags
// let customQuery = "items?elements.tags[any]=modular,platform"

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