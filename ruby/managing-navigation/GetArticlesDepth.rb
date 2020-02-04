# DocSection: managing_navigation_articles_depth
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
delivery_client.item('root_navigation_item')
               .depth(5)
               .execute do |response|
                 item = response.item
               end
# EndDocSection