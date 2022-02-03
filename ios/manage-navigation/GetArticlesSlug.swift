// DocSection: managing_navigation_articles_slugs
// Tip: Find more about Swift SDK at https://kontent.ai/learn/ios
import KenticoKontentDelivery
 
let client = DeliveryClient.init(projectId:"8d20758c-d74c-4f59-ae04-ee928c0816b7")
 
let customQuery = "items?system.type=article&elements=title,url"
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