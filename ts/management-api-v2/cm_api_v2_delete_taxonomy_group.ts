// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.deleteTaxonomy()
  .byTaxonomyId('dbff8416-c4c7-45d2-b497-a4a71a5cbe30')
  // .byTaxonomyCodename('personas_222')
  // .byTaxonomyExternalId('Tax-Group-124')
  .toPromise();