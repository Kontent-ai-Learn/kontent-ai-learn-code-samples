// DocSection: cm_api_v2_put_workflow
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
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
// EndDocSection