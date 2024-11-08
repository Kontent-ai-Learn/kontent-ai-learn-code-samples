// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.addLegacyWebhook()
  .withData(
    {
      name: 'Example webhook',
      url: 'https://example.com/webhook',
      secret: 'secret_key',
      triggers: {
        delivery_api_content_changes: [
          {
            type: 'content_item_variant',
            operations: [
              'publish',
              'unpublish'
            ]
          },
          {
            type: 'taxonomy',
            operations: [
              'archive',
              'restore',
              'upsert'
            ]
          }
        ],
        preview_delivery_api_content_changes: [
          {
            type: 'content_item_variant',
            operations: [
              'archive',
              'upsert'
            ]
          },
          {
            type: 'taxonomy',
            operations: [
              'archive',
              'restore',
              'upsert'
            ]
          }
        ],
        workflow_step_changes: [
          {
            type: 'content_item_variant',
            transitions_to: [
              {
                id: 'b4363ccd-8f21-45fd-a840-5843d7b7f008'
              },
              {
                id: '88ac5e6e-1c5c-4638-96e1-0d61221ad5bf'
              }
            ]
          }
        ],
        management_api_content_changes: [
          {
            type: 'content_item_variant',
            operations: [
              'archive',
              'create',
              'restore'
            ]
          }
        ]
      }
    }
  )
  .toPromise();