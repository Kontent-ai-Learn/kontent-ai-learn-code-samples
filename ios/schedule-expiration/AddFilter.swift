// DocSection: schedule_unpublishing_add_filter
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoKontentDelivery

let client = DeliveryClient.init(projectId: "8d20758c-d74c-4f59-ae04-ee928c0816b7")

let articlesQueryParameters = QueryBuilder.params().type("article")

// More about strongly-typed models https://github.com/Kentico/kontent-delivery-sdk-swift#using-strongly-typed-models
client.getItems(modelType: Article.self,  queryParameters: articleQueryParameters) { (isSuccess, itemsResponse, error) in
    if isSuccess {
        if let articles = itemsResponse?.items {

            let now = Date()

            // Filters out the articles with no value in Publish until elements
            var publishedArticles = articles.filter {
                (($0.ExpireAt?.value)! > now)
            }
        }
    } else {
        if let error = error {
            print(error)
        }
    }
}
// EndDocSection