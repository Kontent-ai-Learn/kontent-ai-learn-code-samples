// DocSection: structure_in_rte_retrieve_article
DeliveryItemResponse response = await client.GetItemAsync<SimpleArticle>("the_origin_of_coffee");
SimpleArticle simpleArticle = response.Item;

string simpleArticleBody = simpleArticle.Body;
// EndDocSection