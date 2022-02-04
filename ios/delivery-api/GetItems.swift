// DocSection: delivery_api_get_items
// Tip: Find more about Swift SDK at https://kontent.ai/learn/ios
import KenticoKontentDelivery
 
let client = DeliveryClient.init(projectId:"<YOUR_PROJECT_ID>")
 
let customQuery = "system.type=article&items?limit=3"
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
// EndDocSection