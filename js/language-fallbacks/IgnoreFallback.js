// DocSection: language_fallbacks_ignore
const KenticoCloud = require('@kentico/kontent-delivery');

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
});

deliveryClient.items()
    .languageParameter('es-ES')
    .equalsFilter('system.language', 'es-ES')
    .toObservable()
    .subscribe(response => console.log(response.items));
// EndDocSection
