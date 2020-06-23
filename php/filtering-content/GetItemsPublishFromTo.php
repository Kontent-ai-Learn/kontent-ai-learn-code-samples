// DocSection: filtering_get_published_from_to
$items = $client->getItems((new QueryParams())
  // Gets items whose publish date is at least 2020-05-10, 00:00:00
  ->greaterThan("elements.publish_date", "2020-05-10")

$items = $client->getItems((new QueryParams())
  // Gets items whose publish date is at least 2020-05-10, 00:00:00
  ->greaterThanOrEqual("elements.publish_date", "2020-05-10")

$items = $client->getItems((new QueryParams())
  // Gets items whose publish date is at most 2020-05-19, 23:59:00
  ->lessThan("elements.publish_date", "2020-05-20")

$items = $client->getItems((new QueryParams())
  // Gets items whose publish date is at most 2020-05-19, 23:59:00
  ->lessThanOrEqual("elements.publish_date", "2020-05-20")
// EndDocSection
