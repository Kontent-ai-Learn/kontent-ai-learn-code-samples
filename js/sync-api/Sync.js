// DocSection: delivery_api_get_item
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>'
});

const response = await deliveryClient.syncChanges().toPromise();

// store this token in persistent storage for later use
const continuationToken = response.xContinuationToken;

for (const item of response.data.items) {
  if (item.changeType === "changed") {
    // process changed item
  } else if (item.changeType === "deleted") {
    // process deleted item
  }
}

// query next set of sync items
const nextResponse = await deliveryClient.syncChanges().withContinuationToken(continuationToken).toPromise();

// EndDocSection
