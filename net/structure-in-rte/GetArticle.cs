// DocSection: structure_in_rte_retrieve_article
DeliveryItemResponse response = await client.GetItemAsync<SimpleArticle>("coffee_beverages_explained");
SimpleArticle simpleArticle = response.Item;

string simpleArticleBody = simpleArticle.Body;
// EndDocSection
