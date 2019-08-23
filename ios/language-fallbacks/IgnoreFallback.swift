// DocSection: language_fallbacks_ignore
import KenticoCloud
 
let client = DeliveryClient.init(projectId:"975bf280-fd91-488c-994c-2f04416e5ee3")
 
let customQuery = "items?language=es-ES&system.language=es-ES"

// More about strongly typed models https://github.com/Kentico/cloud-sdk-swift#using-strongly-typed-models
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
