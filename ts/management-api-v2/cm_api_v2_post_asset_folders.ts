// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.addAssetFolders()
  .withData(
    {
      folders: [
        {
          id: '958001d8-2228-4373-b966-5262b5b96f71',
          name: 'Downloads',
          codename: 'downloads',
          external_id: 'folder-with-downloadable-assets',
          folders: [
            {
              id: '9ca927b6-6e4d-4d6b-81e3-ec5e8f7772a0',
              name: 'Archives',
              codename: 'archives',
              external_id: 'folder-with-downloadable-archives'
            }
          ]
        },
        {
          id: '9ca927b6-6e4d-4d6b-81e3-ec5e8f7772a0',
          name: 'Legal documents',
          external_id: 'folder-documents'
        }
      ]
    }
  )
  .toPromise();