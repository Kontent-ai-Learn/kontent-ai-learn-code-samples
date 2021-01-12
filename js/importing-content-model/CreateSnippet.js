// DocSection: importing_create_snippet
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
var client = new KontentManagement.ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addContentTypeSnippet()
  .withData(builder => {
    return {
      name: "Metadata",
      codename: "metadata",
      elements: [
        builder.textElement({
          name: "Title",
          codename: "title",
          type: 'text'
        }),
        builder.textElement({
          name: "Keywords",
          codename: "keywords",
          type: 'text'
        }),
			  builder.textElement({
          name: "Description",
          codename: "description",
          type: 'text'
        })
      ]
  };
})
// EndDocSection
