// DocSection: linked_content_get_page_with_subpages
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { DeliveryClient, TypeResolver } from '@kentico/kontent-delivery';
import { Page } from './models/Page';

const deliveryClient = new DeliveryClient({
    projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
    typeResolvers: [
        // Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
        new TypeResolver('page', (rawData) => new Page)
    ]
});

deliveryClient.item<Page>('insurance_listing')
    .depthParameter(1)
    .toObservable()
    .subscribe(response => console.log(response.item));
// EndDocSection