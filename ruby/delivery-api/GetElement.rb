# DocSection: delivery_api_get_element
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '<YOUR_PROJECT_ID>'
delivery_client.element('coffee', 'processing').execute do |response|
  ele = response.element
end
# EndDocSection