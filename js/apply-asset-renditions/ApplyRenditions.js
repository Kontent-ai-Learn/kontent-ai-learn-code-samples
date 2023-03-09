// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

// Specifies which asset rendition to use by default by providing defaultRenditionPreset
const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
  // Automatically applies the 'default' asset rendition if assets specify it
  defaultRenditionPreset: 'default'
});

// Requests a content item
const response = await deliveryClient.item('my_article')
  .toPromise();

// Gets the first asset in the 'teaser_image' asset element
const asset = response.data.item.elements.teaser_image.value[0];

// Gets the asset's URL. If the asset specifies a rendition, it's automatically applied.
const assetUrl = asset.url;