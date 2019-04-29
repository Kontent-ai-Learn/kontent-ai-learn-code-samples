# DocSection: language_fallbacks_ignore
require 'delivery-sdk-ruby'

delivery_client = KenticoCloud::Delivery::DeliveryClient.new project_id: '975bf280-fd91-488c-994c-2f04416e5ee3'
delivery_client.items([
                        'system.type'.eq('article'),
                        'system.language'.eq('en-US')
                      ])
               .language('en-US')
               .execute do |response|
                 items = response.items
               end
# EndDocSection