// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax

import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client
  .modifySpace()
  .bySpaceCodename('my_new_space')
  .withData(
    [
      {
        "op": "replace",
        "property_name": "codename",
        "value": "new_space_codename"

      },
      {
        "op": "replace",
        "property_name": "name",
        "value": "new_space_name"
      },
    ]

  )
  .toPromise();
