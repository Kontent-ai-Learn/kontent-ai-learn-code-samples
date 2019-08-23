// DocSection: cm_api_v2_delete_taxonomy_group
// Using ES6 syntax
import { ContentManagementClient } from 'kentico-cloud-content-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.deleteTaxonomy()
  .byTaxonomyId("dbff8416-c4c7-45d2-b497-a4a71a5cbe30")
  // .byTaxonomyCodename("personas_222")
  //.byTaxonomyExternalId("Tax-Group-124")
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection