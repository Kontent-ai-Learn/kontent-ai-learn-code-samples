// DocSection: delivery_api_get_type
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

// Prepares the DeliveryService configuration object
DeliveryOptions options = DeliveryOptions.builder()
    .projectId("<YOUR_PROJECT_ID>")
    .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Gets a content type using a simple request
CompletionStage<ContentType> type = client.getType("article");

// Gets a content type using RxJava2
Observable.fromCompletionStage(client.getType("article"))
    .subscribe(new Observer<ContentType>() {
        @Override
        public void onSubscribe(@NonNull Disposable d) {
        }

        @Override
        public void onNext(@NonNull ContentType contentType) {
            ContentType articleType = contentType;
        }

        @Override
        public void onError(@NonNull Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection