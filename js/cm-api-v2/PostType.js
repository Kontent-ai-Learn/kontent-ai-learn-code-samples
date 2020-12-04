// DocSection: cm_api_v2_post_type
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient, ElementModels } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addContentType()
  .withData(builder => {
    return {
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
          codename: "author",
        }
      ],
      elements: [
        builder.textElement({
          name: "Article title",
          codename: "title",
          type: ElementModels.ElementType.text,
          content_group: {
            external_id: "article-copy"
          },
        }),
        builder.richtTextElement({
          name: "Article body",
          codename: "body",
          type: ElementModels.ElementType.richText,
          content_group: {
            external_id: "article-copy"
          },
        }),
        builder.richtTextElement({
          name: "Author bio",
          codename: "bio",
          type: ElementModels.ElementType.richText,
          allowed_blocks: [
            "images",
            "text"
          ],
          content_group: {
            codename: "author"
          }
        })
      ]
    };
  })
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection
