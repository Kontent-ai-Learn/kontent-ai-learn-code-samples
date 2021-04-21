# DocSection: managing_navigation_articles_slugs
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
delivery_client.items('system.type'.eq('article'))
               .elements(%w[title url])
               .execute do |response|
                 items = response.items
               end
# EndDocSection