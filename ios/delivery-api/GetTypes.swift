// DocSection: delivery_api_get_types
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoKontentDelivery
 
let client = DeliveryClient.init(projectId: "975bf280-fd91-488c-994c-2f04416e5ee3")
 
client.getContentTypes(limit: 3, completionHandler: { (isSuccess, contentTypesResponse, error) in
    if !isSuccess {
        fail( "Response is not successful. Error: \(String(describing: error))" )
    }
     
    if let response = contentTypesResponse {
    // use content types here
    }
})
// EndDocSection