// DocSection: securing_public_access_get_article
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoKontentDelivery

let client = DeliveryClient.init(projectId: "<YOUR_PROJECT_ID>", secureApiKey: "<YOUR_API_KEY>")

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
client.getItem(modelType: Article.self, itemName: "my_article") { (isSuccess, deliveryItem, error) in
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