// DocSection: importing_create_type
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
var client = new KontentManagement.ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addContentType()
  .withData(builder => {
    return {
      name: 'Blogpost',
      codename: 'blogpost',
      content_groups: [{
          name: 'Blog content',
          external_id: 'blog_content'
        },
        {
          name: 'Author',
          external_id: 'author'
        }
      ],
      elements: [
        builder.textElement({
          name: 'Title',
          type: 'text',
          content_group: {
            external_id: 'blog_content'
          },
        }),
        builder.assetElement({
          name: 'Image',
          type: 'asset',
          content_group: {
            external_id: 'blog_content'
          },
        }),
        builder.richTextElement({
          name: 'Blog content',
          type: 'rich_text',
          content_group: {
            external_id: 'blog_content'
          },
        }),
        builder.snippetElement({
          snippet: {
            'codename': 'author'
          },
          type: 'snippet',
          id: 'b3574198-5946-515f-b406-411307c59916',
          codename: 'author_profile',
          content_group: {
            external_id: 'author'
          },
        })
      ]
    };
  })
// EndDocSection
