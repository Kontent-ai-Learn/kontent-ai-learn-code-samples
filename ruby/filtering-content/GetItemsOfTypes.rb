# DocSection: filtering_get_items_of_types
# Gets items based on the types Product, Article, and News
delivery_client.items('system.type'.in('product', 'article', 'news'))
# EndDocSection
