// DocSection: getting_localized_content_language
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoKontentDelivery

let client = DeliveryClient.init(projectId: "975bf280-fd91-488c-994c-2f04416e5ee3")

// More about strongly-typed models https://github.com/Kentico/kontent-delivery-sdk-swift#using-strongly-typed-models
client.getItem(modelType: Article.self, itemName: "on_roasts", language: "es-ES") { (isSuccess, itemResponse, error) in
    if isSuccess {
        if let article = itemResponse?.item {
            // Use your item here
        }
    } else {
        if let error = error {
            print(error)
        }
    }
}
// EndDocSection