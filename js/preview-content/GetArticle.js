// DocSection: preview_content_get_article
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
  previewApiKey: '<YOUR_PREVIEW_API_KEY>',
  globalQueryConfig: {
    usePreviewMode: true, // Queries the Delivery Preview API.
  }
});

const response = await deliveryClient.item('my_article')
  .toPromise();
// EndDocSection