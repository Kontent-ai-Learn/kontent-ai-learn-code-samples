// DocSection: delivery_api_get_element
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent_delivery_core.*;
import com.github.kentico.kontent_delivery_rx.*;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;
import io.reactivex.functions.Function;

// Prepares the DeliveryService configuration object
String projectId = "<YOUR_PROJECT_ID>";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId);

// Initializes a DeliveryService for Java projects
IDeliveryService deliveryService = new DeliveryService(config);

// Gets the "title" content element from the "article" type using a simple request
ContentTypeElement element = deliveryService.contenTypeElement("article", "title")
    .get()
    .getElement();

// Gets the "title" content element from the "article" type using RxJava2
deliveryService.contenTypeElement("article", "title")
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