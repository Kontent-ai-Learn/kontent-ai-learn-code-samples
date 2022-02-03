# DocSection: delivery_api_get_items
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '<YOUR_PROJECT_ID>'
delivery_client.items('system.type'.eq('article'))
               .limit(3)
               .execute do |response|
                 items = response.items
               end
# EndDocSection