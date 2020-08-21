// DocSection: cm_api_v2_patch_asset_folders
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.modifyAssetFolders()
  .withData(
    [
      {
        op: "addinto",
        value: {
          external_id: "folder-with-shared-assets",
          name: "Shared assets",
          folders: [ ]
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
  .toObservable()
  .subscribe((response) => {
    // work with response
  },
  (error) => {
    console.log(error)
  });
//EndDocSection
