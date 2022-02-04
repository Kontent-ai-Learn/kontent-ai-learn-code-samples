// DocSection: getting_localized_content_language
// Tip: Find more about Swift SDK at https://kontent.ai/learn/ios
import KenticoKontentDelivery

let client = DeliveryClient.init(projectId: "8d20758c-d74c-4f59-ae04-ee928c0816b7")

// More about strongly-typed models https://github.com/Kentico/kontent-delivery-sdk-swift#using-strongly-typed-models
client.getItem(modelType: Article.self, itemName: "about_us", language: "es-ES") { (isSuccess, itemResponse, error) in
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