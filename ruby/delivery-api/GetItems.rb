# DocSection: delivery_api_get_items
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '975bf280-fd91-488c-994c-2f04416e5ee3'
delivery_client.items('system.type'.eq('article'))
               .order_by('elements.post_date', '[desc]')
               .elements(%w[title summary post_date])
               .execute do |response|
                 items = response.items
               end
# EndDocSection