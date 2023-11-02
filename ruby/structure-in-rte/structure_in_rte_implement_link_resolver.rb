# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

link_resolver = Kontent::Ai::Delivery::Resolvers::ContentLinkResolver.new(lambda do |link|
        # Link is available
        return "/articles/#{link.url_slug}" if link.type.eql? 'article'
      end, lambda do |id|
        # Link is broken
        return "/notfound?id=#{id}"
      end)
