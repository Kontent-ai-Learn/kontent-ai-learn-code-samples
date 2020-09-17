// DocSection: getting_localized_content_language
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = new KontentDelivery.DeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
  typeResolvers: [
    // Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
    new KontentDelivery.TypeResolver('article', (rawData) => new Article)
  ]
});

deliveryClient.item('about_us')
  .languageParameter('es-ES')
  .toObservable()
  .subscribe(response => console.log(response.item));
// EndDocSection