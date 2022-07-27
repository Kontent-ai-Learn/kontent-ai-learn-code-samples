// DocSection: cm_api_v2_put_variant_unpublish_archive
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.unpublishLanguageVariant()
  // .byItemId('f4b3fc05-e988-4dae-9ac1-a94aba566474')
  .byItemCodename('my_article')
  // .byItemExternalId('59713')
  // .byLanguageId('d1f95fde-af02-b3b5-bd9e-f232311ccab8')
  .byLanguageCodename('es-mx')
  // To schedule unpublish date, use .withData({scheduled_to: 'datetime-to-unpublish-at'})
  .withData({
    scheduled_to: '2038-01-19T04:14:08+01:00'
  })
  // To unpublish now, use .withoutData()
  .toPromise();
// EndDocSection