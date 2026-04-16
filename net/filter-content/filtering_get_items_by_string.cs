// Gets items whose Title element value equals "Hello World"
var result = await client.GetItems()
    .Where(item => item.Element("title").IsEqualTo("Hello World"))
    .ExecuteAsync();