# DocSection: schedule_unpublishing_filter_by_date
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '14372844-0a5d-434a-8423-605b8a631623'
now = DateTime.now.strftime '%Y-%M-%dT%H:%M:%SZ'
delivery_client.items([
                        'system.type'.eq('article'),
                        'elements.publish_until'.gt(now)
                      ])
               .execute do |response|
                 items = response.items
               end
# EndDocSection