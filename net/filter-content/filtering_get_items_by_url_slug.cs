// Gets items in default language with the URL slug element equal to 'sample-url-slug'
var result = await client.GetItems()
    .Where(item => item.Element("url_slug").IsEqualTo("sample-url-slug"))
    .ExecuteAsync();