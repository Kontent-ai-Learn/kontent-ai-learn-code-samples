// DocSection: using_webhooks_get_latest_content
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = new KontentDelivery.DeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
  typeResolvers: [
    // Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
    new KontentDelivery.TypeResolver('article', (rawData) => new Article())
  ]
});

deliveryClient.item('my_article')
  .queryConfig({ waitForLoadingNewContent: true })
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection