// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

// Prepares the DeliveryService configuration object
DeliveryOptions options = DeliveryOptions.builder()
    .projectId("<YOUR_PROJECT_ID>")
    .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Gets a taxonomy group using a simple request
CompletionStage<TaxonomyGroup> personas = client.getTaxonomyGroup("personas");

// Gets a taxonomy group using RxJava
Observable.fromCompletionStage(personas)
    .subscribe(new Observer<TaxonomyGroup>() {
        @Override
        public void onSubscribe(@NonNull Disposable d) {
        }

        @Override
        public void onNext(@NonNull TaxonomyGroup taxonomyGroup) {
            TaxonomyGroup personasTaxonomyGroup = taxonomyGroup;
        }

        @Override
        public void onError(@NonNull Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection