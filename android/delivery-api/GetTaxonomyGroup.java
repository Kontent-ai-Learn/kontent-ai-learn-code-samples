// DocSection: delivery_api_get_taxonomy_group
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

// Gets a taxonomy group using a simple request
Taxonomy taxonomy = deliveryService.taxonomy("personas")
    .get()
    .getTaxonomy();

// Gets a taxonomy group using RxJava2
deliveryService.taxonomy("personas")
    .getObservable()
    .subscribe(new Observer<DeliveryTaxonomyResponse>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(DeliveryTaxonomyResponse response) {
            // Gets the taxonomy group
            Taxonomy taxonomy = response.getTaxonomy();
        }

        @Override
        public void onError(Throwable e) {
            System.out.println(e.getMessage());
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection