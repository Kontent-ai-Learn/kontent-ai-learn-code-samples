// DocSection: getting_localized_content_language
const KontentDelivery = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Article extends KontentDelivery.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KontentDelivery.DeliveryClient({
  projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
  typeResolvers: [
    new KontentDelivery.TypeResolver('article', (rawData) => new Article)
  ]
});

deliveryClient.item('on_roasts')
  .languageParameter('es-ES')
  .toObservable()
  .subscribe(response => console.log(response.item));
// EndDocSection