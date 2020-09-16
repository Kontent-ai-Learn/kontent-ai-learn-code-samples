// DocSection: importing_create_snippet
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript

var client = new KontentManagement.ManagementClient({
			projectId: '<YOUR_PROJECT_ID>',
			apiKey: '<YOUR_API_KEY>'
		});
    
client.addContentTypeSnippet()
   .withData(builder => {
       return {
          name: 'Author',
          codename: 'author',
          elements: [
             builder.textElement({
               name: 'Name',
               codename: 'name',
               type: 'text'
             }),
             builder.assetElement({
               name: 'Profile picture',
               codename: 'profile_picture',
               type: 'asset'
             })
          ]
       };
   })
// EndDocSection
