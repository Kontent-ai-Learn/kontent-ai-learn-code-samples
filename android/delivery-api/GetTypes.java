// DocSection: delivery_api_get_types
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid
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

// Gets 3 content types using a simple request
List<ContentType> types = deliveryService.types()
    .limitParameter(3)
    .get()
    .getTypes();

// Gets 3 content types using RxJava2
deliveryService.types()
    .limitParameter(3)
    .getObservable()
    .subscribe(new Observer<DeliveryTypeListingResponse>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(DeliveryTypeListingResponse response) {
            // Gets content types from response
            List<ContentType> types = response.getTypes();
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection