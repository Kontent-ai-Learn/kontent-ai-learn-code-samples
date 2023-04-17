// DocSection: preview_content_get_article
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

const deliveryClient = KontentDelivery.createDeliveryClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  previewApiKey: '<YOUR_PREVIEW_API_KEY>',
  defaultQueryConfig: {
    usePreviewMode: true, // Queries the Delivery Preview API.
  }
});

const response = await deliveryClient.item('my_article')
  .toPromise();
// EndDocSection