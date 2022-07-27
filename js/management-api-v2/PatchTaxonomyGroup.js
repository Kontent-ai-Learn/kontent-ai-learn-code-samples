// DocSection: cm_api_v2_patch_taxonomy_group
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.modifyTaxonomy()
  .byTaxonomyId('0be13600-e57c-577d-8108-c8d860330985')
  // .byTaxonomyCodename('personas')
  // .byTaxonomyExternalId('Tax-Group-123')
  .withData(
    [
      {
        op: "replace",
        property_name: "name",
        value: "Categories"
      },
      {
        op: "replace",
        property_name: "codename",
        value: "category"
      },
      {
        op: "replace",
        reference: {
          codename: "first_term"
        },
        property_name: "terms",
        value: [
          {
            name: "Second-level taxonomy term",
            codename: "second_term",
            terms: [
              {
                name: "Third-level taxonomy term",
                terms: []
              }
            ]
          }
        ]
      },
      {
        op: "remove",
        reference: {
          external_id: "unused-taxonomy-term"
        }
      },
      {
        op: "addInto",
        reference: {
          codename: "second_term"
        },
        value:
        {
          name: "New taxonomy term",
          external_id: "my-new-term",
          terms: []
        }
      }
    ]
  )
  .toPromise();
// EndDocSection
