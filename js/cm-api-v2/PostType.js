// DocSection: cm_api_v2_post_type
// Using ES6 syntax
import { ContentManagementClient, ElementModels } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addContentType()
  .withData(
    {
      name: "Article",
      external_id: "article",
      content_groups: [
        {
          name: "Article copy",
          external_id: "article-copy",
        },
        {
          name: "Author",
          external_id: "author",
        }
      ],
      elements: [
        {
          name: "Article title",
          type: ElementModels.ElementType.text,
          content_group: {
            external_id: "article-copy"
          },
        },
        {
          name: "Article body",
          type: ElementModels.ElementType.richText,
          content_group: {
            external_id: "article-copy"
          },
        },
        {
          name: "Author bio",
          type: ElementModels.ElementType.richText,
          content_group: {
            external_id: "author",
          },
        },
      ]
    }
  )
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection