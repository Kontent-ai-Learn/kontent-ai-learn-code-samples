// Gets items whose rating is at least 6.5 and at most 9
var result = await client.GetItems()
    .Where(item => item.Element("product_rating").IsWithinRange(6.5, 9))
    .ExecuteAsync();