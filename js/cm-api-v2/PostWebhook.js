// DocSection: cm_api_v2_post_webhook
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addWebhook()
  .withData(
    {
      name: "Example webhook",
      url: "https://example.com/webhook",
      secret: "secret_key",
      triggers: {
        delivery_api_content_changes: [
          {
            type: "content_item_variant",
            operations: [
              "publish",
              "unpublish"
            ]
          },
          {
            type: "taxonomy",
            operations: [
              "archive",
              "restore",
              "upsert"
            ]
          }
        ],
        preview_delivery_api_content_changes: [
          {
            type: "content_item_variant",
            operations: [
              "archive",
              "upsert"
            ]
          },
          {
            type: "taxonomy",
            operations: [
              "archive",
              "restore",
              "upsert"
            ]
          }
        ],
        workflow_step_changes: [
          {
            type: "content_item_variant",
            transitions_to: [
              {
                id: "b4363ccd-8f21-45fd-a840-5843d7b7f008"
              },
              {
                id: "88ac5e6e-1c5c-4638-96e1-0d61221ad5bf"
              }
            ]
          }
        ],
        management_api_content_changes: [
          {
            type: "content_item_variant",
            operations: [
              "archive",
              "create",
              "restore"
            ]
          }
        ]
      }
    }
  )
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
  (error) => {
    console.log(error);
  });
// EndDocSection