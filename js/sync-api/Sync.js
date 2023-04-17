// DocSection: sync_api_synchronize_changes
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

const deliveryClient = KontentDelivery.createDeliveryClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>'
});

const response = await deliveryClient.syncChanges().toPromise();

// Store the X-Continuation token in a persistent storage for later use
const continuationToken = response.xContinuationToken;

for (const item of response.data.items) {
  if (item.changeType === "changed") {
    // Add logic for case when a content item is changed
  } else if (item.changeType === "deleted") {
    // Add logic for case when a content item is deleted
  }
}

// Synchronize the next batch of changes
const nextResponse = await deliveryClient.syncChanges().withContinuationToken(continuationToken).toPromise();
// EndDocSection