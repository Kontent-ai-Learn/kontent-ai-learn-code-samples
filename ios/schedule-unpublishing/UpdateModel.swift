// DocSection: schedule_unpublishing_update_model
var publishUntil: DateTimeElement?

...

public required init?(map: Map){
    let mapper = MapElement.init(map: map)
    publishUntil = mapper.map(elementName: "publish_until", elementType: DateTimeElement.self)
    
    ...
}
// EndDocSection