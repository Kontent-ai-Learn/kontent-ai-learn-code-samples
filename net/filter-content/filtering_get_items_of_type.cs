// Gets items based on the "product" type
var result = await client.GetItems()
    .Where(item => item.System("type").IsEqualTo("product"))
    .ExecuteAsync();

// Note: When using generated models with [ContentTypeCodename("product")] attribute,
// the type filter is added automatically and this manual filter is not needed.
var result = await client.GetItems<Product>()
    .ExecuteAsync();