// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.upsertLanguageVariant()
  .byItemExternalId('ext-cafe-brno')
  .byLanguageCodename('en-US')
  .withData((builder) => {
    return {
      elements: [
        builder.assetElement({
          element: {
            codename: 'photo'
          },
          value: [
            {
              external_id: "brno-cafe-image"
            }
          ]
        }),
      ]
    }
  })
  .toPromise();
