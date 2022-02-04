// DocSection: linked_content_get_article_with_author
// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
// Tip: Find more about Swift SDK at https://kontent.ai/learn/ios

import KenticoKontentDelivery

let client = DeliveryClient.init(projectId: "8d20758c-d74c-4f59-ae04-ee928c0816b7")

client.getItem(modelType: SimpleArticle.self, itemName: "the_origin_of_coffee") { (isSuccess, deliveryItem, error) in
     if isSuccess {        
        for authorCodeName in (itemResponse?.item?.author?.value)! {
            let author = itemResponse?.getLinkedItems(codename: authorCodeName, type: Author.self)
        }
        
        if let article = itemResponse.item {
            // Use your article with its author here
        }
    } else {
        if let error = error {
            print(error)
        }
    }
// EndDocSection