# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client.item('my_article').execute do |response|
  item = response.item
  text = item.get_string('body')
  puts text
end
