// DocSection: delivery_api_get_item_preview
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = new KontentDelivery.DeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
  previewApiKey: '<YOUR_PREVIEW_API_KEY>',
  globalQueryConfig: {
    usePreviewMode: true, // Queries the Delivery Preview API.
  },
  typeResolvers: [
    // Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
    new KontentDelivery.TypeResolver('article', (rawData) => new Article)
  ]
});

deliveryClient.item('my_article')
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection