# DocSection: using_webhooks_get_latest_content
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '<YOUR_PROJECT_ID>'
delivery_client.item('my_article')
               .request_latest_content
               .execute do |response|
                 item = response.item
               end
# EndDocSection