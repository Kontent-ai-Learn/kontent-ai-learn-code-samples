// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
    environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
    apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

// Gets the first page of results
const response = await client.listLanguageVariantsByCollection()
    .byCollectionCodename('important_collection')
    .toPromise();

// Gets all pages of results
// const response = await client.listLanguageVariantsByCollection()
//     .byCollectionCodename('important_collection')
//     .toAllPromise();