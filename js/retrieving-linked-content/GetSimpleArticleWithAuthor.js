// DocSection: linked_content_get_article_with_author
const KenticoCloud = require('kentico-cloud-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class SimpleArticle extends KenticoCloud.ContentItem {
    constructor() {
        super();
    }
}
class Author extends KenticoCloud.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: 'e6d2946e-0e24-003f-a397-9d2d458c6d6e',
    typeResolvers: [
        new KenticoCloud.TypeResolver('author', (rawData) => new Author())
    ]
});

deliveryClient.item('the_origin_of_coffee')
    .depthParameter(1)
    .toObservable()
    .subscribe(response => console.log(response.item));
// EndDocSection