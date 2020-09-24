// DocSection: getting_localized_content_language
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid
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
String projectId = "8d20758c-d74c-4f59-ae04-ee928c0816b7";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId)
    .withTypeResolvers(typeResolvers);

// Initializes a DeliveryService for Java projects
IDeliveryService deliveryService = new DeliveryService(config);

// Gets the Spanish variant of an article using a simple request
Article article = deliveryService.<Article>item("about_us")
    .languageParameter("es-ES")
    .get()
    .getItem();

// Gets the Spanish variant of an article using RxJava2
deliveryService.<Article>item("about_us")
    .languageParameter("es-ES")
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