// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client
    .bulkGetItemsWithVariants()
    .withData({
        variants: [
            {
                item: {
                    id: '4b628214-e4fe-4fe0-b1ff-955df33e1515'
                },
                language: {
                    id: '00000000-0000-0000-0000-000000000000'
                }
            },
            {
                item: {
                    id: '6a8b4d04-7d3e-4d3c-8b9a-4c7e8f9a1b2c'
                },
                language: {
                    codename: 'en-US'
                }
            }
        ]
    })
    .toPromise(); // or `toAllPromise()`
