// DocSection: language_fallbacks_ignore
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { createDeliveryClient } from '@kentico/kontent-delivery';

const deliveryClient = createDeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
});

const response = await deliveryClient.items()
    .languageParameter('es-ES')
    .equalsFilter('system.language', 'es-ES')
    .toPromise();
// EndDocSection
