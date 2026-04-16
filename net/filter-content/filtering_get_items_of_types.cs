// Gets items based on the types Product, Article, and News
var result = await client.GetItems()
    .Where(item => item.System("type").IsIn("product", "article", "news"))
    .ExecuteAsync();