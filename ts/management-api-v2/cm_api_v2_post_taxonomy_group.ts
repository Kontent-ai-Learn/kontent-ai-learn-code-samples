// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.addTaxonomy()
  .withData(
    {
      name: 'Personas',
      externalId: 'Tax-Group-123',
      codename: 'people',
      terms: [
        {
          name: 'Coffee expert',
          externalId: 'Tax-term-456',
          codename: 'expert',
          terms: [
            {
              name: 'Barista',
              externalId: 'Tax-term-789',
              terms: []
            },
            {
              name: 'Cafe owner',
              externalId: 'Tax-term-101',
              terms: []
            }
          ]
        },
        {
          name: 'Coffee enthusiast',
          codename: 'enthusiast',
          externalId: 'Tax-term-112',
          terms: [
            {
              name: 'Coffee lover',
              codename: 'lover',
              externalId: 'Tax-term-131',
              terms: []
            },
            {
              name: 'Coffee blogger',
              codename: 'blogger',
              externalId: 'Tax-term-145',
              terms: []
            }
          ]
        }
      ]
    }
  )
  .toPromise();