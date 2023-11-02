# Note: Filters work with codenames of the tags.
# Gets itmes tagged with one specific tag
delivery_client.items('elements.tags'.contains('kontent_ai'))

# Gets items tagged with a list of specific tags
delivery_client.items('elements.tags'.any('kontent_ai', 'cms'))

# Gets items tagged with at least one of multiple tags
delivery_client.items('elements.tags'.contains('headless', 'cms'))
