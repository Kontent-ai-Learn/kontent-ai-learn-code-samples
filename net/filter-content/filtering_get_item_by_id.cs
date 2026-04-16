var result = await client.GetItems()
    .Where(item => item.System("id").IsEqualTo("2f7288a1-cfc8-47be-9bf1-b1d312f7da18"))
    .ExecuteAsync();