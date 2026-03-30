// Note: Filters work with codenames of the tags.

// Gets items tagged with one specific tag
var result1 = await client.GetItems()
    .Where(item => item.Element("tags").Contains("kontent_ai"))
    .ExecuteAsync();

// Gets items tagged with all specified tags
var result2 = await client.GetItems()
    .Where(item => item.Element("tags").ContainsAll("kontent_ai", "cms"))
    .ExecuteAsync();

// Gets items tagged with at least one tag from the list
var result3 = await client.GetItems()
    .Where(item => item.Element("tags").ContainsAny("headless", "cms"))
    .ExecuteAsync();