// DocSection: delivery_api_get_item_preview
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoCloud

let client = DeliveryClient.init(projectId: "975bf280-fd91-488c-994c-2f04416e5ee3", apiKey: "<YOUR_PREVIEW_API_KEY>")

// More about strongly-typed models https://github.com/Kentico/cloud-sdk-swift#using-strongly-typed-models
client.getItem(modelType: Article.self, itemName: "on_roasts") { (isSuccess, itemResponse, error) in
    if isSuccess {
        if let article = itemResponse.item {
            // Use your item here
        }
    } else {
        if let error = error {
            print(error)
        }
    }
}
// EndDocSection