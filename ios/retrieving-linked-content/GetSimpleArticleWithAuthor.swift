// DocSection: linked_content_get_article_with_author
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models

import KenticoCloud

let client = DeliveryClient.init(projectId: "e6d2946e-0e24-003f-a397-9d2d458c6d6e")

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