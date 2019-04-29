// DocSection: managing_navigation_articles_depth
import KenticoCloud

let client = DeliveryClient.init(projectId: "24246f25-946d-4ab4-b170-fadef22fe7b2")

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