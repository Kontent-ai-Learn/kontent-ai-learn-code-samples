# DocSection: getting_localized_content_url_slug
require 'delivery-sdk-ruby'

delivery_client = KenticoCloud::Delivery::DeliveryClient.new project_id: '975bf280-fd91-488c-994c-2f04416e5ee3'
delivery_client.items([
                        'system.type'.eq('home'),
                        'elements.url_pattern'.eq('inicio')
                      ])
               .language('es-ES')
               .execute do |response|
                 items = response.items
               end
# EndDocSection