// DocSection: linked_content_get_article_with_author
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class SimpleArticle extends KontentDelivery.ContentItem {
    constructor() {
        super();
    }
}
class Author extends KontentDelivery.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
    typeResolvers: [
        new KontentDelivery.TypeResolver('author', (rawData) => new Author())
    ]
});

deliveryClient.item('the_origin_of_coffee')
    .depthParameter(1)
    .toObservable()
    .subscribe(response => console.log(response.item));
// EndDocSection