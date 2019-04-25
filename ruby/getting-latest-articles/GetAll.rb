# DocSection: getting_latest_articles_get_all
require 'delivery-sdk-ruby'

delivery_client = KenticoCloud::Delivery::DeliveryClient.new project_id: '975bf280-fd91-488c-994c-2f04416e5ee3'
delivery_client.items.execute do |response|
  items = response.items
  items.each { |item| puts item.system.codename }
end
# EndDocSection