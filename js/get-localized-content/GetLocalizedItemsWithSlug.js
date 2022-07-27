// DocSection: getting_localized_content_url_slug
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
});

const response = await deliveryClient.items('article')
  .type('article')
  .languageParameter('es-ES')
  .depthParameter(0)
  .equalsFilter('elements.url_pattern', 'acerda-de-nosotros')
  .toPromise();
// EndDocSection