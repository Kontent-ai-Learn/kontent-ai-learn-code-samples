// DocSection: managing_navigation_articles_depth
import com.kenticocloud.delivery_core.*;
import com.kenticocloud.delivery_rx.*;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;
import io.reactivex.functions.Function;

// Prepares an array to hold strongly-typed models
List<TypeResolver<?>> typeResolvers = new ArrayList<>();

// Registers the type resolver for articles
typeResolvers.add(new TypeResolver<>(NavigationItem.TYPE, new Function<Void, NavigationItem>() {
    @Override
    public NavigationItem apply(Void input) {
        return new NavigationItem();
    }
}));

// Prepares the DeliveryService configuration object
String projectId = "24246f25-946d-4ab4-b170-fadef22fe7b2";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId)
    .withTypeResolvers(typeResolvers);

// Initializes a DeliveryService for Java projects
IDeliveryService deliveryService = new DeliveryService(config);

// Gets navigation items and their linked items using a simple request
NavigationItem root = deliveryService.<NavigationItem>item("root_navigation_item")
    .depthParameter(5)
    .get()
    .getItem();

// Gets navigation items and their linked items using RxJava2
deliveryService.<NavigationItem>item("root_navigation_item")
    .depthParameter(5)
    .getObservable()
    .subscribe(new Observer<DeliveryItemResponse<NavigationItem>>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(DeliveryItemResponse<NavigationItem> response) {
            // Gets the item
            NavigationItem item = response.getItem();
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection