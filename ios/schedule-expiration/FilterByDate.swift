// DocSection: schedule_expiration_filter_by_date
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoKontentDelivery

let client = DeliveryClient.init(projectId: "8d20758c-d74c-4f59-ae04-ee928c0816b7")

// Formats current date & time to ISO-8601
let dateformatter = DateFormatter()
dateformatter.dateFormat = "yyyy-MM-dd'T'HH:mm:ss'Z'"
let now = dateformatter.string(from: Date())

let customQuery = "items?system.type=article&elements.expire_at[gt]=\(now)"

// More about strongly-typed models https://github.com/Kentico/kontent-delivery-sdk-swift#using-strongly-typed-models
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