# DocSection: preview_content_get_article
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: '975bf280-fd91-488c-994c-2f04416e5ee3',
                    preview_key: '<YOUR_PREVIEW_API_KEY>'
delivery_client.item('my_article').execute do |response|
  item = response.item
end
# EndDocSection