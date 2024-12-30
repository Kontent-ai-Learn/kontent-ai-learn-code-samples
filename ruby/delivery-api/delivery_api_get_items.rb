# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: 'KONTENT_AI_ENVIRONMENT_ID'
delivery_client.items('system.type'.eq('article'))
               .limit(3)
               .execute do |response|
                 items = response.items
               end
