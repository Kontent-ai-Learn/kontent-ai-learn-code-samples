// DocSection: importing_upsert_variant
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_MANAGEMENT_API_KEY>'
});

const response = await client.upsertLanguageVariant()
  .byItemExternalId('ext-cafe-brno')
  .byLanguageCodename('en-US')
  .withData((builder) => [
    builder.textElement({
      element: {
        codename: 'street'
      },
      value: 'Nove Sady 25'
    }),
    builder.textElement({
      element: {
        codename: 'city'
      },
      value: 'Brno'
    }),
    builder.textElement({
      element: {
        codename: 'country'
      },
      value: 'Czech Republic'
    }),
    builder.textElement({
      element: {
        codename: 'state'
      },
      value: 'Jihomoravsky kraj'
    }),
    builder.textElement({
      element: {
        codename: 'zip_code'
      },
      value: '60200'
    }),
    builder.textElement({
      element: {
        codename: 'phone'
      },
      value: '+420555555555'
    }),
    builder.textElement({
      element: {
        codename: 'email'
      },
      value: 'brnocafe@kontent.ai'
    })
  ])
  .toPromise();
// EndDocSection