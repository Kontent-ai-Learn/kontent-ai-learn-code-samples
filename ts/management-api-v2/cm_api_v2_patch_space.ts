// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

client
  .modifySpace()
  .bySpaceCodename('my_new_space')
  .withData(
    [
      {
        op: 'replace',
        property_name: 'codename',
        value: 'new_space_codename'

      },
      {
        op: 'replace',
        property_name: 'name',
        value: 'new_space_name'
      },
    ]
  )
  .toPromise();