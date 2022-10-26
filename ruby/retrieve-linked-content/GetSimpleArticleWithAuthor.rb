# DocSection: linked_content_get_article_with_author
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
delivery_client.item('the_origin_of_coffee')
               .depth(1)
               .execute do |response|
                 item = response.item
                 puts response.json
               end
# EndDocSection