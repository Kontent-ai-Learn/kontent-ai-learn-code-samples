# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: 'KONTENT_AI_ENVIRONMENT_ID',
               content_link_url_resolver: link_resolver
