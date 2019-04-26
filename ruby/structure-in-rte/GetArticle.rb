# DocSection: structure_in_rte_retrieve_article
require 'delivery-sdk-ruby'

delivery_client.item('the_origin_of_coffee').execute do |response|
  item = response.item
  text = item.get_string('body')
  puts text
end
# EndDocSection