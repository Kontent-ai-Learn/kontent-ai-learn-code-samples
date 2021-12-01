// DocSection: linked_content_get_page_with_subpages
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { createDeliveryClient } from '@kentico/kontent-delivery';
import { Page } from './models/Page';

const deliveryClient = createDeliveryClient({
    projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
});

const response = await deliveryClient.item<Page>('insurance_listing')
    .depthParameter(1)
    .toPromise();
// EndDocSection