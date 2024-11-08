// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.addContentItem()
  .withData(
    {
      name: 'On Roasts',
      codename: 'my_article_my_article',
      type: {
        codename: 'article'
      },
      collection: {
        codename: 'default'
      },
      external_id: '59713'
    }
  )
  .toPromise();