// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

// Specifies which asset rendition to use by default by providing defaultRenditionPreset
const deliveryClient = createDeliveryClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
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