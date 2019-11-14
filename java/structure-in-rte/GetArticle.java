// DocSection: structure_in_rte_retrieve_article
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
SimpleArticleItem item = client.getItem("coffee_beverages_explained", SimpleArticleItem.class);

String description = item.body;
// EndDocSection
