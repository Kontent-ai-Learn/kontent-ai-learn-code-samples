// DocSection: structure_in_rte_retrieve_article
// Tip: Find more about Java SDKs at https://docs.kontent.ai/java
SimpleArticleItem item = client.getItem("my_article", SimpleArticleItem.class);

String description = item.toCompletableFuture().get().getBodyCopy();
// EndDocSection
