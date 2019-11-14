# DocSection: linked_content_get_article_with_author
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: 'e6d2946e-0e24-003f-a397-9d2d458c6d6e'
delivery_client.item('the_origin_of_coffee')
               .depth(1)
               .execute do |response|
                 item = response.item
                 puts response.json
               end
# EndDocSection