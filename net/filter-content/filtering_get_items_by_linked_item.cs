// Gets items where the 'navigation' linked items element contains 'my_page'.
var result = await client.GetItems()
    .Where(item => item.Element("navigation").Contains("my_page"))
    .ExecuteAsync();

// Gets items linked to at least Jane, John, or both.
var result2 = await client.GetItems()
    .Where(item => item.Element("author").ContainsAny("jane_doe", "john_wick"))
    .ExecuteAsync();

// Gets pages linking travel insurance as their subpage.
var result3 = await client.GetItems()
    .Where(item => item.Element("subpages").Contains("travel_insurance"))
    .ExecuteAsync();

// Gets pages linking at least travel insurance, car insurance, or both as their subpage.
var result4 = await client.GetItems()
    .Where(item => item.Element("subpages").ContainsAny("travel_insurance", "car_insurance"))
    .ExecuteAsync();