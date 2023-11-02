// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.updateWorkflow()
  .byWorkflowId("f9f28df0-9dec-4ee3-b087-c501e4b75347")
  //.byWorkflowCodename("my-workflow")
  .withData(
    {
      name: "My workflow",
      scopes: [
        {
          content_types: [
            {
              codename: "article"
            }
          ],
          collections: [
            {
              "id": "b15b6050-80d8-406d-bf21-3012e4ad0ac5"
            }
          ]
        }
      ],
      steps: [
        {
          name: "First step",
          codename: "first_step",
          color: "sky-blue",
          transitions_to: [
            {
              step: {
                id: "16221cc2-bd22-4414-a513-f3e555c0fc93"
              }
            },
            {
              step: {
                codename: "archived"
              }
            }
          ],
          role_ids: [
            "e796887c-38a1-4ab2-a999-c40861bb7a4b"
          ]
        },
        {
          name: "Renamed Second step",
          codename: "second_step_renamed",
          color: "rose",
          id: "16221cc2-bd22-4414-a513-f3e555c0fc93",
          transitions_to: [
            {
              step: {
                codename: "published"
              }
            }
          ],
          role_ids: []
        }
      ],
      published_step: {
        unpublish_role_ids: [],
        create_new_version_role_ids: [
            "e796887c-38a1-4ab2-a999-c40861bb7a4b"
        ]
      },
      archived_step: {
        role_ids: [
            "e796887c-38a1-4ab2-a999-c40861bb7a4b"
        ]
      }
    }
  )
  .toPromise();
