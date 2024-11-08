// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.getTaxonomy()
  .byTaxonomyCodename('categories')
  // .byTaxonomyID('bef9dd62-a3b8-4146-83e4-33be707899b4')
  // .byTaxonomyExternalID('my-little-taxopony')
  .toPromise();