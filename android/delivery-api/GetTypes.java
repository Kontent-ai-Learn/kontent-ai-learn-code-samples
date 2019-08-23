// DocSection: delivery_api_get_types
// Tip: Find more about Java/JavaRx SDKs at https://developer.kenticocloud.com/docs/javaandroid
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