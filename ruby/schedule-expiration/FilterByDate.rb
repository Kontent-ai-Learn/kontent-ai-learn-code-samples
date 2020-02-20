# DocSection: schedule_unpublishing_filter_by_date
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
now = DateTime.now.strftime '%Y-%M-%dT%H:%M:%SZ'
delivery_client.items([
                        'system.type'.eq('article'),
                        'elements.expire_at'.gt(now)
                      ])
               .execute do |response|
                 items = response.items
               end
# EndDocSection