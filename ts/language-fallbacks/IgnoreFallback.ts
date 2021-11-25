// DocSection: language_fallbacks_ignore
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { ContentItem, DeliveryClient } from '@kentico/kontent-delivery';

const deliveryClient = new DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
});

deliveryClient.items<ContentItem>()
    .languageParameter('es-ES')
    .equalsFilter('system.language', 'es-ES')
    .toObservable()
    .subscribe(response => console.log(response.items));
// EndDocSection
