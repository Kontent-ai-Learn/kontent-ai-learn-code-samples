// DocSection: filtering_get_item_by_id
delivery_client.items([
  // Gets item by its ID
  'elements.multiple_choice'.contains('value')
])

delivery_client.items([
  // Gets item by its ID
  'elements.multiple_choice'.contains('value1', 'value2')
])
// EndDocSection
