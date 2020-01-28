# DocSection: getting_localized_content_url_slug
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '8d20758c-d74c-4f59-ae04-ee928c0816b'
delivery_client.items([
                        'system.type'.eq('article'),
                        'elements.url_pattern'.eq('acerda-de-nosotros')
                      ])
               .language('es-ES')
               .execute do |response|
                 items = response.items
               end
# EndDocSection