// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript

// @kontent-ai/delivery-sdk v16
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  environmentId: '975bf280-fd91-488c-994c-2f04416e5ee3',
});

// Gets content items in Spanish without following language fallbacks 
const response = await deliveryClient.items()
  .languageParameter('es-ES')
  .equalsFilter('system.language', 'es-ES')
  .toPromise();

// @kontent-ai/delivery-sdk v17
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  apiMode: 'public',
  environmentId: '975bf280-fd91-488c-994c-2f04416e5ee3',
});

// Gets content items in Spanish without following language fallbacks
const response = await deliveryClient.listContentItems({
  query: { language: 'es-ES' },
  filters: [{ property: 'system.language', operator: 'eq', value: 'es-ES' }]
})
  .fetchPage();
