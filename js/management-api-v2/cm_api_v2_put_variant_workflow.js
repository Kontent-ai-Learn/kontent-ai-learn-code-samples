// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from "@kontent-ai/management-sdk";

const client = new ManagementClient({
  environmentId: "<YOUR_ENVIRONMENT_ID>",
  apiKey: "<YOUR_API_KEY>",
});

const response = await client
  .changeWorkflowOfLanguageVariant()
  .byItemId("f4b3fc05-e988-4dae-9ac1-a94aba566474")
  // .byItemCodename('my_article')
  // .byItemExternalId('59713')
  .byLanguageId("d1f95fde-af02-b3b5-bd9e-f232311ccab8")
  // .byLanguageCodename('es-ES')
  .withData({
    step_identifier: {
      id: "dc87d7cf-424b-4b89-9519-c9f79a3458b7",
      // codename: 'review'
    },
    workflow_identifier: {
      id: "06ea628e-4ec7-4991-91e4-1412995151ee",
      // codename: 'default'
    },
  })
  .toPromise();
