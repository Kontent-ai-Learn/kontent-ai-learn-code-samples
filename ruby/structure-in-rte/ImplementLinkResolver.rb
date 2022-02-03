# DocSection: structure_in_rte_implement_link_resolver
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

link_resolver = Kentico::Kontent::Delivery::Resolvers::ContentLinkResolver.new(lambda do |link|
        # Link is available
        return "/articles/#{link.url_slug}" if link.type.eql? 'article'
      end, lambda do |id|
        # Link is broken
        return "/notfound?id=#{id}"
      end)
# EndDocSection