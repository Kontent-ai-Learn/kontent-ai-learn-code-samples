# DocSection: filtering_get_product_within_rating
delivery_client.items([
  # Gets products whose rating is at least 7 but no greater than 9
  'elements.product_rating'.range('7', '9')
])
 # EndDocSection
