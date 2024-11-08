// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.deleteContentTypeSnippet()
  .byTypeId('baf884be-531f-441f-ae88-64205efdd0f6')
  // .byTypeCodename('metadata')
  // .byTypeExternalId('snippet-type-123')
  .toPromise();
