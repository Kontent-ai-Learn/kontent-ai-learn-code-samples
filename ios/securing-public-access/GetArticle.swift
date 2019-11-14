// DocSection: securing_public_access_get_article
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoCloud

let client = DeliveryClient.init(projectId: "975bf280-fd91-488c-994c-2f04416e5ee3", secureApiKey: "<YOUR_API_KEY>")

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
client.getItem(modelType: Article.self, itemName: "on_roasts") { (isSuccess, deliveryItem, error) in
     if isSuccess {
        if let article = deliveryItem.item {
            // Use your item here
        }
    } else {
        if let error = error {
            print(error)
        }
    }
// EndDocSection