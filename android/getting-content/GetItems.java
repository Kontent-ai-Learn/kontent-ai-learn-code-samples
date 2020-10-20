// DocSection: getting_content_get_items
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

// Prepares the DeliveryOptions configuration object
DeliveryOptions options = DeliveryOptions.builder()
    .projectId("<YOUR_PROJECT_ID>")
    .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Gets all content items using a simple request
CompletionStage<ContentItemsListingResponse> items = client.getItems();

// Gets all content items using RxJava
Observable.fromCompletionStage(items)
    .subscribe(new Observer<ContentItemsListingResponse>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(ContentItemsListingResponse response) {
            // Gets the content items
            List<ContentItem> items = response.getItems();
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection