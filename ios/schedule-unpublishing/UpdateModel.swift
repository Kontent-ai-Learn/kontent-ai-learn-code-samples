// DocSection: schedule_unpublishing_update_model
var ExpireAt: DateTimeElement?

...

public required init?(map: Map){
    let mapper = MapElement.init(map: map)
    ExpireAt = mapper.map(elementName: "publish_until", elementType: DateTimeElement.self)
    
    ...
}
// EndDocSection