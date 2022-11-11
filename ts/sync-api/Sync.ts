// DocSection: sync_api_sync
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from "@kontent-ai/delivery-sdk";

const deliveryClient = createDeliveryClient({
  projectId: "<YOUR_PROJECT_ID>",
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
