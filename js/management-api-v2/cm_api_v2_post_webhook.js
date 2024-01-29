// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.addWebhook()
  .withData(
    {
      name: "Example webhook",
      url: "https://example.com/webhook",
      secret: "secret_key",
      delivery_triggers: {
        slot: "preview",
        events: "specific",
        content_type: {
          enabled: "true",
          actions: [
          {
          action: "changed"
          }
          ]
          },
          asset: {
          enabled: "true",
          actions: [
          {
          action: "deleted"
          }
          ]
          },
          taxonomy: {
          enabled: "true",
          actions: [
          {
          action: "term_changed"
          }
          ]
          },
          language: {
          enabled: "true",
          actions: [
          {
          action: "changed"
          },
          {
          action: "created"
          }
          ]
          },
          content_item: {
          enabled: "true",
          actions: [
          {
          action: "workflow_step_changed",
          transition_to: []
          }
          ],
          filters: {
          collections: [
          {}
          ],
          content_types: [
          {}
          ],
          languages: [
          {}
          ]
      }
          }
  }
})
  .toPromise();