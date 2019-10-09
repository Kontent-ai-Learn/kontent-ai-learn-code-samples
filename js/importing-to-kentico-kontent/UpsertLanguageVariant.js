// DocSection: importing_upsert_variant
// Using ES6 syntax
import { ContentManagementClient } from 'kentico-cloud-content-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.upsertLanguageVariant()
  .byItemExternalId('ext-cafe-brno')
  .byLanguageCodename('en-US')
  .withElements([
    {
      element: {
        codename: 'street'
      },
      value: 'Nove Sady 25'
    },
    {
      element: {
        codename: 'city'
      },
      value: 'Brno'
    },
    {
      element: {
        codename: 'country'
      },
      value: 'Czech Republic'
    },
    {
      element: {
        codename: 'state'
      },
      value: 'Jihomoravsky kraj'
    },
    {
      element: {
        codename: 'zip_code'
      },
      value: '60200'
    },
    {
      element: {
        codename: 'phone'
      },
      value: '+420 555 555 555'
    },
    {
      element: {
        codename: 'email'
      },
      value: 'brnocafe@kontent.ai'
    }
  ])
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection