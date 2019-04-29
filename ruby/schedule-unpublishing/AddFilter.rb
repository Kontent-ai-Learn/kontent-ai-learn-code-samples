# DocSection: schedule_unpublishing_add_filter
require 'delivery-sdk-ruby'

delivery_client = KenticoCloud::Delivery::DeliveryClient.new project_id: '14372844-0a5d-434a-8423-605b8a631623'
delivery_client.items('system.type'.eq('article'))
               .execute do |response|
                 now = DateTime.now.strftime '%Y-%M-%dT%H:%M:%SZ'
                 items_to_display = response.items.select { |i| i.publish_until > now || i.publish_until.nil? }
               end
# EndDocSection