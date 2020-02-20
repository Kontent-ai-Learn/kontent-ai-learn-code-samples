// DocSection: schedule_expiration_add_filter
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent_delivery_core.*;
import com.github.kentico.kontent_delivery_rx.*;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;
import io.reactivex.functions.Function;

Date now = new Date();

// Prepares an array to hold strongly-typed models
List<TypeResolver<?>> typeResolvers = new ArrayList<>();

// Registers the type resolvers
typeResolvers.add(new TypeResolver<>(LandingPage.TYPE, new Function<Void, LandingPage>() {
    @Override
    public LandingPage apply(Void input) {
        return new LandingPage();
    }
}));

// Prepares the DeliveryService configuration object
String projectId = "8d20758c-d74c-4f59-ae04-ee928c0816b7";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId)
    .withTypeResolvers(typeResolvers);

// Initializes a DeliveryService for Java projects
IDeliveryService deliveryService = new DeliveryService(config);

// Gets all landing pages using a simple request
List<LandingPage> landingPages = deliveryService.<LandingPage>items()
        .equalsFilter("system.type", "landing_page")
        .get()
        .getItems();

List<LandingPage> publishedItems = new ArrayList<>();

for (LandingPage page : landingPages) {
    if (
        page.getExpireAt() == null || page.getExpireAt().after(now)) {
        publishedItems.add(page);
    }
}

// Gets all landing pages using RxJava2
deliveryService.<LandingPage>items()
        .equalsFilter("system.type", "landing_page")
        .getObservable()
        .subscribe(new Observer<DeliveryItemListingResponse<LandingPage>>() {
            @Override
            public void onSubscribe(Disposable d) {
            }

            @Override
            public void onNext(DeliveryItemListingResponse<LandingPage> response) {
                Date now = new Date();

                // Gets the retrieved landing pages
                List<LandingPage> landingPages = response.getItems();

                List<LandingPage> publishedItems = new ArrayList<>();

              	// Filters the landing pages, keeping those that should be public
                for (LandingPage page : landingPages) {
                    if (page.getExpireAt() == null || page.getExpireAt().after(now)) {
                        publishedItems.add(page);
                    }
                }
            }

            @Override
            public void onError(Throwable e) {
            }

            @Override
            public void onComplete() {
            }
        });
// EndDocSection