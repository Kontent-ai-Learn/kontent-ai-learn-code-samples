# DocSection: delivery_api_get_item_preview
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '<YOUR_PROJECT_ID>',
                    preview_key: '<YOUR_PREVIEW_API_KEY>'
delivery_client.item('my_article').execute do |response|
  puts response.to_s
end
# EndDocSection