// DocSection: delivery_api_get_items
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoKontentDelivery
 
let client = DeliveryClient.init(projectId:"<YOUR_PROJECT_ID>")
 
let customQuery = "items?system.type=article&elements=title,summary,post_date&order=elements.post_date[desc]"
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