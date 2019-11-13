# DocSection: structure_in_rte_register_resolver
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: 'e6d2946e-0e24-003f-a397-9d2d458c6d6e',
               inline_content_item_resolver: item_resolver
# EndDocSection