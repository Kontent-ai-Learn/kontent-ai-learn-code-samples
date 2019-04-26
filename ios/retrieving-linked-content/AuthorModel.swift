// DocSection: linked_content_author_model
// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models

import ObjectMapper
import KenticoCloud

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