// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about Swift SDKs at https://kontent.ai/learn/ios
import KenticoKontentDelivery

let client = DeliveryClient.init(projectId: "<YOUR_PROJECT_ID>")

client.getTaxonomyGroup(taxonomyGroupName: "personas", completionHandler: { (isSuccess, deliveryItem, error) in
   if isSuccess {
       if let taxonomyGroup = deliveryItems.item {
        // use your taxonomy group here
       }
    } else {
         if let error = error {
             print(error)
         }
    }
})
// EndDocSection