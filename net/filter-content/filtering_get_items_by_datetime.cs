// Note: Date & time element values are provided by users and stored with minute precision.
// The system.last_modified value reflects last content change to an item and is stored with second precision.

// Gets items modified after May 9 2020, 9 am UTC (using DateTime overload)
var result = await client.GetItems()
    .Where(item => item.System("last_modified")
        .IsGreaterThan(new DateTime(2020, 5, 9, 9, 0, 0, DateTimeKind.Utc)))
    .ExecuteAsync();

// Gets items released at or after May 9 2020, 7 am UTC (using string overload)
var result = await client.GetItems()
    .Where(item => item.Element("release_date")
        .IsGreaterThanOrEqualTo("2020-05-09T07:00:00Z"))
    .ExecuteAsync();

// Gets items modified before May 5 2020 UTC. Last match would be at 2020-05-04T23:59:59.
// Date-only string — no time component appended by the SDK.
var result = await client.GetItems()
    .Where(item => item.System("last_modified").IsLessThan("2020-05-05"))
    .ExecuteAsync();

// Gets items released at or before May 5 2020 10:30 am UTC (SDK implicitly serializes DateTime to UTC)
var result = await client.GetItems()
    .Where(item => item.Element("release_date")
        .IsLessThanOrEqualTo(new DateTime(2020, 5, 5, 10, 30, 0)))
    .ExecuteAsync();