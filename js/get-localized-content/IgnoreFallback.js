// DocSection: language_fallbacks_ignore
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

const deliveryClient = KontentDelivery.createDeliveryClient({
  environmentId: '975bf280-fd91-488c-994c-2f04416e5ee3',
});

const response = await deliveryClient.items()
  .languageParameter('es-ES')
  .equalsFilter('system.language', 'es-ES')
  .toPromise();
// EndDocSection
