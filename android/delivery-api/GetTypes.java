// DocSection: delivery_api_get_types
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

// Prepares the DeliveryService configuration object
DeliveryOptions options = DeliveryOptions.builder()
        .projectId("<YOUR_PROJECT_ID>")
        .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Gets 3 content types using a simple request
CompletionStage<ContentTypesListingResponse> types = client.getTypes(
    DeliveryParameterBuilder.params().page(null, 3).build()
);

// Gets 3 content types using RxJava
Observable.fromCompletionStage(types)
    .subscribe(new Observer<ContentTypesListingResponse>() {
        @Override
        public void onSubscribe(@NonNull Disposable d) {
        }

        @Override
        public void onNext(@NonNull ContentTypesListingResponse response) {
            // Gets content types from response
            List<ContentType> type = response.getTypes();
        }

        @Override
        public void onError(@NonNull Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection