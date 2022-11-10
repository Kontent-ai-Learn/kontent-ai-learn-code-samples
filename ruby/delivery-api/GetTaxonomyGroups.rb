# DocSection: delivery_api_get_taxonomy_groups
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: '<YOUR_PROJECT_ID>'
delivery_client.taxonomies
               .limit(3)
               .execute do |response|
                 groups = response.taxonomies
               end
# EndDocSection