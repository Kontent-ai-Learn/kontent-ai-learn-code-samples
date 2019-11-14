// DocSection: cm_api_v2_post_type
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
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
      codename: "my_article",
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
          codename: "title",
          type: ElementModels.ElementType.text,
          content_group: {
            external_id: "article-copy"
          },
        },
        {
          name: "Article body",
          codename: "body",
          type: ElementModels.ElementType.richText,
          content_group: {
            external_id: "article-copy"
          },
        },
        {
          name: "Author bio",
          codename: "bio",
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
