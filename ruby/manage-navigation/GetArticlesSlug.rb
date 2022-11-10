# DocSection: managing_navigation_articles_slugs
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
# Gets navigation items and their linked items
delivery_client.item('root_navigation_item')
               .depth(5)
               .execute do |response|
                 item = response.item
               end

# Gets specific elements of all articles
delivery_client.items('system.type'.eq('article'))
               .elements(%w[title url])
               .execute do |response|
                 items = response.items
               end
# EndDocSection