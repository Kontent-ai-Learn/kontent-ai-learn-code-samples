// DocSection: delivery_api_get_taxonomy_groups
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

// Gets 3 taxonomy groups using a simple request
List<Taxonomy> taxonomies = deliveryService.taxonomies()
    .limitParameter(3)
    .get()
    .getTaxonomies();

// Gets 3 taxonomy groups using RxJava2
deliveryService.taxonomies()
    .limitParameter(3)
    .getObservable()
    .subscribe(new Observer<DeliveryTaxonomyListingResponse>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(DeliveryTaxonomyListingResponse response) {
            // Gets the taxonomy groups
            List<Taxonomy> taxonomies = response.getTaxonomies();
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection