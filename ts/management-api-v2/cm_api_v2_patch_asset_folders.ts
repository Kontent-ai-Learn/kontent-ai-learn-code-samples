// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.modifyAssetFolders()
  .withData(
    [
      {
        op: 'addinto',
        value: {
          external_id: 'folder-with-shared-assets',
          codename: 'shared_assets',
          name: 'Shared assets',
          folders: []
        },
        before: {
          external_id: 'folder-with-downloadable-assets'
        }
      },
      {
        op: 'remove',
        reference: {
          external_id: 'folder-with-downloadable-archives'
        }
      },
      {
        op: 'rename',
        value: 'Legal documents',
        reference: {
          codename: 'folder_documents'
        }
      }
    ]
  )
  .toPromise();