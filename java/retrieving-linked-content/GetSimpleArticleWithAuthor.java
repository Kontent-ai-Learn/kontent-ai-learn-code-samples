// DocSection: linked_content_get_article_with_author
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("e6d2946e-0e24-003f-a397-9d2d458c6d6e");

List<NameValuePair> params = DeliveryParameterBuilder.params().modularContentDepth(1).build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
SimpleArticleItem item = client.getItem("the_origin_of_coffee", SimpleArticleItem.class, params);
// EndDocSection