// DocSection: delivery_api_get_items
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoCloud
 
let client = DeliveryClient.init(projectId:"975bf280-fd91-488c-994c-2f04416e5ee3")
 
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