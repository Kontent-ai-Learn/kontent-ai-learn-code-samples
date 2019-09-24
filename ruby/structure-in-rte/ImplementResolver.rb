# DocSection: structure_in_rte_implement_resolver
require 'delivery-sdk-ruby'

item_resolver = Kentico::Kontent::Delivery::Resolvers::InlineContentItemResolver.new(lambda do |item|
  if item.system.type.eql? 'tweet'
    return "<blockquote class=\"twitter-tweet\" data-lang=\"en\" data-theme=\"#{item.elements.theme.value[0].codename}\">"\
    "<a href=\"#{item.elements.tweet_link.value}\"></a>"\
    '</blockquote>'
  end
end)
# EndDocSection