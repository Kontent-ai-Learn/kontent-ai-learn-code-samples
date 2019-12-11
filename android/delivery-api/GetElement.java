// DocSection: delivery_api_get_element
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent_delivery_core.*;
import com.github.kentico.kontent_delivery_rx..*;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;
import io.reactivex.functions.Function;

// Prepares the DeliveryService configuration object
String projectId = "975bf280-fd91-488c-994c-2f04416e5ee3";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId);

// Initializes a DeliveryService for Java projects
IDeliveryService deliveryService = new DeliveryService(config);

// Gets the "Processing" content element from the "Coffee" type using a simple request
ContentTypeElement element = deliveryService.contenTypeElement("coffee", "processing")
    .get()
    .getElement();

// Gets the "Processing" content element from the "Coffee" type using RxJava2
deliveryService.contenTypeElement("coffee", "processing")
    .getObservable()
    .subscribe(new Observer<DeliveryContentTypeElementResponse>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(DeliveryContentTypeElementResponse response) {
            // Gets the content element
            ContentTypeElement element = response.getElement();
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection