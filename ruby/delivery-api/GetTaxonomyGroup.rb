# DocSection: delivery_api_get_taxonomy_group
require 'delivery-sdk-ruby'

delivery_client = KenticoCloud::Delivery::DeliveryClient.new project_id: '975bf280-fd91-488c-994c-2f04416e5ee3'
delivery_client.taxonomy('personas').execute do |response|
  group = response.taxonomy
end
# EndDocSection