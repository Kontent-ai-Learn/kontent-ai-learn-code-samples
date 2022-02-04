// DocSection: managing_navigation_articles_slugs
// Tip: Find more about Swift SDK at https://kontent.ai/learn/ios
import KenticoKontentDelivery

let client = DeliveryClient.init(projectId: "8d20758c-d74c-4f59-ae04-ee928c0816b7")

// Gets navigation items and their linked items
let rootQuery = "items/root_navigation_item?depth=5"

client.getItem(modelType: NavigationItem.self, customQuery: rootQuery) { (isSuccess, deliveryItem, error) in
     if isSuccess {
        if let root = deliveryItem.item {
            // Use your item here
        }
    } else {
        if let error = error {
            print(error)
        }
    }

// Gets specific elements of all articles
let articleQuery = "items?system.type=article&elements=title,url"
client.getItems(modelType: Article.self, customQuery: articleQuery) { (isSuccess, itemsResponse, error) in
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