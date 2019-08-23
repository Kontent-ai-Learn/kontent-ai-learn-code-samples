# DocSection: delivery_api_get_taxonomy_groups
require 'delivery-sdk-ruby'

delivery_client = KenticoCloud::Delivery::DeliveryClient.new project_id: '975bf280-fd91-488c-994c-2f04416e5ee3'
delivery_client.taxonomies
               .limit(3)
               .execute do |response|
                 groups = response.taxonomies
               end
# EndDocSection