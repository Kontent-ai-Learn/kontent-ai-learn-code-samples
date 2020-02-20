# DocSection: schedule_unpublishing_add_filter
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
delivery_client.items('system.type'.eq('article'))
               .execute do |response|
                 now = DateTime.now.strftime '%Y-%M-%dT%H:%M:%SZ'
                 items_to_display = response.items.select { |i| i.expire_at > now || i.expire_at.nil? }
               end
# EndDocSection