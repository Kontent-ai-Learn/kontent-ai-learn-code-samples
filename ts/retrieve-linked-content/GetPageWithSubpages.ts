// DocSection: linked_content_get_page_with_subpages
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';
import { Page } from './models/Page';

const deliveryClient = createDeliveryClient({
    environmentId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
});

const response = await deliveryClient.item<Page>('insurance_listing')
    .depthParameter(1)
    .toPromise();
// EndDocSection