// DocSection: cm_api_v2_post_asset_folders
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.addAssetFolders()
  .withData(
    {
      folders: [
        {
          id: "958001d8-2228-4373-b966-5262b5b96f71",
          name: "Downloads",
          external_id: "folder-with-downloadable-assets",
          folders: [
            {
              id: "9ca927b6-6e4d-4d6b-81e3-ec5e8f7772a0",
              name: "Archives",
              external_id: "folder-with-downloadable-archives",
              folders: []
            }
          ]
        },
        {
          id: "9ca927b6-6e4d-4d6b-81e3-ec5e8f7772a0",
          name: "Legal documents",
          external_id: "folder-documents",
          folders: []
        }
      ]
    }
  )
  .toPromise();
// EndDocSection