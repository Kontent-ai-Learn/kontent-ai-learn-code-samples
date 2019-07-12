// DocSection: delivery_api_get_type
// Tip: Find more about Swift SDKs at https://developer.kenticocloud.com/docs/ios
import KenticoCloud
 
let client = DeliveryClient.init(projectId: "975bf280-fd91-488c-994c-2f04416e5ee3")
 
client.getContentType(name: "coffee", completionHandler: { (isSuccess, contentType, error) in
    if !isSuccess {
        fail( "Response is not successful. Error: \(String(describing: error))" )
    }
     
    if let type = contentType {
    // use content type here
    }
})
// EndDocSection