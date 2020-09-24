// DocSection: getting_content_get_items
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid
import com.github.kentico.kontent_delivery_core.*;
import com.github.kentico.kontent_delivery_rx.*;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;
import io.reactivex.functions.Function;

// Prepares the DeliveryService configuration object
String projectId = "8d20758c-d74c-4f59-ae04-ee928c0816b7";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId);

// Initializes a DeliveryService for Java projects
IDeliveryService deliveryService = new DeliveryService(config);

// Gets all content items using a simple request
List<ContentItem> items = deliveryService.<ContentItem>items()
    .get()
    .getItems();

// Gets all content items using RxJava2
deliveryService.<ContentItem>items()
    .getObservable()
    .subscribe(new Observer<DeliveryItemListingResponse<ContentItem>>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(DeliveryItemListingResponse<ContentItem> response) {
            // Gets the content items
            List<ContentItem> items = response.getItems();
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection