// DocSection: structure_in_rte_retrieve_article
DeliveryItemResponse response = await client.GetItemAsync<SimpleArticle>("my_article");
SimpleArticle simpleArticle = response.Item;

string simpleArticleBody = simpleArticle.Body;
// EndDocSection
