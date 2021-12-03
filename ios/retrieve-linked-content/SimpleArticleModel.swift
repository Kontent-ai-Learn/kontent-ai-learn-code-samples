// DocSection: linked_content_simple_article_model
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios

import ObjectMapper
import KenticoKontentDelivery

class SimpleArticle: Mappable {
    var title: TextElement?
    var body: RichTextElement?
    var author: LinkedItemsElement?
    
    required init?(map: Map){
        let mapper = MapElement.init(map: map)
        title = mapper.map(elementName: "title", elementType: TextElement.self)
        body = mapper.map(elementName: "body", elementType: RichTextElement.self)
        author = mapper.map(elementName: "author", elementType: LinkedItemsElement.self)
    }
    
    func mapping(map: Map) {
    }
}
// EndDocSection