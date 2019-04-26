// DocSection: structure_in_rte_retrieve_article
SimpleArticleItem item = client.getItem("the_origin_of_coffee", SimpleArticleItem.class);

String description = item.body;
// EndDocSection