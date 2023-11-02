# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: '<YOUR_ENVIRONMENT_ID>'
delivery_client.type('article').execute do |response|
  type = response.type
end
