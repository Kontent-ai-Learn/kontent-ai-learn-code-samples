// DocSection: delivery_api_get_item
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent_delivery_core.*;
import com.github.kentico.kontent_delivery_rx.*;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;
import io.reactivex.functions.Function;

// Prepares an array to hold strongly-typed models
List<TypeResolver<?>> typeResolvers = new ArrayList<>();

// Registers the type resolver for articles
typeResolvers.add(new TypeResolver<>(Article.TYPE, new Function<Void, Article>() {
    @Override
    public Article apply(Void input) {
        return new Article();
    }
}));

// Prepares the DeliveryService configuration object
String projectId = "<YOUR_PROJECT_ID>";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId)
  .withTypeResolvers(typeResolvers);

// Initializes a DeliveryService for Java projects
IDeliveryService deliveryService = new DeliveryService(config);

// Gets specific elements of an article using a simple request
Article article = deliveryService.<Article>item("my_article")
    .elementsParameter(Arrays.asList("title", "summary", "post_date", "teaser_image", "related_articles"))
    .get()
    .getItem();

// Gets specific elements of an article using RxJava2
deliveryService.<Article>item("my_article")
    .elementsParameter(Arrays.asList("title", "summary", "post_date", "teaser_image", "related_articles"))
    .getObservable()
    .subscribe(new Observer<DeliveryItemResponse<Article>>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(DeliveryItemResponse<Article> response) {
            // Gets the article
            Article article = response.getItem();
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection