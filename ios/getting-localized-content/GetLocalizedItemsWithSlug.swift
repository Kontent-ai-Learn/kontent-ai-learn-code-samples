// DocSection: getting_localized_content_url_slug
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoKontentDelivery
 
let client = DeliveryClient.init(projectId:"975bf280-fd91-488c-994c-2f04416e5ee3")
 
let customQuery = "items?language=es-ES&system.type=home&elements.url_pattern=inicio"

// More about strongly-typed models https://github.com/Kentico/kontent-delivery-sdk-swift#using-strongly-typed-models
client.getItems(modelType: Home.self, customQuery: customQuery) { (isSuccess, itemsResponse, error) in
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