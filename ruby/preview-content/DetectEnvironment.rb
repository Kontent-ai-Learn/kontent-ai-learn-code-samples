# DocSection: preview_content_detect_environment
require 'delivery-sdk-ruby'

is_preview = false # Determine whether the app is running in a preview environment
delivery_client = KenticoCloud::Delivery::DeliveryClient.new project_id: '975bf280-fd91-488c-994c-2f04416e5ee3',
                    preview_key: '<YOUR_PREVIEW_API_KEY>'
delivery_client.use_preview = is_preview
delivery_client.items.execute do |response|
  items = response.items
end
# EndDocSection