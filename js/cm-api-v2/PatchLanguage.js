// DocSection: cm_api_v2_patch_language
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.modifyLanguage()
  .byLanguageId('2ea66788-d3b8-5ff5-b37e-258502e4fd5d')
  // .byLanguageCodename('de-DE')
  // .byExternalId('standard-german')
  .withData (
    [
      {
        op: "replace",
        property_name: "fallback_language",
        value: {
          codename: "en-US"
        }
      },
      {
        op: 'replace',
        property_name: "name",
        value: "German"
      }
    ]
  )
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection