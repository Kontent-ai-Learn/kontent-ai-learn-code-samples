// DocSection: sharing_project_content_get_items
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require("@kentico/kontent-delivery");

const deliveryClient1 = new KontentDelivery.DeliveryClient({
    projectId: "975bf280-fd91-488c-994c-2f04416e5ee3"
});

const deliveryClient2 = new KontentDelivery.DeliveryClient({
    projectId: "8d20758c-d74c-4f59-ae04-ee928c0816b7"
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