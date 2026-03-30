// Note: Date & time element values are provided by users and stored with minute precision. The system.last_modified value reflects last content change to an item and is stored with ms precision.

// Gets items modified between May 5, 2020 10:30 UTC and May 7, 2020 7:00 UTC (inclusive)
// Using string overload — values passed through as-is to the API
var result = await client.GetItems()
    .Where(item => item.System("last_modified")
        .IsWithinRange("2020-05-05T10:30:00Z", "2020-05-07T07:00:00Z"))
    .ExecuteAsync();

// Equivalent using DateTime overload (SDK implicitly serializes DateTime as UTC if not specified)
var result2 = await client.GetItems()
    .Where(item => item.System("last_modified")
        .IsWithinRange(
            new DateTime(2020, 5, 5, 10, 30, 0),
            new DateTime(2020, 5, 7, 7, 0, 0)))
    .ExecuteAsync();