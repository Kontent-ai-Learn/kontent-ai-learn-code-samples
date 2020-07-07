# DocSection: filtering_get_item_by_id
delivery_client.items([
  # Get items where multiple choice has a specific value
  'elements.multiple_choice'.contains('value')
])

delivery_client.items([
  # Get items where multiple choice has any of the below values
  'elements.multiple_choice'.contains('value1', 'value2')
])
# EndDocSection
