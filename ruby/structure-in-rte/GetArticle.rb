# DocSection: structure_in_rte_retrieve_article
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client.item('coffee_beverages_explained').execute do |response|
  item = response.item
  text = item.get_string('body')
  puts text
end
# EndDocSection
