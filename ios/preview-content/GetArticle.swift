// DocSection: preview_content_get_article
import KenticoCloud

let client = DeliveryClient.init(projectId: "<YOUR_PROJECT_ID>", apiKey: "<YOUR_PREVIEW_API_KEY>")

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