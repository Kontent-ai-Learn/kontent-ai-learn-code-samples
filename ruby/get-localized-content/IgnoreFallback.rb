# DocSection: language_fallbacks_ignore
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '975bf280-fd91-488c-994c-2f04416e5ee3'
delivery_client.items(['system.language'.eq('es-ES')])
               .language('es-ES')
               .execute do |response|
                 items = response.items
               end
# EndDocSection
