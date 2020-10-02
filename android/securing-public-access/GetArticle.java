// DocSection: securing_public_access_get_article
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid
import com.github.kentico.kontent_delivery_core.*;
import com.github.kentico.kontent_delivery_rx.*;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;
import io.reactivex.functions.Function;

// Prepares the DeliveryService configuration object
String projectId = "<YOUR_PROJECT_ID>";
String secureApiKey = "<YOUR_API_KEY>";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId)
    .withSecuredApiKey(secureApiKey);

// Gets the latest version of a content item using a simple request
ContentItem item = deliveryService.<ContentItem>item("my_article")
    .get()
    .getItem();

// Gets the latest version of a content item using RxJava2
deliveryService.<ContentItem>item("my_article")
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