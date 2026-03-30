// Gets three items by their codenames. The codenames are unique per environment.
var result = await client.GetItems()
    .Where(item => item.System("codename").IsIn("delivery_api", "get_content", "hello_world"))
    .ExecuteAsync();