// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from "@kontent-ai/delivery-sdk";

const deliveryClient = createDeliveryClient({
  environmentId: "<YOUR_ENVIRONMENT_ID>",
});

const response = await deliveryClient.syncChanges().toPromise();

// Store the X-Continuation token in a persistent storage for later use
const continuationToken = response.xContinuationToken;

for (const item of response.data.items) {
  if (item.changeType === "changed") {
    // Process a changed item
  } else if (item.changeType === "deleted") {
    // Process a deleted item
  }
}

// Synchronize the next batch of changes
const nextResponse = await deliveryClient.syncChanges().withContinuationToken(continuationToken).toPromise();
