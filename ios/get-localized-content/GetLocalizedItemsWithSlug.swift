// DocSection: getting_localized_content_url_slug
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoKontentDelivery
 
let client = DeliveryClient.init(projectId:"8d20758c-d74c-4f59-ae04-ee928c0816b7")
 
let customQuery = "items?language=es-ES&system.type=article&elements.url_pattern=acerda-de-nosotros"

// More about strongly-typed models https://github.com/Kentico/kontent-delivery-sdk-swift#using-strongly-typed-models
client.getItems(modelType: Article.self, customQuery: customQuery) { (isSuccess, itemsResponse, error) in
      if isSuccess {
           if let items = itemsResponse?.items {
               // Use your items here
           }
       } else {
           if let error = error {
               print(error)
           }
       }
// EndDocSection