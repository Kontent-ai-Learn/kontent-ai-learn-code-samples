# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
delivery_client.items('system.type'.eq 'article')
               .limit(3)
               .order_by('system.last_modified', '[desc]')
               .execute do |response|
                 items = response.items
                 items.each { |item| puts item.system.codename }
               end
