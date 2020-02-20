// DocSection: schedule_expiration_add_filter
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoKontentDelivery

let client = DeliveryClient.init(projectId: "8d20758c-d74c-4f59-ae04-ee928c0816b7")

let landingPageQueryParameters = QueryBuilder.params().type("landing_page")

// More about strongly-typed models https://github.com/Kentico/kontent-delivery-sdk-swift#using-strongly-typed-models
client.getItems(modelType: LandingPage.self,  queryParameters: landingPageQueryParameters) { (isSuccess, itemsResponse, error) in
    if isSuccess {
        if let landingPages = itemsResponse?.items {

            let now = Date()

            // Filters out the landing pages with no value in Expire at elements
            var publishedItems = landingPages.filter {
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