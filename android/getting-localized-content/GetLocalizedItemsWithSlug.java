// DocSection: getting_localized_content_url_slug
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent_delivery_core.*;
import com.github.kentico.kontent_delivery_rx.*;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;
import io.reactivex.functions.Function;

// Prepares an array to hold strongly-typed models
List<TypeResolver<?>> typeResolvers = new ArrayList<>();

// Registers the type resolver for articles
typeResolvers.add(new TypeResolver<>(Home.TYPE, new Function<Void, Home>() {
    @Override
    public Home apply(Void input) {
        return new Home();
    }
}));

// Prepares the DeliveryService configuration object
String projectId = "975bf280-fd91-488c-994c-2f04416e5ee3";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId)
    .withTypeResolvers(typeResolvers);

// Initializes a DeliveryService for Java projects
IDeliveryService deliveryService = new DeliveryService(config);

// Gets the Spanish variant of a Home content item that has "inicio" in its "URL pattern" element using a simple request
List<Home> home = deliveryService.<Home>items()
    .languageParameter("es-ES")
    .equalsFilter("system.type", "home")
    .equalsFilter("elements.url_pattern", "inicio")
    .get()
    .getItems();

// Gets the Spanish variant of a Home content item that has "inicio" in its "URL pattern" element using RxJava2
deliveryService.<Home>items()
    .languageParameter("es-ES")
    .equalsFilter("system.type", "home")
    .equalsFilter("elements.url_pattern", "inicio")
    .getObservable()
    .subscribe(new Observer<DeliveryItemListingResponse<Home>>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(DeliveryItemResponse<Home> response) {
            // Gets the content items
            Home item = response.getItem();
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection