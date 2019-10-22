// DocSection: sharing_project_content_get_items
import { ContentItem, DeliveryClient } from "@kentico/kontent-delivery";

const deliveryClient1 = new DeliveryClient({
    projectId: "975bf280-fd91-488c-994c-2f04416e5ee3"
});

const deliveryClient2 = new DeliveryClient({
    projectId: "368d5707-fb05-0146-fc0a-f85c5d1a264e"
});

const allContentItems: ContentItem[] = [];

deliveryClient1.items<ContentItem>()
    .toObservable()
    .subscribe(response => {
        // Add items to shared array
        allContentItems.push(...response.items);
    });
   
deliveryClient2.items<ContentItem>()
    .toObservable()
    .subscribe(response => {
        // Add items to shared array
        allContentItems.push(...response.items);
    });
// EndDocSection