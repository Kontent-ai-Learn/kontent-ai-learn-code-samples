// DocSection: delivery_api_get_type
// Tip: Find more about Swift SDKs at https://kontent.ai/learn/ios
import KenticoKontentDelivery
 
let client = DeliveryClient.init(projectId: "<YOUR_PROJECT_ID>")
 
client.getContentType(name: "article", completionHandler: { (isSuccess, contentType, error) in
    if !isSuccess {
        fail( "Response is not successful. Error: \(String(describing: error))" )
    }
     
    if let type = contentType {
    // use content type here
    }
})
// EndDocSection