// DocSection: managing_navigation_articles_depth
// Tip: Find more about Swift SDK at https://kontent.ai/learn/ios
import KenticoKontentDelivery

let client = DeliveryClient.init(projectId: "8d20758c-d74c-4f59-ae04-ee928c0816b7")

let customQuery = "items/root_navigation_item?depth=5"

client.getItem(modelType: NavigationItem.self, customQuery: customQuery) { (isSuccess, deliveryItem, error) in
     if isSuccess {
        if let root = deliveryItem.item {
            // Use your item here
        }
    } else {
        if let error = error {
            print(error)
        }
    }
// EndDocSection