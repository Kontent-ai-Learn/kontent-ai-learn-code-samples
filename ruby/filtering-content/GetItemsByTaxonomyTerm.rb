# DocSection: filtering_get_items_by_taxonomy_term
# Note: Filters work with codenames of the tags.
# Gets itmes tagged with a single tag
delivery_client.items('elements.tags'.contains('kontent'))

# Gets items tagged with multiple tags
delivery_client.items('elements.tags'.any('football', 'soccer'))

# Gets items tagged with at least one of multiple tags
delivery_client.items('elements.tags'.contains('mvc', 'kontent', 'headless'))
# EndDocSection