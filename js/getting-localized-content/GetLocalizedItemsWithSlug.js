// DocSection: getting_localized_content_url_slug
const KenticoCloud = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Home extends KenticoCloud.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    typeResolvers: [
        new KenticoCloud.TypeResolver('home', (rawData) => new Home)
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