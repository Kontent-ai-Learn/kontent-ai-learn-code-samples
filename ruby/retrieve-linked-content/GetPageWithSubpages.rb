# DocSection: linked_content_get_page_with_subpages
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
delivery_client.item('insurance_listing')
               .depth(1)
               .execute do |response|
                 item = response.item
                 puts response.json
               end
# EndDocSection