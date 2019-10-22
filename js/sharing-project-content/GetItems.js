// DocSection: sharing_project_content_get_items
const KontentDelivery = require("@kentico/kontent-delivery");

const deliveryClient1 = new KontentDelivery.DeliveryClient({
    projectId: "975bf280-fd91-488c-994c-2f04416e5ee3"
});

const deliveryClient2 = new KontentDelivery.DeliveryClient({
    projectId: "368d5707-fb05-0146-fc0a-f85c5d1a264e"
});

const allContentItems: ContentItem[] = [];

deliveryClient1.items()
    .toObservable()
    .subscribe(response => {
        // Add items to shared array
        allContentItems.push(...response.items);
    });
   
deliveryClient2.items()
    .toObservable()
    .subscribe(response => {
        // Add items to shared array
        allContentItems.push(...response.items);
    });
// EndDocSection