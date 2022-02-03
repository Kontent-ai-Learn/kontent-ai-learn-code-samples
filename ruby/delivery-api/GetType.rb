# DocSection: delivery_api_get_type
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '<YOUR_PROJECT_ID>'
delivery_client.type('article').execute do |response|
  type = response.type
end
# EndDocSection