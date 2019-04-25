// DocSection: getting_content_get_items
import { ContentItem, DeliveryClient } from 'kentico-cloud-delivery';

const deliveryClient = new DeliveryClient({
  projectId: '975bf280-fd91-488c-994c-2f04416e5ee3'
});

deliveryClient.items<ContentItem>()
    .getObservable()
    .subscribe(response => console.log(response));
// EndDocSection