// DocSection: securing_public_access_get_article
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent_delivery_core.*;
import com.github.kentico.kontent_delivery_rx..*;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;
import io.reactivex.functions.Function;

// Prepares the DeliveryService configuration object
String projectId = "975bf280-fd91-488c-994c-2f04416e5ee3";
String secureApiKey = "<YOUR_API_KEY>";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId)
    .withSecuredApiKey(secureApiKey);

// Gets the latest version of a content item using a simple request
ContentItem item = deliveryService.<ContentItem>item("on_roasts")
    .get()
    .getItem();

// Gets the latest version of a content item using RxJava2
deliveryService.<ContentItem>item("on_roasts")
    .getObservable()
    .subscribe(new Observer<DeliveryItemResponse<ContentItem>>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(DeliveryItemResponse<ContentItem> response) {
            // Gets the content item
            ContentItem item = response.getItem();
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection