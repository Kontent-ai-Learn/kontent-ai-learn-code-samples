// DocSection: securing_public_access_get_article
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

 // Prepares the DeliveryOptions configuration object
 DeliveryOptions options = DeliveryOptions.builder()
 .projectId("<YOUR_PROJECT_ID>")
 .productionApiKey("<YOUR_API_KEY>")
 .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Gets the latest version of a content item using a simple request
CompletionStage<ContentItemResponse> article = client.getItem("my_article");

// Gets the latest version of a content item using RxJava
Observable.fromCompletionStage(client.getItem("my_article"))
    .subscribe(new Observer<ContentItemResponse>() {
        @Override
        public void onSubscribe(@NonNull Disposable d) {
        }

        @Override
        public void onNext(@NonNull ContentItemResponse response) {
            // Gets the content item
            ContentItem item = response.getItem();
        }

        @Override
        public void onError(@NonNull Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection