# DocSection: filtering_get_items_by_linked_item
# Gets items attributed to Jane. Matched items may also reference other authors.
delivery_client.items('elements.author'.contains('jane_doe'))

# Gets items attributed to at least Jane, John, or both. Matched items may also reference other authors.
delivery_client.items('elements.author'.any('jane_doe', 'john_wick'))
# EndDocSection