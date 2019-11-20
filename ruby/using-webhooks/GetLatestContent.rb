# DocSection: using_webhooks_get_latest_content
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '975bf280-fd91-488c-994c-2f04416e5ee3'
delivery_client.item('on_roasts')
               .request_latest_content
               .execute do |response|
                 item = response.item
               end
# EndDocSection