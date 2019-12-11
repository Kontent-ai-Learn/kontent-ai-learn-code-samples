// DocSection: linked_content_author_model
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios

import ObjectMapper
import KenticoKontentDelivery

public class Author: Mappable {
    var name: TextElement?
    var bio: RichTextElement?
    
    public required init?(map: Map){
        let mapper = MapElement.init(map: map)
        name = mapper.map(elementName: "name", elementType: TextElement.self)
        bio = mapper.map(elementName: "bio", elementType: RichTextElement.self)
    }
    
    public func mapping(map: Map) {
    }
}
// EndDocSection