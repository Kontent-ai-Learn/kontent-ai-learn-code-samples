// DocSection: getting_content_get_items
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { ContentItem, DeliveryClient } from '@kentico/kontent-delivery';

const deliveryClient = new DeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b'
});

deliveryClient.items<ContentItem>()
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection