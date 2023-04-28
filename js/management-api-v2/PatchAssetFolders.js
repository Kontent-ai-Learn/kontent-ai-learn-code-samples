// DocSection: cm_api_v2_patch_asset_folders
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>,
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.modifyAssetFolders()
  .withData(
    [
      {
        op: "addinto",
        value: {
          external_id: "folder-with-shared-assets",
          name: "Shared assets",
          folders: []
        },
        before: {
          external_id: "folder-with-downloadable-assets"
        }
      },
      {
        op: "remove",
        reference: {
          external_id: "folder-with-downloadable-archives"
        }
      },
      {
        op: "rename",
        value: "Legal documents",
        reference: {
          external_id: "folder-documents"
        }
      }
    ]
  )
  .toPromise();
// EndDocSection
