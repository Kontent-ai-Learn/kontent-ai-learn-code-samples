// DocSection: structure_in_rte_retrieve_article
SimpleArticleItem item = client.getItem("coffee_beverages_explained", SimpleArticleItem.class);

String description = item.body;
// EndDocSection
