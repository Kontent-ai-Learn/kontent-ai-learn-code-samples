# DocSection: delivery_api_get_taxonomy_group
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '<YOUR_PROJECT_ID>'
delivery_client.taxonomy('personas').execute do |response|
  group = response.taxonomy
end
# EndDocSection