# DocSection: filtering_get_items_by_range
delivery_client.items([
  # Gets items whose publish date is at least 2020-05-10, 00:00:00 but no greater than 2020-05-20, 00:00:00
  'elements.publish_date'.range('2020-05-10', '2020-05-20')
])
# EndDocSection
