// DocSection: linked_content_author_model
// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
// Tip: Find more about Swift SDK at https://kontent.ai/learn/ios

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