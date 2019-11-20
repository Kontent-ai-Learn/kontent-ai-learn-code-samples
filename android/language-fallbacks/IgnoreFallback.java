// DocSection: language_fallbacks_ignore
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.kenticocloud.delivery_core.*;
import com.kenticocloud.delivery_rx.*;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;
import io.reactivex.functions.Function;

// Prepares the DeliveryService configuration object
String projectId = "975bf280-fd91-488c-994c-2f04416e5ee3";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId);

// Initializes a DeliveryService for Java projects
IDeliveryService deliveryService = new DeliveryService(config);

// Gets the Spanish variant of all content items (while ignoring language fallbacks) using a simple request
List<ContentItem> items = deliveryService.<ContentItem>items()
    .languageParameter("es-ES")
    .equalsFilter("system.language", "es-ES")
    .get()
    .getItems();

// Gets the Spanish variant of all content items (while ignoring language fallbacks) using RxJava2
deliveryService.<ContentItem>items()
    .languageParameter("es-ES")
    .equalsFilter("system.language", "es-ES")
    .getObservable()
    .subscribe(new Observer<DeliveryItemListingResponse<ContentItem>>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(DeliveryItemResponse<ContentItem> response) {
            // Gets the content items
            List<ConentItem> items = response.getItems();
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection
