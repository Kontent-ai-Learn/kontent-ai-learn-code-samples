// DocSection: linked_content_get_page_with_subpages
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios

import KenticoKontentDelivery

let client = DeliveryClient.init(projectId: "8d20758c-d74c-4f59-ae04-ee928c0816b7")

client.getItem(modelType: Page.self, itemName: "insurance_listing") { (isSuccess, deliveryItem, error) in
     if isSuccess {
        if let page = itemResponse.item {
            // Use your page with its subpages here
        }
    } else {
        if let error = error {
            print(error)
        }
    }
// EndDocSection