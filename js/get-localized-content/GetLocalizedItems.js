// DocSection: getting_localized_content_language
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
});

const response = await deliveryClient.item('about_us')
  .languageParameter('es-ES')
  .toPromise();
// EndDocSection