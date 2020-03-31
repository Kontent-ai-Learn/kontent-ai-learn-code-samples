// DocSection: schedule_expiration_filter_by_date
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent_delivery_core.*;
import com.github.kentico.kontent_delivery_rx.*;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;
import io.reactivex.functions.Function;

String now = new Date().toInstant().toString();

// Prepares an array to hold strongly-typed models
List<TypeResolver<?>> typeResolvers = new ArrayList<>();

// Registers the type resolvers
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

// Gets the articles that should be public using a simple request
List<Article> articles = deliveryService.<Article>items()
    .equalsFilter("system.type", "article")
    .greaterThanFilter("elements.expire_at", now)
    .get()
    .getItems();

// Gets the articles that should be public using RxJava2
deliveryService.<Article>items()
    .equalsFilter("system.type", "article")
    .greaterThanFilter("elements.expire_at", now)
    .getObservable()
    .subscribe(new Observer<DeliveryItemListingResponse<Article>>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(DeliveryItemListingResponse<Article> response) {
            // Gets the mapped articles
            List<Article> articles = response.getItems();
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection