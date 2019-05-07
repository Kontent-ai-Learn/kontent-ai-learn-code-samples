// DocSection: language_fallbacks_ignore
import { ContentItem, DeliveryClient, Fields, TypeResolver } from 'kentico-cloud-delivery';

const deliveryClient = new DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
});

deliveryClient.items<Article>()
    .languageParameter('es-ES')
    .equalsFilter('system.language', 'es-ES')
    .getObservable()
    .subscribe(response => console.log(response.items));
// EndDocSection
