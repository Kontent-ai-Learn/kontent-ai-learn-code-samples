// DocSection: delivery_api_get_taxonomy_groups
// Tip: Find more about Swift SDKs at https://developer.kenticocloud.com/docs/ios
import KenticoCloud

let client = DeliveryClient.init(projectId: "975bf280-fd91-488c-994c-2f04416e5ee3")

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