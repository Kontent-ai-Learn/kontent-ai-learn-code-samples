# DocSection: delivery_api_get_item_preview
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '975bf280-fd91-488c-994c-2f04416e5ee3',
                    preview_key: '<YOUR_PREVIEW_API_KEY>'
delivery_client.item('on_roasts').execute do |response|
  puts response.to_s
end
# EndDocSection