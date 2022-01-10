// DocSection: cm_api_v2_put_var_cancel_sched_unpublish
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.cancelSheduledUnpublishingOfLanguageVariant()
  // .byItemId('f4b3fc05-e988-4dae-9ac1-a94aba566474')
  .byItemCodename('my_article')
  // .byItemExternalId('59713')
  // .byLanguageId('d1f95fde-af02-b3b5-bd9e-f232311ccab8')
  .byLanguageCodename('es-mx')
  .toPromise();
// EndDocSection