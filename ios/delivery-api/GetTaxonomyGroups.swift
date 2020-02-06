// DocSection: delivery_api_get_taxonomy_groups
// Tip: Find more about Swift SDKs at https://docs.kontent.ai/ios
import KenticoKontentDelivery

let client = DeliveryClient.init(projectId: "<YOUR_PROJECT_ID>")

client.getTaxonomies(completionHandler: { (isSuccess, deliveryItems, error) in
   if isSuccess {
       if let taxonomies = deliveryItems?.items {
        // use your taxonomies here
       }
    } else {
         if let error = error {
             print(error)
         }
    }
})
// EndDocSection