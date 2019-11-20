// DocSection: getting_localized_content_url_slug
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Home extends KontentDelivery.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    typeResolvers: [
        new KontentDelivery.TypeResolver('home', (rawData) => new Home)
    ]
});

deliveryClient.items('home')
  .type('home')  
  .languageParameter('es-ES')
  .depthParameter(0)
  .equalsFilter('elements.url_pattern', 'inicio')
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection