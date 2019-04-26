// DocSection: preview_content_get_article
import com.kenticocloud.delivery_core.*;
import com.kenticocloud.delivery_rx.*;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;
import io.reactivex.functions.Function;

// Prepares an array to hold strongly-typed models
List<TypeResolver<?>> typeResolvers = new ArrayList<>();

// Registers the type resolver for articles
typeResolvers.add(new TypeResolver<>(Article.TYPE, new Function<Void, Article>() {
    @Override
    public Article apply(Void input) {
        return new Article();
    }
}));

// Prepares the DeliveryService configuration object
String projectId = "<YOUR_PROJECT_ID>";
String previewApiKey = "<YOUR_PREVIEW_API_KEY>";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId)
  	.withTypeResolvers(typeResolvers)
    .withPreviewApiKey(previewApiKey);

// Initializes a DeliveryService for Java projects
IDeliveryService deliveryService = new DeliveryService(config);

// Gets the latest version of a content item using a simple request
Article item = deliveryService.<Article>item("on_roasts")
    .get()
    .getItem();

// Gets the latest version of a content item using RxJava2
deliveryService.<Article>item("on_roasts")
    .getObservable()
    .subscribe(new Observer<DeliveryItemResponse<Article>>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(DeliveryItemResponse<Article> response) {
            // Gets the article
            Article item = response.getItem();
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection