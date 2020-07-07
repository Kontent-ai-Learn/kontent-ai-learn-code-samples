# DocSection: filtering_get_published_from_to
delivery_client.items([
  # Gets items whose publish date is at least 2020-05-10, 00:00:00
  'elements.publish_date'.greaterThan('2020-05-10')
])

delivery_client.items([
  # Gets items whose publish date is at least 2020-05-10, 00:00:00
  'elements.publish_date'.greaterThanOrEqual('2020-05-10')
])

delivery_client.items([
  # Gets items whose publish date is at most 2020-05-19, 23:59:00
  'elements.publish_date'.lessThan('2020-05-20')
])

delivery_client.items([
  # Gets items whose publish date is at most 2020-05-19, 23:59:00
  'elements.publish_date'.lessThanOrEqual('2020-05-20')
])
# EndDocSection
