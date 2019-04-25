// DocSection: getting_content_order_items
import com.kenticocloud.delivery_core.*;
import com.kenticocloud.delivery_rx.*;

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
String projectId = "975bf280-fd91-488c-994c-2f04416e5ee3";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId)
    .withTypeResolvers(typeResolvers);

// Initializes a DeliveryService for Java projects
IDeliveryService deliveryService = new DeliveryService(config);

// Gets the 3 latest articles ordered by their last modified time using a simple request
List<Article> articles = deliveryService.<Article>items()
    .equalsFilter("system.type", "article")
    .orderParameter("system.last_modified", OrderType.Desc)
    .limitParameter(3)
    .get()
    .getItems();

// Gets the 3 latest articles ordered by their last modified time using RxJava2
deliveryService.<Article>items()
    .equalsFilter("system.type", "article")
    .orderParameter("system.last_modified", OrderType.Desc)
    .limitParameter(3)
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